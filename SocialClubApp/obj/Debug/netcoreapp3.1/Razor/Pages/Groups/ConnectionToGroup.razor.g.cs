#pragma checksum "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\ConnectionToGroup.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91eff43f3f53c89f8966a9ce19efcf9ff17f66f9"
// <auto-generated/>
#pragma warning disable 1591
namespace SocialClubApp.Pages.Groups
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Release\SocialClubRepository\SocialClubApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Release\SocialClubRepository\SocialClubApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Release\SocialClubRepository\SocialClubApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Release\SocialClubRepository\SocialClubApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Release\SocialClubRepository\SocialClubApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Release\SocialClubRepository\SocialClubApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Release\SocialClubRepository\SocialClubApp\_Imports.razor"
using SocialClubApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Release\SocialClubRepository\SocialClubApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Release\SocialClubRepository\SocialClubApp\_Imports.razor"
using SocialClubApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Release\SocialClubRepository\SocialClubApp\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Release\SocialClubRepository\SocialClubApp\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Release\SocialClubRepository\SocialClubApp\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\ConnectionToGroup.razor"
using AuthDataLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\ConnectionToGroup.razor"
using SocialClubApp.StaticUtils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\ConnectionToGroup.razor"
using FriendsAndSocailDataLayer.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/connectGroup")]
    public partial class ConnectionToGroup : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"row\">\r\n        <a href=\"/addGroup\" class=\"btn btn-outline-dark\">Добавить новое объеденение</a>\r\n    </div>\r\n    <hr>\r\n");
#nullable restore
#line 17 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\ConnectionToGroup.razor"
     if (groups != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\ConnectionToGroup.razor"
         foreach (var group in groups)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "            ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.AddMarkupContent(7, "\r\n                ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-4");
            __builder.AddMarkupContent(10, "Название группы: ");
            __builder.OpenElement(11, "p");
            __builder.AddContent(12, 
#nullable restore
#line 22 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\ConnectionToGroup.razor"
                                                        group.NameGroup

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-4");
            __builder.AddMarkupContent(16, "Логин владельца: ");
            __builder.OpenElement(17, "p");
            __builder.AddContent(18, 
#nullable restore
#line 23 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\ConnectionToGroup.razor"
                                                        group.CreatorLogin

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-4");
            __builder.AddMarkupContent(22, "Количество товарищей: ");
            __builder.OpenElement(23, "p");
            __builder.AddContent(24, 
#nullable restore
#line 24 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\ConnectionToGroup.razor"
                                                             group.CountUsersInGroup

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-4");
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 26 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\ConnectionToGroup.razor"
                     if (groupConnectIds.Contains(group.Id))
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "                        ");
            __builder.AddMarkupContent(30, "<button class=\"btn btn-outline-info\">\r\n                            Вступили уже\r\n                        </button>\r\n");
#nullable restore
#line 31 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\ConnectionToGroup.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "                        ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "btn btn-outline-success");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\ConnectionToGroup.razor"
                                            e => CreateConnect(e, group.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(35, "\r\n                            Присоедениться\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 38 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\ConnectionToGroup.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 42 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\ConnectionToGroup.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\ConnectionToGroup.razor"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "        ");
            __builder.AddMarkupContent(41, "<p> Тут пока пусто</p>\r\n");
#nullable restore
#line 47 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\ConnectionToGroup.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\ConnectionToGroup.razor"
       
    UserModel currentUser;
    GroupConnect[] groupsConnectUser;
    GroupModel[] groups;
    List<int> groupConnectIds;
    protected override async Task OnInitializedAsync()
    {
        var authState = await authProvider.GetAuthenticationStateAsync();
        currentUser = await userServ.GetCurrentUser(authState.User.Identity.Name);
        groupsConnectUser = await socialServ.GetGroupIdsByUser(currentUser);
        groups = await socialServ.GetAllGroups();
        groupConnectIds = groupsConnectUser.Select(x=> x.Id).ToList();

    }
    public async Task CreateConnect(EventArgs e, int id)
    {
        await socialServ.CreateGroupConnect(id, currentUser);
        groupConnectIds.Add(id);
        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SocialClubApp.Services.Socials.SocialService socialServ { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SocialClubApp.Services.FilesService fileServ { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SocialClubApp.Services.UserService userServ { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SocialClubApp.Services.IAuthService authServ { get; set; }
    }
}
#pragma warning restore 1591
