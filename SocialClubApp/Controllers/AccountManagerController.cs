using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AuthDataLayer.ModelBuilders;
using AuthDataLayer.Repositories;
using AuthDataLayer.ResultModels;
using AuthDataLayer.Utils;
using AuthDataLayer.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace SocialClubApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountManagerController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IUsersRepository usersRepository;
        private readonly IPasswordHash passwordHash;
        private readonly IUsersModelBuilder usersModelBuilder;
        private readonly ILoginUtil loginUtil;

        public AccountManagerController(IConfiguration configuration, IUsersRepository usersRepository, IPasswordHash passwordHash, IUsersModelBuilder usersModelBuilder, ILoginUtil loginUtil)
        {
            _configuration = configuration;
            this.usersRepository = usersRepository;
            this.passwordHash = passwordHash;
            this.usersModelBuilder = usersModelBuilder;
            this.loginUtil = loginUtil;
        }

        [HttpPost("Login")]
        public async Task<LoginResult> Login(LoginViewModel login)
        {
             
             var loggingUser = await loginUtil.CheckUserDataByLoginViewModel(login);
            if (loggingUser == null)
            {
                return new LoginResult { Error = "Ошибка входа , возможно вы ввели не верный пароль или не зарегистрированы", Successful = false };
            }

            

            var claims = new[]
            {
            new Claim(ClaimTypes.Name, loggingUser.Login)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JwtExpiryInDays"]));

            var token = new JwtSecurityToken(
                _configuration["JwtIssuer"],
                _configuration["JwtAudience"],
                claims,
                expires: expiry,
                signingCredentials: creds
            );

            return new LoginResult { Successful = true, Token = new JwtSecurityTokenHandler().WriteToken(token) };
        }


        [HttpPost("Register")]
        public async Task<RegisterResult> Register(UserViewModel registerModel)
        {
            registerModel.Password = passwordHash.GetHash(registerModel.Password);
            var userModel = usersModelBuilder.GetUserModelByUserView(registerModel);
            await usersRepository.AddUser(userModel);

            return new RegisterResult { Successful = true };
        }
    }
}