#pragma checksum "D:\CodeGym\module3\case_study_tham\ToysForKids\ToysForKids\ToysForKids\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbc688a3001be678c8df8cd573445d63fc8b7cb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "D:\CodeGym\module3\case_study_tham\ToysForKids\ToysForKids\ToysForKids\Views\_ViewImports.cshtml"
using ToysForKids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CodeGym\module3\case_study_tham\ToysForKids\ToysForKids\ToysForKids\Views\_ViewImports.cshtml"
using ToysForKids.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CodeGym\module3\case_study_tham\ToysForKids\ToysForKids\ToysForKids\Views\_ViewImports.cshtml"
using ToysForKids.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CodeGym\module3\case_study_tham\ToysForKids\ToysForKids\ToysForKids\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CodeGym\module3\case_study_tham\ToysForKids\ToysForKids\ToysForKids\Views\_ViewImports.cshtml"
using ToysForKids.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CodeGym\module3\case_study_tham\ToysForKids\ToysForKids\ToysForKids\Views\_ViewImports.cshtml"
using ToysForKids.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CodeGym\module3\case_study_tham\ToysForKids\ToysForKids\ToysForKids\Views\_ViewImports.cshtml"
using ToysForKids.DbContexts;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbc688a3001be678c8df8cd573445d63fc8b7cb4", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f07495ba8269e4a7562af15dfe8d2a2503e0bca1", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToysForKids.Models.ViewModels.ProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\CodeGym\module3\case_study_tham\ToysForKids\ToysForKids\ToysForKids\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "All Products";
    Layout = "_DashBoardLayout";
    var categories = context.Categories.ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<table id=\"products\" class=\"table table-bordered table-responsive-lg display\">\r\n    <thead>\r\n        <tr>\r\n            <th>ID</th>\r\n            <th class=\"no-sort\">\r\n                ");
#nullable restore
#line 16 "D:\CodeGym\module3\case_study_tham\ToysForKids\ToysForKids\ToysForKids\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Price\r\n            </th>\r\n            <th>\r\n                Stock\r\n            </th>\r\n            <th class=\"no-sort\">\r\n                ");
#nullable restore
#line 25 "D:\CodeGym\module3\case_study_tham\ToysForKids\ToysForKids\ToysForKids\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"no-sort\">\r\n                Action\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 33 "D:\CodeGym\module3\case_study_tham\ToysForKids\ToysForKids\ToysForKids\Views\Product\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "D:\CodeGym\module3\case_study_tham\ToysForKids\ToysForKids\ToysForKids\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "D:\CodeGym\module3\case_study_tham\ToysForKids\ToysForKids\ToysForKids\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "D:\CodeGym\module3\case_study_tham\ToysForKids\ToysForKids\ToysForKids\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "D:\CodeGym\module3\case_study_tham\ToysForKids\ToysForKids\ToysForKids\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 49 "D:\CodeGym\module3\case_study_tham\ToysForKids\ToysForKids\ToysForKids\Views\Product\Index.cshtml"
                     foreach (var category in categories)
                    {
                        if (item.CategoryId == category.CategoryId)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>");
#nullable restore
#line 53 "D:\CodeGym\module3\case_study_tham\ToysForKids\ToysForKids\ToysForKids\Views\Product\Index.cshtml"
                            Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 54 "D:\CodeGym\module3\case_study_tham\ToysForKids\ToysForKids\ToysForKids\Views\Product\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbc688a3001be678c8df8cd573445d63fc8b7cb49039", async() => {
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "D:\CodeGym\module3\case_study_tham\ToysForKids\ToysForKids\ToysForKids\Views\Product\Index.cshtml"
                                                                    WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("                  \r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 61 "D:\CodeGym\module3\case_study_tham\ToysForKids\ToysForKids\ToysForKids\Views\Product\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#products').DataTable(
                {
                    ""columnDefs"": [{
                        ""targets"": 'no-sort',
                        ""orderable"": false,
                        ""order"": []
                    }]
                });
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public AppDbContext context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ToysForKids.Models.ViewModels.ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
