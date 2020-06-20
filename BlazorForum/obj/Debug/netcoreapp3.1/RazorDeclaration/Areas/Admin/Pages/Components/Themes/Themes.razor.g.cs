#pragma checksum "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\Pages\Components\Themes\Themes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26843deb92799da2255fb4628bad1b37fc462675"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorForum.Areas.Admin.Pages.Components.Themes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 9 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using BlazorForum;

#line default
#line hidden
#line 10 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using BlazorForum.Shared;

#line default
#line hidden
#line 12 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using Domain.Resources;

#line default
#line hidden
#line 13 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using BlazorForum.Domain.Interfaces;

#line default
#line hidden
#line 15 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using Domain.Utilities.Formatting;

#line default
#line hidden
#line 16 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using BlazorForum.Pages.Components.BlazorModal;

#line default
#line hidden
#line 17 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using BlazorForum.Pages.Components.BlazorModal.Components;

#line default
#line hidden
#line 1 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 3 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 4 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 5 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 6 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 7 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 8 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 9 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Areas.Admin;

#line default
#line hidden
#line 10 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Areas.Admin.Shared;

#line default
#line hidden
#line 11 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Models;

#line default
#line hidden
#line 12 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Domain.Services;

#line default
#line hidden
#line 13 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using System.Linq;

#line default
#line hidden
#line 14 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#line 15 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Pages.Components.Head;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/manage/themes/")]
    public partial class Themes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 36 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\Pages\Components\Themes\Themes.razor"
       
    private Theme sitetheme = new Theme();
    private List<ThemeInfo> themeInfoList = new List<ThemeInfo>();
    private string selectedTheme;

    protected override async Task OnInitializedAsync()
    {
        head.Title = "Themes | Administration";
        selectedTheme = await manageThemes.GetSelectedThemeNameAsync();

        var themes = System.IO.Directory.GetDirectories("wwwroot/custom-themes/");

        foreach (var theme in themes)
        {
            var lines = System.IO.File.ReadLines(theme + "/styles.css");

            if (lines != null && lines.Count() > 0)
            {
                var themeInfo = new ThemeInfo
                {
                    ThemeName = GetThemeInfo(lines, "Theme Name").Replace("Theme Name:", "").Trim(),
                    TextDomain = GetThemeInfo(lines, "Text Domain").Replace("Text Domain:", "").Trim(),
                    Author = GetThemeInfo(lines, "Author").Replace("Author:", "").Trim(),
                    Description = GetThemeInfo(lines, "Description").Replace("Description:","").Trim(),
                    Version = GetThemeInfo(lines, "Version").Replace("Version:","").Trim()
                };
                themeInfoList.Add(themeInfo);
            }
        }
    }

    private string GetThemeInfo(IEnumerable<string> lines, string ThemeProperty)
    {
        var line = lines.SkipWhile(p => !p.Contains(ThemeProperty + ":"))
            .TakeWhile(p => p.Contains(ThemeProperty + ":")).FirstOrDefault();
        return line;
    }

    private async Task UnselectTheme()
    {
        var removed = await manageThemes.RemoveThemesAsync();
        if(removed)
            selectedTheme = await manageThemes.GetSelectedThemeNameAsync();
        StateHasChanged();
    }

    private async Task SelectTheme(string textDomain)
    {
        var added = await manageThemes.AddThemeAsync(textDomain);
        if(added)
            selectedTheme = await manageThemes.GetSelectedThemeNameAsync();
        StateHasChanged();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageThemes manageThemes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HeadBuilderService head { get; set; }
    }
}
#pragma warning restore 1591