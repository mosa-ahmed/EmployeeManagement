#pragma checksum "C:\Users\NewVision\source\repos\EmployeeManagement\EmployeeManagement\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e27600d611fc1c050829849228b61acaa367075e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "C:\Users\NewVision\source\repos\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NewVision\source\repos\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\NewVision\source\repos\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e27600d611fc1c050829849228b61acaa367075e", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d315e77a174e62a15be0889f42ffcf458007301", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\NewVision\source\repos\EmployeeManagement\EmployeeManagement\Views\Shared\Error.cshtml"
 if(ViewBag.ErrorTitle == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>\r\n    An error occured while processing your request.The support team is notified and we are working on the fix\r\n</h3>\r\n<h5>Please Contact us on mousa.ahmed.mustafa@gmail.com</h5>\r\n<hr />\r\n");
#nullable restore
#line 8 "C:\Users\NewVision\source\repos\EmployeeManagement\EmployeeManagement\Views\Shared\Error.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"text-danger\">");
#nullable restore
#line 11 "C:\Users\NewVision\source\repos\EmployeeManagement\EmployeeManagement\Views\Shared\Error.cshtml"
                       Write(ViewBag.ErrorTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h6 class=\"text-danger\">");
#nullable restore
#line 12 "C:\Users\NewVision\source\repos\EmployeeManagement\EmployeeManagement\Views\Shared\Error.cshtml"
                       Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 13 "C:\Users\NewVision\source\repos\EmployeeManagement\EmployeeManagement\Views\Shared\Error.cshtml"
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