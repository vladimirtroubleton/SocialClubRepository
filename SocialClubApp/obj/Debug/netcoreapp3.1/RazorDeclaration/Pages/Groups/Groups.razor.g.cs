#pragma checksum "D:\Projects\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a54d105597de6295a6b68aafb3604fa5fc3ec55"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SocialClubApp.Pages.Groups
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
#line 4 "D:\Projects\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
using AuthDataLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
using SocialClubApp.StaticUtils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\Projects\SocialClubRepository\SocialClubApp\Pages\Groups\Groups.razor"
       
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
