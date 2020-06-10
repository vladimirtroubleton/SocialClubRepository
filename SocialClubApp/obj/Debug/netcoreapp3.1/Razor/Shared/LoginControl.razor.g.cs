#pragma checksum "D:\Projects\SocialClubRepository\SocialClubApp\Shared\LoginControl.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6e30cf994a1cc2ccf04dbe589cfa1cca5ec0ba6"
// <auto-generated/>
#pragma warning disable 1591
namespace SocialClubApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\SocialClubRepository\SocialClubApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\SocialClubRepository\SocialClubApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\SocialClubRepository\SocialClubApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\SocialClubRepository\SocialClubApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\SocialClubRepository\SocialClubApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\SocialClubRepository\SocialClubApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\SocialClubRepository\SocialClubApp\_Imports.razor"
using SocialClubApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\SocialClubRepository\SocialClubApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\SocialClubRepository\SocialClubApp\_Imports.razor"
using SocialClubApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\SocialClubRepository\SocialClubApp\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\SocialClubRepository\SocialClubApp\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\SocialClubRepository\SocialClubApp\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\SocialClubRepository\SocialClubApp\Shared\LoginControl.razor"
using AuthDataLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\SocialClubRepository\SocialClubApp\Shared\LoginControl.razor"
using AuthDataLayer.ViewModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/loginControl")]
    public partial class LoginControl : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(3);
            __builder.AddAttribute(4, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)(( Auth ) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n                ");
                __builder2.AddContent(6, 
#nullable restore
#line 11 "D:\Projects\SocialClubRepository\SocialClubApp\Shared\LoginControl.razor"
                 Auth.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(7, "\r\n            ");
            }
            ));
            __builder.AddAttribute(8, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)(( NoAuth ) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n                ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "row");
                __builder2.AddMarkupContent(12, "\r\n                    ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-5 mx-auto text-center");
                __builder2.AddMarkupContent(15, "\r\n                        ");
                __builder2.OpenElement(16, "p");
                __builder2.AddAttribute(17, "style", " " + (
#nullable restore
#line 16 "D:\Projects\SocialClubRepository\SocialClubApp\Shared\LoginControl.razor"
                                    style

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(18, 
#nullable restore
#line 16 "D:\Projects\SocialClubRepository\SocialClubApp\Shared\LoginControl.razor"
                                            logRes.Error

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(20);
                __builder2.AddAttribute(21, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "D:\Projects\SocialClubRepository\SocialClubApp\Shared\LoginControl.razor"
                                          userLoginModel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "D:\Projects\SocialClubRepository\SocialClubApp\Shared\LoginControl.razor"
                                                                         LogIn

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(24, "\r\n                            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(25);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\r\n                            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(27);
                    __builder3.AddAttribute(28, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "D:\Projects\SocialClubRepository\SocialClubApp\Shared\LoginControl.razor"
                                                       userLoginModel

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\r\n\r\n\r\n\r\n                            ");
                    __builder3.OpenElement(30, "div");
                    __builder3.AddAttribute(31, "class", "form-group");
                    __builder3.AddMarkupContent(32, "\r\n                                ");
                    __builder3.AddMarkupContent(33, "<label class=\"control-label\">Введите логин</label>\r\n                                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(34);
                    __builder3.AddAttribute(35, "class", "form-control");
                    __builder3.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\Projects\SocialClubRepository\SocialClubApp\Shared\LoginControl.razor"
                                                        userLoginModel.Login

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userLoginModel.Login = __value, userLoginModel.Login))));
                    __builder3.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userLoginModel.Login));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n                                ");
                    __Blazor.SocialClubApp.Shared.LoginControl.TypeInference.CreateValidationMessage_0(__builder3, 40, 41, 
#nullable restore
#line 26 "D:\Projects\SocialClubRepository\SocialClubApp\Shared\LoginControl.razor"
                                                          () => userLoginModel.Login

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(42, "\r\n                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(43, "\r\n\r\n                            ");
                    __builder3.OpenElement(44, "div");
                    __builder3.AddAttribute(45, "style", true);
                    __builder3.AddAttribute(46, "class", "form-group");
                    __builder3.AddMarkupContent(47, "\r\n                                ");
                    __builder3.AddMarkupContent(48, "<label class=\"control-label\">Введите пароль</label>\r\n                                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(49);
                    __builder3.AddAttribute(50, "class", "form-control");
                    __builder3.AddAttribute(51, "type", "password");
                    __builder3.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "D:\Projects\SocialClubRepository\SocialClubApp\Shared\LoginControl.razor"
                                                        userLoginModel.Password

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userLoginModel.Password = __value, userLoginModel.Password))));
                    __builder3.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userLoginModel.Password));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\r\n                                ");
                    __Blazor.SocialClubApp.Shared.LoginControl.TypeInference.CreateValidationMessage_1(__builder3, 56, 57, 
#nullable restore
#line 32 "D:\Projects\SocialClubRepository\SocialClubApp\Shared\LoginControl.razor"
                                                          () => userLoginModel.Password

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(58, "\r\n                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(59, "\r\n\r\n\r\n                            ");
                    __builder3.AddMarkupContent(60, "<button class=\"ml-md-auto btn btn-outline-success\" type=\"submit\">\r\n                                Вход\r\n                            </button>\r\n\r\n\r\n\r\n\r\n\r\n\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n                        ");
                __builder2.AddMarkupContent(62, "<a class=\"btn btn-outline-primary\" style=\"margin-top:10px;\" href=\"/Account/Register\">Регистрация</a>\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                   \r\n                \r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(65, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "D:\Projects\SocialClubRepository\SocialClubApp\Shared\LoginControl.razor"
           
        LoginViewModel userLoginModel = new LoginViewModel();

        string style="visibility:hidden ; color:red";

        AuthDataLayer.ResultModels.LoginResult logRes = new AuthDataLayer.ResultModels.LoginResult();

        private async Task LogIn()
        {
            logRes = await authServ.Login(userLoginModel);
            if (logRes.Successful)
            {
                UriHelper.NavigateTo("/");
            }
            style = "color:red";
           
        }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SocialClubApp.Services.IAuthService authServ { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.SocialClubApp.Shared.LoginControl
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
