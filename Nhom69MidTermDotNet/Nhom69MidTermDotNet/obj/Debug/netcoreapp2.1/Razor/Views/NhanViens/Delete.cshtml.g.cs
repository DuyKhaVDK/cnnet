#pragma checksum "D:\HOC\NĂM 3\CONG NGHE .NET\NET_Nhom69-master\Nhom69MidTermDotNet\Nhom69MidTermDotNet\Views\NhanViens\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a4991ec0c4e56ca568a9e125a9e55ddb4cdcd7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanViens_Delete), @"mvc.1.0.view", @"/Views/NhanViens/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NhanViens/Delete.cshtml", typeof(AspNetCore.Views_NhanViens_Delete))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\HOC\NĂM 3\CONG NGHE .NET\NET_Nhom69-master\Nhom69MidTermDotNet\Nhom69MidTermDotNet\Views\_ViewImports.cshtml"
using Nhom69MidTermDotNet;

#line default
#line hidden
#line 2 "D:\HOC\NĂM 3\CONG NGHE .NET\NET_Nhom69-master\Nhom69MidTermDotNet\Nhom69MidTermDotNet\Views\_ViewImports.cshtml"
using Nhom69MidTermDotNet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a4991ec0c4e56ca568a9e125a9e55ddb4cdcd7c", @"/Views/NhanViens/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"892ef74406aa378fc256ed9bd1ada717dc9fa31c", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanViens_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Nhom69MidTermDotNet.Models.NhanVien>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\HOC\NĂM 3\CONG NGHE .NET\NET_Nhom69-master\Nhom69MidTermDotNet\Nhom69MidTermDotNet\Views\NhanViens\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(83, 160, true);
            WriteLiteral("\n<h2>Delete</h2>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>NhanVien</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(244, 41, false);
#line 15 "D:\HOC\NĂM 3\CONG NGHE .NET\NET_Nhom69-master\Nhom69MidTermDotNet\Nhom69MidTermDotNet\Views\NhanViens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Hoten));

#line default
#line hidden
            EndContext();
            BeginContext(285, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(326, 37, false);
#line 18 "D:\HOC\NĂM 3\CONG NGHE .NET\NET_Nhom69-master\Nhom69MidTermDotNet\Nhom69MidTermDotNet\Views\NhanViens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Hoten));

#line default
#line hidden
            EndContext();
            BeginContext(363, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(404, 42, false);
#line 21 "D:\HOC\NĂM 3\CONG NGHE .NET\NET_Nhom69-master\Nhom69MidTermDotNet\Nhom69MidTermDotNet\Views\NhanViens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Diachi));

#line default
#line hidden
            EndContext();
            BeginContext(446, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(487, 38, false);
#line 24 "D:\HOC\NĂM 3\CONG NGHE .NET\NET_Nhom69-master\Nhom69MidTermDotNet\Nhom69MidTermDotNet\Views\NhanViens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Diachi));

#line default
#line hidden
            EndContext();
            BeginContext(525, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(566, 43, false);
#line 27 "D:\HOC\NĂM 3\CONG NGHE .NET\NET_Nhom69-master\Nhom69MidTermDotNet\Nhom69MidTermDotNet\Views\NhanViens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LuongCb));

#line default
#line hidden
            EndContext();
            BeginContext(609, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(650, 39, false);
#line 30 "D:\HOC\NĂM 3\CONG NGHE .NET\NET_Nhom69-master\Nhom69MidTermDotNet\Nhom69MidTermDotNet\Views\NhanViens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LuongCb));

#line default
#line hidden
            EndContext();
            BeginContext(689, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(730, 50, false);
#line 33 "D:\HOC\NĂM 3\CONG NGHE .NET\NET_Nhom69-master\Nhom69MidTermDotNet\Nhom69MidTermDotNet\Views\NhanViens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaPbNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(780, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(821, 52, false);
#line 36 "D:\HOC\NĂM 3\CONG NGHE .NET\NET_Nhom69-master\Nhom69MidTermDotNet\Nhom69MidTermDotNet\Views\NhanViens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaPbNavigation.TenPb));

#line default
#line hidden
            EndContext();
            BeginContext(873, 34, true);
            WriteLiteral("\n        </dd>\n    </dl>\n    \n    ");
            EndContext();
            BeginContext(907, 205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a4991ec0c4e56ca568a9e125a9e55ddb4cdcd7c8649", async() => {
                BeginContext(933, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(942, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a4991ec0c4e56ca568a9e125a9e55ddb4cdcd7c9036", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 41 "D:\HOC\NĂM 3\CONG NGHE .NET\NET_Nhom69-master\Nhom69MidTermDotNet\Nhom69MidTermDotNet\Views\NhanViens\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MaNv);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(980, 82, true);
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\n        ");
                EndContext();
                BeginContext(1062, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a4991ec0c4e56ca568a9e125a9e55ddb4cdcd7c10975", async() => {
                    BeginContext(1084, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1100, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1112, 8, true);
            WriteLiteral("\n</div>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nhom69MidTermDotNet.Models.NhanVien> Html { get; private set; }
    }
}
#pragma warning restore 1591
