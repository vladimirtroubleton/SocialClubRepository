#pragma checksum "D:\Projects\SocialClubRepository\SocialClubApp\Pages\Feeds\AddFeed.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f78b5750f5ddb34b7aaedd242786252f79226cb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SocialClubApp.Pages.Feeds
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
#line 2 "D:\Projects\SocialClubRepository\SocialClubApp\Pages\Feeds\AddFeed.razor"
using FeedsDataLayer.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addFeed")]
    public partial class AddFeed : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "D:\Projects\SocialClubRepository\SocialClubApp\Pages\Feeds\AddFeed.razor"
       
    FeedModel feedModel = new FeedModel();

    FilesManageDataLayer.Models.FileModel[] filesLoad;

    FilesManageDataLayer.Models.FileModel fileLoad;

    string fileStatus;

    Guid feedId;

    private async Task AddFeedInDb()
    {
        if(filesLoad != null)
        {

        }
        if(fileLoad != null)
        {

        }
        await feedServ.CreateFeed(feedModel);

    }

    private async Task HandleSelection(IFileListEntry[] files)
    {

        if (files != null)
        {
            if (files.Count() == 1)
            {
                var file = files.FirstOrDefault();
                fileLoad = await fileServ.CreateFile(file);
                fileStatus = $"Загрузка файла {file.Name} завершена";
            }
            else
            {
                filesLoad = await fileServ.CreateFiles(files);
                fileStatus = $"Загрузка файла  завершена";
            }

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SocialClubApp.Services.IAuthService authServ { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SocialClubApp.Services.FilesService fileServ { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SocialClubApp.Services.FeedsService feedServ { get; set; }
    }
}
#pragma warning restore 1591
