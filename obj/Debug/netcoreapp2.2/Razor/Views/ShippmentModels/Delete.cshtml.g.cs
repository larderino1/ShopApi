#pragma checksum "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9ebf8e73f66840615715e0690fa93764661284e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShippmentModels_Delete), @"mvc.1.0.view", @"/Views/ShippmentModels/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShippmentModels/Delete.cshtml", typeof(AspNetCore.Views_ShippmentModels_Delete))]
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
#line 1 "D:\Projects_for_work\ShopApi\Views\_ViewImports.cshtml"
using ShopApi;

#line default
#line hidden
#line 2 "D:\Projects_for_work\ShopApi\Views\_ViewImports.cshtml"
using ShopApi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ebf8e73f66840615715e0690fa93764661284e", @"/Views/ShippmentModels/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3d356e1d4170aeb83741d7ac924dbd133e8b80", @"/Views/_ViewImports.cshtml")]
    public class Views_ShippmentModels_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopApi.Models.ShippmentModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(82, 184, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>ShippmentModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(267, 44, false);
#line 15 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(311, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(375, 40, false);
#line 18 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(415, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(478, 47, false);
#line 21 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UserSurname));

#line default
#line hidden
            EndContext();
            BeginContext(525, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(589, 43, false);
#line 24 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UserSurname));

#line default
#line hidden
            EndContext();
            BeginContext(632, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(695, 45, false);
#line 27 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UserEmail));

#line default
#line hidden
            EndContext();
            BeginContext(740, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(804, 41, false);
#line 30 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UserEmail));

#line default
#line hidden
            EndContext();
            BeginContext(845, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(908, 45, false);
#line 33 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UserPhone));

#line default
#line hidden
            EndContext();
            BeginContext(953, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1017, 41, false);
#line 36 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UserPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1121, 40, false);
#line 39 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1161, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1225, 36, false);
#line 42 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1261, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1324, 51, false);
#line 45 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ShippmentAdress));

#line default
#line hidden
            EndContext();
            BeginContext(1375, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1439, 47, false);
#line 48 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ShippmentAdress));

#line default
#line hidden
            EndContext();
            BeginContext(1486, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1549, 56, false);
#line 51 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ShippmentDestination));

#line default
#line hidden
            EndContext();
            BeginContext(1605, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1669, 52, false);
#line 54 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ShippmentDestination));

#line default
#line hidden
            EndContext();
            BeginContext(1721, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1784, 52, false);
#line 57 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PostOfficeNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1836, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1900, 48, false);
#line 60 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PostOfficeNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1948, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2011, 52, false);
#line 63 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PostOfficeAdress));

#line default
#line hidden
            EndContext();
            BeginContext(2063, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2127, 48, false);
#line 66 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PostOfficeAdress));

#line default
#line hidden
            EndContext();
            BeginContext(2175, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2238, 50, false);
#line 69 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ShippmentPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2288, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2352, 46, false);
#line 72 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ShippmentPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2398, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2461, 40, false);
#line 75 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Shop));

#line default
#line hidden
            EndContext();
            BeginContext(2501, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2565, 48, false);
#line 78 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Shop.ShopCountry));

#line default
#line hidden
            EndContext();
            BeginContext(2613, 44, true);
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2657, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9ebf8e73f66840615715e0690fa93764661284e14019", async() => {
                BeginContext(2683, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2693, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9ebf8e73f66840615715e0690fa93764661284e14412", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 83 "D:\Projects_for_work\ShopApi\Views\ShippmentModels\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ShippmentId);

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
                BeginContext(2738, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2821, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9ebf8e73f66840615715e0690fa93764661284e16312", async() => {
                    BeginContext(2843, 12, true);
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
                BeginContext(2859, 6, true);
                WriteLiteral("\r\n    ");
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
            BeginContext(2872, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopApi.Models.ShippmentModel> Html { get; private set; }
    }
}
#pragma warning restore 1591