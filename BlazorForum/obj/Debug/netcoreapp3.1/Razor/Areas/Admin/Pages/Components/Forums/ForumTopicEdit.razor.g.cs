#pragma checksum "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "674b0862d13c59af4c788f86a9734e764a4ff932"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorForum.Areas.Admin.Pages.Components.Forums
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/manage/forums/{forumId:int}/categories/{categoryId:int}/topics/{topicId:int}/edit")]
    public partial class ForumTopicEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>编辑话题</h3>\n");
#line 9 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor"
 if (_topic != null)
{

#line default
#line hidden
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "section");
            __builder.AddAttribute(3, "class", "content-container");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 12 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor"
                         _topic

#line default
#line hidden
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 12 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor"
                                                UpdateTopicAsync

#line default
#line hidden
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "input-group");
                __builder2.AddMarkupContent(14, "\n                ");
                __builder2.AddMarkupContent(15, "<div class=\"input-group-prepend\">\n                    <label class=\"input-group-text\">名字</label>\n                </div>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 18 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor"
                                        _topic.Title

#line default
#line hidden
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _topic.Title = __value, _topic.Title))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _topic.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\n            ");
                __Blazor.BlazorForum.Areas.Admin.Pages.Components.Forums.ForumTopicEdit.TypeInference.CreateValidationMessage_0(__builder2, 23, 24, 
#line 20 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor"
                                      () => _topic.Title

#line default
#line hidden
                , 25, "text-danger");
                __builder2.AddMarkupContent(26, "\n\n            ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "container-fluid p-0");
                __builder2.AddMarkupContent(29, "\n                ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "row");
                __builder2.AddMarkupContent(32, "\r\n                    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "col-12 col-md-6");
                __builder2.AddMarkupContent(35, "\r\n                        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "input-group mt-2");
                __builder2.AddMarkupContent(38, "\r\n                            ");
                __builder2.AddMarkupContent(39, "<div class=\"input-group-prepend\">\r\n                                <label class=\"input-group-text\">是否显示</label>\r\n                            </div>\r\n                            ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddMarkupContent(42, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(43);
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 30 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor"
                                                            _topic.IsApproved

#line default
#line hidden
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _topic.IsApproved = __value, _topic.IsApproved))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => _topic.IsApproved));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                    \r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\n\n            ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "mt-2 ckeditor-container");
                __builder2.AddMarkupContent(55, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(56);
                __builder2.AddAttribute(57, "id", "TopicText");
                __builder2.AddAttribute(58, "class", "form-control");
                __builder2.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 48 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor"
                                                           _topic.TopicText

#line default
#line hidden
                ));
                __builder2.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _topic.TopicText = __value, _topic.TopicText))));
                __builder2.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _topic.TopicText));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\n\n            ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "mt-2");
                __builder2.AddMarkupContent(66, "\n                ");
                __builder2.AddMarkupContent(67, "<button class=\"btn btn-blazorforum mr-2\" type=\"submit\">更新</button>\n                ");
                __builder2.OpenElement(68, "a");
                __builder2.AddAttribute(69, "class", "btn btn-blazorforum");
                __builder2.AddAttribute(70, "href", 
#line 54 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor"
                          String.Format("/admin/manage/forums/{0}/categories/{1}/topics/{2}", 
                          forumId, categoryId, topicId)

#line default
#line hidden
                );
                __builder2.AddContent(71, "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(74, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\n");
#line 59 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 61 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor"
       
    [Parameter] public int forumId { get; set; }
    [Parameter] public int categoryId { get; set; }
    [Parameter] public int topicId { get; set; }
    private Models.ForumTopic _topic = new Models.ForumTopic();

    protected override async Task OnInitializedAsync()
    {
        _topic = await manageTopics.GetForumTopicAsync(topicId);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await jsRuntime.InvokeVoidAsync("methods.loadEditor", "TopicText");
        }
    }

    private async void UpdateTopicAsync()
    {
        // Should probably eventually validate to make sure topic text isn't empty (CKEditor has a placeholder tag)...but only administrators can edit it at this point.
        _topic.TopicText = await jsRuntime.InvokeAsync<string>("methods.getEditorText");
        _topic.IsModeratorChanged = true;
        _topic.EditedDate = DateTime.Now.ToUniversalTime();
        _topic.EditedBy = await new Domain.Utilities.Membership.UserInfo(userManager, authStateProvider).GetUserId();

        var updated = await manageTopics.UpdateTopicAsync(_topic);
        if (updated)
            navManager.NavigateTo(String.Format("/admin/manage/forums/{0}/categories/{1}/topics/{2}", forumId, categoryId, topicId));
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForumTopics manageTopics { get; set; }
    }
}
namespace __Blazor.BlazorForum.Areas.Admin.Pages.Components.Forums.ForumTopicEdit
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
    }
}
#pragma warning restore 1591
