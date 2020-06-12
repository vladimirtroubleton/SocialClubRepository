using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AuthDataLayer;
using AuthDataLayer.ModelBuilders;
using AuthDataLayer.Models;
using AuthDataLayer.Repositories;
using AuthDataLayer.Utils;
using Blazored.LocalStorage;
using FeedsDataLayer;
using FeedsDataLayer.Repositories;
using FilesManageDataLayer;
using FilesManageDataLayer.Repositories;
using FriendsAndSocailDataLayer;
using FriendsAndSocailDataLayer.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.JSInterop;
using SocialClubApp.Data;
using SocialClubApp.Services;
using SocialClubApp.Services.Feed;
using SocialClubApp.Services.Socials;

namespace SocialClubApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddBlazoredLocalStorage();
            services.AddServerSideBlazor();
            services.AddRazorPages();

           
            services.AddDbContext<UserContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DbConnectionString")));
            services.AddDbContext<FileContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("FilesContext")));
            services.AddDbContext<FeedsContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("FeedsContext"))); 
            services.AddDbContext<SocialContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SocialContext")));


            services.AddAuthorizationCore(config =>
            {
                config.AddPolicy(Policies.IsAdmin, Policies.IsAdminPolicy());
                config.AddPolicy(Policies.IsUser, Policies.IsUserPolicy());
            });
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(options =>
                    {
                        options.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateIssuer = true,
                            ValidateAudience = true,
                            ValidateLifetime = true,
                            ValidateIssuerSigningKey = true,
                            ValidIssuer = Configuration["JwtIssuer"],
                            ValidAudience = Configuration["JwtAudience"],
                            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtSecurityKey"]))
                        };
                    });
            
            services.AddResponseCompression(opts =>
            {
                opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                    new[] { "application/octet-stream" });
            });

            services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
            services.AddScoped<IPasswordHash , PasswordHash>();
            services.AddScoped<IUsersRepository , UsersRepository>();
            services.AddScoped<IUsersModelBuilder, UsersModelBuilder>();
            services.AddScoped<ILoginUtil, LoginUtil>();
            services.AddScoped<IFilesRepository, FilesRepository>();
            services.AddScoped<IFeedsRepository, FeedsRepository>();
            services.AddScoped<IFriendsRepository, FriendsRepository>();
            services.AddScoped<IGroupRepository, GroupRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<FilesService>();
            services.AddScoped<UserService>();
            services.AddScoped<FeedsService>();
            services.AddScoped<SocialService>();
            services.AddScoped<CommentService>();

            services.AddHttpClient();
            services.AddScoped<HttpClient>();
            services.AddHttpContextAccessor();
            services.AddScoped<HttpContextAccessor>();
          

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCookiePolicy();
            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
