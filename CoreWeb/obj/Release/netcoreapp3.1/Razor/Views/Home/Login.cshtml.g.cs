#pragma checksum "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c945c4ac9948a9b625c8e32e1abb1fd0d99d7494"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 1 "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\_ViewImports.cshtml"
using CoreWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\_ViewImports.cshtml"
using CoreWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c945c4ac9948a9b625c8e32e1abb1fd0d99d7494", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ccaa0bb7c2237ad0e2193309f82bddc35d0c1ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome Home Login Tesst</h1>\r\n</div>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\Home\Login.cshtml"
 using (Html.BeginForm("Login", "Home", new { ReturnUrl = Context.Request.Query["ReturnUrl"] }, FormMethod.Post, true, new { name = "myForm", autocomplete = "off" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <label>帳號:</label>\r\n        ");
#nullable restore
#line 9 "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\Home\Login.cshtml"
   Write(Html.TextBox("userid"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <label>密碼：</label>");
#nullable restore
#line 12 "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\Home\Login.cshtml"
                     Write(Html.Password("pd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <button type=\"submit\">提交</button>\r\n    </div>\r\n    <div style=\"color:red;\">\r\n        <!--顯示登入失敗訊息 -->\r\n        ");
#nullable restore
#line 19 "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\Home\Login.cshtml"
   Write(ViewBag.errMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 21 "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\Home\Login.cshtml"
}

#line default
#line hidden
#nullable disable
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
