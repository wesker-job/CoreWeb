#pragma checksum "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\Home\AjaxTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "989e8f3f111e93f2e3fd51ec213c0da4f35e2f0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AjaxTest), @"mvc.1.0.view", @"/Views/Home/AjaxTest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"989e8f3f111e93f2e3fd51ec213c0da4f35e2f0d", @"/Views/Home/AjaxTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ccaa0bb7c2237ad0e2193309f82bddc35d0c1ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AjaxTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\Home\AjaxTest.cshtml"
  
    ViewData["Title"] = "AjaxTest";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\Home\AjaxTest.cshtml"
 using (Html.BeginForm("", "", null, FormMethod.Post, true, new { name = "myForm" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button id=\"btnGo\" type=\"button\">click me to call ajax method</button>\r\n");
#nullable restore
#line 9 "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\Home\AjaxTest.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"result\"></div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n    let AjaxUrl = \"");
#nullable restore
#line 15 "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\Home\AjaxTest.cshtml"
              Write(Url.Action("PostData","Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n\r\n    $(document).ready(function () {\r\n        $.ajaxSetup({\r\n            statusCode: {\r\n                401: function () {\r\n                    window.location.href = \"");
#nullable restore
#line 21 "C:\Users\acer\source\repos\CoreWeb\CoreWeb\Views\Home\AjaxTest.cshtml"
                                       Write(Url.Action("Login","Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?ReturnUrl="" + encodeURIComponent(window.location.href)
                }
            }
        });

        $(""#btnGo"").on(""click"", function () {
            console.log(""hello"");
            $.ajax({
                url: AjaxUrl,
                headers: { RequestVerificationToken: $(""input[name='__RequestVerificationToken'"").val() },
                method: ""post"",
                success: function (result) {
                    console.log(""success"");
                    $(""#result"").html(result);
                }
            });
        });
    });

    </script>
");
            }
            );
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
