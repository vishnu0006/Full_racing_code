#pragma checksum "C:\dotnet\Race-boat-app\Race-boat-app\Views\User\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "204fae57215fc1a1f77b2dd845df53f19c775323"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Users), @"mvc.1.0.view", @"/Views/User/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Users.cshtml", typeof(AspNetCore.Views_User_Users))]
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
#line 1 "C:\dotnet\Race-boat-app\Race-boat-app\Views\_ViewImports.cshtml"
using Race_boat_app;

#line default
#line hidden
#line 2 "C:\dotnet\Race-boat-app\Race-boat-app\Views\_ViewImports.cshtml"
using Race_boat_app.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"204fae57215fc1a1f77b2dd845df53f19c775323", @"/Views/User/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a56809a1f9df39d83759d45aba42f648b9739617", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/profile.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\dotnet\Race-boat-app\Race-boat-app\Views\User\Users.cshtml"
  
    ViewData["Title"] = "User";
    var users = ViewData.Model;

#line default
#line hidden
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(875, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(1025, 60, true);
            WriteLiteral("\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 45 "C:\dotnet\Race-boat-app\Race-boat-app\Views\User\Users.cshtml"
             foreach (var user in users)
            {

#line default
#line hidden
            BeginContext(1142, 114, true);
            WriteLiteral("                <div class=\"col-sm-4\">\r\n                    <div class=\"card user-card\">\r\n                        ");
            EndContext();
            BeginContext(1256, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "204fae57215fc1a1f77b2dd845df53f19c7753235163", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1330, 129, true);
            WriteLiteral("\r\n                        <div class=\"card-body user-card-body text-center\">\r\n                            <h5 class=\"card-title\">");
            EndContext();
            BeginContext(1460, 14, false);
#line 51 "C:\dotnet\Race-boat-app\Race-boat-app\Views\User\Users.cshtml"
                                              Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1474, 6, true);
            WriteLiteral("&nbsp;");
            EndContext();
            BeginContext(1481, 13, false);
#line 51 "C:\dotnet\Race-boat-app\Race-boat-app\Views\User\Users.cshtml"
                                                                   Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1494, 96, true);
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">\r\n                                <span>");
            EndContext();
            BeginContext(1591, 10, false);
#line 53 "C:\dotnet\Race-boat-app\Race-boat-app\Views\User\Users.cshtml"
                                 Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1601, 59, true);
            WriteLiteral("</span><br />\r\n                                <span>Team: ");
            EndContext();
            BeginContext(1661, 9, false);
#line 54 "C:\dotnet\Race-boat-app\Race-boat-app\Views\User\Users.cshtml"
                                       Write(user.Team);

#line default
#line hidden
            EndContext();
            BeginContext(1670, 60, true);
            WriteLiteral("</span><br />\r\n                                <span>Phone: ");
            EndContext();
            BeginContext(1731, 16, false);
#line 55 "C:\dotnet\Race-boat-app\Race-boat-app\Views\User\Users.cshtml"
                                        Write(user.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1747, 439, true);
            WriteLiteral(@"</span>
                            </p>
                            <div>
                                <a href=""#""><i class=""fab fa-dribbble""></i></a>
                                <a href=""#""><i class=""fab fa-twitter""></i></a>
                                <a href=""#""><i class=""fab fa-linkedin""></i></a>
                                <a href=""#""><i class=""fab fa-facebook""></i></a>
                            </div>

");
            EndContext();
            BeginContext(2283, 150, true);
            WriteLiteral("                        </div>\r\n                        <p style=\"margin:0px;\">\r\n                            <button class=\"user-card-button\">Contact ");
            EndContext();
            BeginContext(2434, 14, false);
#line 67 "C:\dotnet\Race-boat-app\Race-boat-app\Views\User\Users.cshtml"
                                                                Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2448, 93, true);
            WriteLiteral("</button>\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 71 "C:\dotnet\Race-boat-app\Race-boat-app\Views\User\Users.cshtml"
            }

#line default
#line hidden
            BeginContext(2556, 34, true);
            WriteLiteral("            </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591