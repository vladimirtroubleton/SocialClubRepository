<<<<<<< HEAD
#pragma checksum "D:\Projects\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e46da546825e6c3f9fc971ba6aa384cf3fcc6bd4"
=======
#pragma checksum "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a54d105597de6295a6b68aafb3604fa5fc3ec55"
>>>>>>> 893cc7fa71438f68c161940e885ac79721a171fc
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
#line 4 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
using AuthDataLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
using SocialClubApp.StaticUtils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
using FeedsDataLayer.FeedViewModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/groups")]
    public partial class Groups : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h4>Ваши объеденения</h4>\r\n<hr>\r\n\r\n");
#nullable restore
#line 14 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
 if (groups == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<div class=\"container\">\r\n        <p> Вы еще не присоеденились ни к одному обьеденению</p>\r\n        <a href=\"/connectGroup\" class=\"btn btn-outline-secondary\">Присоеденится !</a>\r\n    </div>\r\n");
#nullable restore
#line 20 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddMarkupContent(6, "<a href=\"/connectGroup\" class=\"btn btn-outline-secondary\">Присоеденится к другим объеденениям!</a>\r\n    <hr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 27 "D:\Projects\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
             foreach (var item in groups)
            {
=======
#line 27 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
     foreach (var group in groups)
    {
        {
>>>>>>> 893cc7fa71438f68c161940e885ac79721a171fc

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "                ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card");
            __builder.AddMarkupContent(10, "\r\n\r\n                    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body text-center");
            __builder.AddMarkupContent(13, "\r\n\r\n                        ");
            __builder.AddMarkupContent(14, "<div class=\"card-text\"><p class=\"font-weight-bold\">Название группы</p></div>\r\n                        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card-title");
            __builder.AddContent(17, 
#nullable restore
<<<<<<< HEAD
#line 34 "D:\Projects\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
                                                 item.NameGroup
=======
#line 31 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
                                                         group.NameGroup
>>>>>>> 893cc7fa71438f68c161940e885ac79721a171fc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.AddMarkupContent(19, "<div class=\"card-text\"><p class=\"font-weight-bold\">Владелец</p></div>\r\n                        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "card-title");
            __builder.AddContent(22, 
#nullable restore
<<<<<<< HEAD
#line 36 "D:\Projects\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
                                                 item.CreatorLogin
=======
#line 32 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
                                                         group.CreatorLogin
>>>>>>> 893cc7fa71438f68c161940e885ac79721a171fc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.AddMarkupContent(24, "<div class=\"card-text\"><p class=\"font-weight-bold\">Количество товарищей</p></div>\r\n                        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "card-title");
            __builder.AddContent(27, 
#nullable restore
<<<<<<< HEAD
#line 38 "D:\Projects\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
                                                 item.CountUsersInGroup
=======
#line 33 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
                                                              group.CountUsersInGroup
>>>>>>> 893cc7fa71438f68c161940e885ac79721a171fc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                <hr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 42 "D:\Projects\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
             }
=======
#line 36 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
        }
    }
>>>>>>> 893cc7fa71438f68c161940e885ac79721a171fc

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "          \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
<<<<<<< HEAD
#line 45 "D:\Projects\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
} 
=======
#line 39 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
}
>>>>>>> 893cc7fa71438f68c161940e885ac79721a171fc

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 49 "D:\Projects\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
=======
#line 43 "D:\Release\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
>>>>>>> 893cc7fa71438f68c161940e885ac79721a171fc
       
    UserModel currentUser;
    FriendsAndSocailDataLayer.Models.GroupConnect[] groupsConnectUser;
    FriendsAndSocailDataLayer.Models.GroupModel[] groups;
    protected override async Task OnInitializedAsync()
    {
        var authState = await authProvider.GetAuthenticationStateAsync();
        currentUser = await userServ.GetCurrentUser(authState.User.Identity.Name);
        groupsConnectUser = await socialServ.GetGroupIdsByUser(currentUser);
        groups = await socialServ.GetGroupsByConnectRecords(groupsConnectUser);
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
