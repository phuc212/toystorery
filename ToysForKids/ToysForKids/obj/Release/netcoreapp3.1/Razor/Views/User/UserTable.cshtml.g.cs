#pragma checksum "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\User\UserTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bcc1ad258c1699cee21f8630e3b5b77d404af0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserTable), @"mvc.1.0.view", @"/Views/User/UserTable.cshtml")]
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
#line 1 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\_ViewImports.cshtml"
using ToysForKids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\_ViewImports.cshtml"
using ToysForKids.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\_ViewImports.cshtml"
using ToysForKids.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\_ViewImports.cshtml"
using ToysForKids.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\_ViewImports.cshtml"
using ToysForKids.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\_ViewImports.cshtml"
using ToysForKids.DbContexts;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bcc1ad258c1699cee21f8630e3b5b77d404af0c", @"/Views/User/UserTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f07495ba8269e4a7562af15dfe8d2a2503e0bca1", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToysForKids.Models.ViewModels.UserViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\User\UserTable.cshtml"
  
    ViewBag.Title = "Users Managerment";
    Layout = "_DashBoardLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bcc1ad258c1699cee21f8630e3b5b77d404af0c5238", async() => {
                WriteLiteral("\r\n    <i class=\"fas fa-user-plus\" style=\"font-size:200%\"></i>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<table class=\"table table-bordered table-responsive-lg display\" id=\"users\">\r\n    <thead>\r\n        <tr class=\"thead-dark\">\r\n            <th>\r\n                ");
#nullable restore
#line 14 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\User\UserTable.cshtml"
           Write(Html.DisplayNameFor(model => model.Fullname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\User\UserTable.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\User\UserTable.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\User\UserTable.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\User\UserTable.cshtml"
           Write(Html.DisplayNameFor(model => model.RoleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Action\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\User\UserTable.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\User\UserTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.Fullname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\User\UserTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\User\UserTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\User\UserTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\User\UserTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.RoleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bcc1ad258c1699cee21f8630e3b5b77d404af0c10472", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-id-card\" style=\"font-size:150%\"></i>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\User\UserTable.cshtml"
                                                                    WriteLiteral(item.UserId);

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
            WriteLiteral("\r\n                    <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1868, "\"", 1904, 3);
            WriteAttributeValue("", 1878, "removeUser(\'", 1878, 12, true);
#nullable restore
#line 56 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\User\UserTable.cshtml"
WriteAttributeValue("", 1890, item.UserId, 1890, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1902, "\')", 1902, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fas fa-user-times\" style=\"font-size:150%;color:red;\"></i>\r\n                    </a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 61 "D:\codegym\CaseStudyModule3\ToysForKids\ToysForKids\Views\User\UserTable.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
   
    <script>
        function removeUser(UserId) {
            bootbox.confirm({
                title: ""Remove role?"",
                message: ""Do you really want to remove this user"",
                buttons: {
                    cancel: {
                        label: '<i class=""fa fa-times""></i> No'
                    },
                    confirm: {
                        label: '<i class=""fa fa-check""></i> Yes'
                    }
                },
                callback: function (result) {
                    if (result) {
                        $.ajax({
                            type: ""GET"",
                            url: `/User/DeleteUser/${UserId}`,
                            success: function (result) {
                                bootbox.alert(""Successed!"", function () {
                                    window.location.href = ""/User/UserTable"";
                                });
                            }
                        });
     ");
                WriteLiteral("               }\r\n                }\r\n            });\r\n        }\r\n        $(document).ready(function () {\r\n            $(\'#users\').DataTable();\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ToysForKids.Models.ViewModels.UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591