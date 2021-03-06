#pragma checksum "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Configuration\Configuration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1a9ad3be1c19e3a410b3086ece6437053145d0c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorForum.Areas.Admin.Pages.Components.Configuration
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 9 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum;

#line default
#line hidden
#line 10 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum.Shared;

#line default
#line hidden
#line 12 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using Domain.Resources;

#line default
#line hidden
#line 13 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum.Domain.Interfaces;

#line default
#line hidden
#line 15 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using Domain.Utilities.Formatting;

#line default
#line hidden
#line 16 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum.Pages.Components.BlazorModal;

#line default
#line hidden
#line 17 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum.Pages.Components.BlazorModal.Components;

#line default
#line hidden
#line 1 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 3 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 4 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 5 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 6 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 7 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 8 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 9 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Areas.Admin;

#line default
#line hidden
#line 10 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Areas.Admin.Shared;

#line default
#line hidden
#line 11 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Models;

#line default
#line hidden
#line 12 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Domain.Services;

#line default
#line hidden
#line 13 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using System.Linq;

#line default
#line hidden
#line 14 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#line 15 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Pages.Components.Head;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/manage/configuration")]
    public partial class Configuration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Site Configuration</h3>\n");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "content-container");
            __builder.AddMarkupContent(3, "\n");
#line 8 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Configuration\Configuration.razor"
     if (_config != null)
    {

#line default
#line hidden
            __builder.AddContent(4, "        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 10 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Configuration\Configuration.razor"
                         _config

#line default
#line hidden
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 10 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Configuration\Configuration.razor"
                                                 UpdateConfigAsync

#line default
#line hidden
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n\n            ");
                __builder2.AddMarkupContent(12, "<h4>Email</h4>\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "input-group mt-2");
                __builder2.AddMarkupContent(15, "\n                ");
                __builder2.AddMarkupContent(16, "<div class=\"input-group-prepend\">\n                    <label class=\"input-group-text\">Email Address</label>\n                </div>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 18 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Configuration\Configuration.razor"
                                        _config.EmailAddress

#line default
#line hidden
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _config.EmailAddress = __value, _config.EmailAddress))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _config.EmailAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\n            ");
                __Blazor.BlazorForum.Areas.Admin.Pages.Components.Configuration.Configuration.TypeInference.CreateValidationMessage_0(__builder2, 24, 25, 
#line 20 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Configuration\Configuration.razor"
                                      () => _config.EmailAddress

#line default
#line hidden
                , 26, "text-danger");
                __builder2.AddMarkupContent(27, "\n\n            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "input-group mt-2");
                __builder2.AddMarkupContent(30, "\n                ");
                __builder2.AddMarkupContent(31, "<div class=\"input-group-prepend\">\n                    <label class=\"input-group-text\">From Name</label>\n                </div>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 26 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Configuration\Configuration.razor"
                                        _config.EmailSenderName

#line default
#line hidden
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _config.EmailSenderName = __value, _config.EmailSenderName))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _config.EmailSenderName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\n            ");
                __Blazor.BlazorForum.Areas.Admin.Pages.Components.Configuration.Configuration.TypeInference.CreateValidationMessage_1(__builder2, 39, 40, 
#line 28 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Configuration\Configuration.razor"
                                      () => _config.EmailSenderName

#line default
#line hidden
                , 41, "text-danger");
                __builder2.AddMarkupContent(42, "\n\n            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "input-group mt-2");
                __builder2.AddMarkupContent(45, "\n                ");
                __builder2.AddMarkupContent(46, "<div class=\"input-group-prepend\">\n                    <label class=\"input-group-text\">SendGrid Key</label>\n                </div>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 34 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Configuration\Configuration.razor"
                                        _config.SendGridKey

#line default
#line hidden
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _config.SendGridKey = __value, _config.SendGridKey))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _config.SendGridKey));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\n            ");
                __Blazor.BlazorForum.Areas.Admin.Pages.Components.Configuration.Configuration.TypeInference.CreateValidationMessage_2(__builder2, 54, 55, 
#line 36 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Configuration\Configuration.razor"
                                      () => _config.SendGridKey

#line default
#line hidden
                , 56, "text-danger");
                __builder2.AddMarkupContent(57, "\n\n            ");
                __builder2.AddMarkupContent(58, "<div class=\"p-2 bg-light-gray rounded-top mt-2\">Registration Approval Message</div>\n            ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "ckeditor-container");
                __builder2.AddMarkupContent(61, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(62);
                __builder2.AddAttribute(63, "id", "RegistrationApprovalMessage");
                __builder2.AddAttribute(64, "class", "form-control");
                __builder2.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 40 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Configuration\Configuration.razor"
                                                                             _config.RegistrationApprovalMessage

#line default
#line hidden
                ));
                __builder2.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _config.RegistrationApprovalMessage = __value, _config.RegistrationApprovalMessage))));
                __builder2.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _config.RegistrationApprovalMessage));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\n            ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "mt-2");
                __builder2.AddMarkupContent(72, "\n                ");
                __builder2.AddMarkupContent(73, "<button class=\"btn btn-blazorforum\" type=\"submit\">更新</button>\n                ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", (
#line 44 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Configuration\Configuration.razor"
                             _successDisplay

#line default
#line hidden
                ) + " ml-2" + " bg-success" + " rounded" + " p-1");
                __builder2.AddContent(76, "Successfully Updated");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(79, "\n");
#line 47 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Configuration\Configuration.razor"
    }

#line default
#line hidden
            __builder.AddMarkupContent(80, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 51 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Configuration\Configuration.razor"
       
    private Models.Configuration _config;
    private string _successDisplay = "d-none";

    protected override async Task OnInitializedAsync()
    {
        _config = await manageConfig.GetConfigAsync();
        head.Title = "Configuration | Administration";
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await jsRuntime.InvokeVoidAsync("methods.loadEditor", "RegistrationApprovalMessage");
        }
    }

    private async Task UpdateConfigAsync()
    {
        _config.RegistrationApprovalMessage = await jsRuntime.InvokeAsync<string>("methods.getEditorText");
        var updated = await manageConfig.UpdateConfigAsync(_config);
        if (updated)
        {
            _successDisplay = "d-inline-block";
            StateHasChanged();
            await Task.Delay(3000);
            _successDisplay = "d-none";
            StateHasChanged();
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HeadBuilderService head { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageConfiguration manageConfig { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
namespace __Blazor.BlazorForum.Areas.Admin.Pages.Components.Configuration.Configuration
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
