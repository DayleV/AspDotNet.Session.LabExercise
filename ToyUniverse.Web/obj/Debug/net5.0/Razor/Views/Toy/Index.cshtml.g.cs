#pragma checksum "C:\Users\dayle.villanda\Documents\Github\pointwest-files\BackEnd\ASP\AspDotNet.Session.LabExercise\ToyUniverse.Web\Views\Toy\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cdbc3c088d6b68437a9af6794abcca322f5718d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Toy_Index), @"mvc.1.0.view", @"/Views/Toy/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\dayle.villanda\Documents\Github\pointwest-files\BackEnd\ASP\AspDotNet.Session.LabExercise\ToyUniverse.Web\Views\_ViewImports.cshtml"
using ToyUniverse.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\dayle.villanda\Documents\Github\pointwest-files\BackEnd\ASP\AspDotNet.Session.LabExercise\ToyUniverse.Web\Views\Toy\Index.cshtml"
using ToyUniverse.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dayle.villanda\Documents\Github\pointwest-files\BackEnd\ASP\AspDotNet.Session.LabExercise\ToyUniverse.Web\Views\Toy\Index.cshtml"
using ToyUniverse.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cdbc3c088d6b68437a9af6794abcca322f5718d", @"/Views/Toy/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1b1e31b24f28935361ed922497aa6d8729ff9f1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Toy_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedResult<Toy>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Toy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h4>Toys</h4>\r\n");
            WriteLiteral("<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cdbc3c088d6b68437a9af6794abcca322f5718d4656", async() => {
                WriteLiteral(@"
    <table class=""table table-striped"">
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">Description</th>
            <th scope=""col"">Rate</th>
            <th scope=""col"">Quantity</th>
            <th scope=""col""></th>
        </tr>
");
#nullable restore
#line 20 "C:\Users\dayle.villanda\Documents\Github\pointwest-files\BackEnd\ASP\AspDotNet.Session.LabExercise\ToyUniverse.Web\Views\Toy\Index.cshtml"
         foreach (var toy in Model.Results)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td scope=\"row\">");
#nullable restore
#line 23 "C:\Users\dayle.villanda\Documents\Github\pointwest-files\BackEnd\ASP\AspDotNet.Session.LabExercise\ToyUniverse.Web\Views\Toy\Index.cshtml"
                           Write(toy.CToyId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\dayle.villanda\Documents\Github\pointwest-files\BackEnd\ASP\AspDotNet.Session.LabExercise\ToyUniverse.Web\Views\Toy\Index.cshtml"
               Write(toy.VToyName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\dayle.villanda\Documents\Github\pointwest-files\BackEnd\ASP\AspDotNet.Session.LabExercise\ToyUniverse.Web\Views\Toy\Index.cshtml"
               Write(toy.VToyDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\dayle.villanda\Documents\Github\pointwest-files\BackEnd\ASP\AspDotNet.Session.LabExercise\ToyUniverse.Web\Views\Toy\Index.cshtml"
               Write(toy.MToyRate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\dayle.villanda\Documents\Github\pointwest-files\BackEnd\ASP\AspDotNet.Session.LabExercise\ToyUniverse.Web\Views\Toy\Index.cshtml"
               Write(toy.SiToyQoh);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td align=\"center\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 988, "\"", 1047, 1);
#nullable restore
#line 29 "C:\Users\dayle.villanda\Documents\Github\pointwest-files\BackEnd\ASP\AspDotNet.Session.LabExercise\ToyUniverse.Web\Views\Toy\Index.cshtml"
WriteAttributeValue("", 995, Url.Action("Add", "Cart", new { id = @toy.CToyId }), 995, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Add To Cart</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\dayle.villanda\Documents\Github\pointwest-files\BackEnd\ASP\AspDotNet.Session.LabExercise\ToyUniverse.Web\Views\Toy\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n    <br />\r\n\r\n    <nav aria-label=\"Page navigation example\">\r\n        <ul class=\"pagination\">\r\n");
#nullable restore
#line 38 "C:\Users\dayle.villanda\Documents\Github\pointwest-files\BackEnd\ASP\AspDotNet.Session.LabExercise\ToyUniverse.Web\Views\Toy\Index.cshtml"
             for (int pageIndex = 1; pageIndex <= Model.PageCount; pageIndex++)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\dayle.villanda\Documents\Github\pointwest-files\BackEnd\ASP\AspDotNet.Session.LabExercise\ToyUniverse.Web\Views\Toy\Index.cshtml"
                 if (pageIndex != Model.CurrentPage)
                {


#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li class=\"page-item\"><a class=\"page-link\"");
                BeginWriteAttribute("href", " href=\"", 1463, "\"", 1504, 3);
                WriteAttributeValue("", 1470, "javascript:pagerClick(", 1470, 22, true);
#nullable restore
#line 44 "C:\Users\dayle.villanda\Documents\Github\pointwest-files\BackEnd\ASP\AspDotNet.Session.LabExercise\ToyUniverse.Web\Views\Toy\Index.cshtml"
WriteAttributeValue("", 1492, pageIndex, 1492, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1502, ");", 1502, 2, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 44 "C:\Users\dayle.villanda\Documents\Github\pointwest-files\BackEnd\ASP\AspDotNet.Session.LabExercise\ToyUniverse.Web\Views\Toy\Index.cshtml"
                                                                                                    Write(pageIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n");
#nullable restore
#line 45 "C:\Users\dayle.villanda\Documents\Github\pointwest-files\BackEnd\ASP\AspDotNet.Session.LabExercise\ToyUniverse.Web\Views\Toy\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li class=\"page-item active\">\r\n                        <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 49 "C:\Users\dayle.villanda\Documents\Github\pointwest-files\BackEnd\ASP\AspDotNet.Session.LabExercise\ToyUniverse.Web\Views\Toy\Index.cshtml"
                                                 Write(pageIndex);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\r\n                    </li>\r\n");
#nullable restore
#line 51 "C:\Users\dayle.villanda\Documents\Github\pointwest-files\BackEnd\ASP\AspDotNet.Session.LabExercise\ToyUniverse.Web\Views\Toy\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\dayle.villanda\Documents\Github\pointwest-files\BackEnd\ASP\AspDotNet.Session.LabExercise\ToyUniverse.Web\Views\Toy\Index.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </ul>\r\n    </nav>\r\n    <input type=\"hidden\" id=\"currentPageIndex\" name=\"currentPageIndex\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    function pagerClick(index) {\r\n        document.getElementById(\"currentPageIndex\").value = index;\r\n        //document.getElementById(\"size\").value = ");
#nullable restore
#line 62 "C:\Users\dayle.villanda\Documents\Github\pointwest-files\BackEnd\ASP\AspDotNet.Session.LabExercise\ToyUniverse.Web\Views\Toy\Index.cshtml"
                                             Write(ViewBag.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        document.forms[0].submit();\r\n    }\r\n</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedResult<Toy>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
