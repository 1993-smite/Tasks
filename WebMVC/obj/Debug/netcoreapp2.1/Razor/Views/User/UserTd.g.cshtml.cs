#pragma checksum "C:\Users\Касса\source\repos\TestWebCore\WebMVC\Views\User\UserTd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d792cc113fec1a145aaceef92f20c929cc7f975"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserTd), @"mvc.1.0.view", @"/Views/User/UserTd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/UserTd.cshtml", typeof(AspNetCore.Views_User_UserTd))]
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
#line 1 "C:\Users\Касса\source\repos\TestWebCore\WebMVC\Views\_ViewImports.cshtml"
using WebMVC;

#line default
#line hidden
#line 2 "C:\Users\Касса\source\repos\TestWebCore\WebMVC\Views\_ViewImports.cshtml"
using WebMVC.Models;

#line default
#line hidden
#line 1 "C:\Users\Касса\source\repos\TestWebCore\WebMVC\Views\User\UserTd.cshtml"
using WebCoreMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d792cc113fec1a145aaceef92f20c929cc7f975", @"/Views/User/UserTd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d07e873f05b36c9d83cd6a184d4bfbe1720fee4b", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserTd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 6, true);
            WriteLiteral("\r\n<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 46, "\"", 76, 4);
            WriteAttributeValue("", 54, "tr", 54, 2, true);
            WriteAttributeValue(" ", 56, "user", 57, 5, true);
            WriteAttributeValue(" ", 61, "user-", 62, 6, true);
#line 4 "C:\Users\Касса\source\repos\TestWebCore\WebMVC\Views\User\UserTd.cshtml"
WriteAttributeValue("", 67, Model.Id, 67, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(77, 10, true);
            WriteLiteral(" data-id=\"");
            EndContext();
            BeginContext(88, 8, false);
#line 4 "C:\Users\Касса\source\repos\TestWebCore\WebMVC\Views\User\UserTd.cshtml"
                                        Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(96, 24, true);
            WriteLiteral("\">\r\n    <div class=\"td\">");
            EndContext();
            BeginContext(121, 10, false);
#line 5 "C:\Users\Касса\source\repos\TestWebCore\WebMVC\Views\User\UserTd.cshtml"
               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(131, 28, true);
            WriteLiteral("</div>\r\n    <div class=\"td\">");
            EndContext();
            BeginContext(160, 16, false);
#line 6 "C:\Users\Касса\source\repos\TestWebCore\WebMVC\Views\User\UserTd.cshtml"
               Write(Model.Department);

#line default
#line hidden
            EndContext();
            BeginContext(176, 28, true);
            WriteLiteral("</div>\r\n    <div class=\"td\">");
            EndContext();
            BeginContext(205, 10, false);
#line 7 "C:\Users\Касса\source\repos\TestWebCore\WebMVC\Views\User\UserTd.cshtml"
               Write(Model.Role);

#line default
#line hidden
            EndContext();
            BeginContext(215, 123, true);
            WriteLiteral("</div>\r\n    <div class=\"td\"><input type=\"button\" class=\"btn white right user-fire-action\" value=\"Уволить\"/></div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
