#pragma checksum "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Person\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1ff710962b0836dc6264356adca08f305f7c670"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Profile), @"mvc.1.0.view", @"/Views/Person/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person/Profile.cshtml", typeof(AspNetCore.Views_Person_Profile))]
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
#line 1 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\_ViewImports.cshtml"
using meldboek;

#line default
#line hidden
#line 2 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\_ViewImports.cshtml"
using meldboek.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1ff710962b0836dc6264356adca08f305f7c670", @"/Views/Person/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b303f695a79eb6d1dfd699c250715c9df1ce1a57", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<meldboek.ViewModels.Profile>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 35, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n            <h2>");
            EndContext();
            BeginContext(72, 10, false);
#line 4 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Person\Profile.cshtml"
           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(82, 22, true);
            WriteLiteral("</h2>\r\n            <p>");
            EndContext();
            BeginContext(105, 11, false);
#line 5 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Person\Profile.cshtml"
          Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(116, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
            BeginContext(257, 32, true);
            WriteLiteral("            <h1>Profile</h1>\r\n\r\n");
            EndContext();
            BeginContext(303, 11, true);
            WriteLiteral("\r\n       \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<meldboek.ViewModels.Profile> Html { get; private set; }
    }
}
#pragma warning restore 1591
