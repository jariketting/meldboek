#pragma checksum "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Person\CreateAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f682204d4fcd74e76c93aa9c1bb11fa791d9dd3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_CreateAccount), @"mvc.1.0.view", @"/Views/Person/CreateAccount.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person/CreateAccount.cshtml", typeof(AspNetCore.Views_Person_CreateAccount))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f682204d4fcd74e76c93aa9c1bb11fa791d9dd3c", @"/Views/Person/CreateAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b303f695a79eb6d1dfd699c250715c9df1ce1a57", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_CreateAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<meldboek.Models.Person>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Topbar_Sidenav.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateAccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Person\CreateAccount.cshtml"
  
    ViewData["Title"] = "Account aanmaken";

#line default
#line hidden
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(85, 29, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n    ");
            EndContext();
            BeginContext(114, 2524, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f682204d4fcd74e76c93aa9c1bb11fa791d9dd3c5834", async() => {
                BeginContext(120, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(130, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f682204d4fcd74e76c93aa9c1bb11fa791d9dd3c6224", async() => {
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
                BeginContext(201, 2430, true);
                WriteLiteral(@"
        <style>
            body {
                font-family: 'Trebuchet MS', sans-serif;
            }

            .topbar {
                background-color: #ea9999;
            }

            .navbtn {
                background-color: #ea9999;
            }

            .overlay {
                background-color: #ea9999;
            }

            .overlay a:hover, .overlay a:focus, .logout a:hover, .logout a:focus {
                color: #f2c0c0;
            }

            .box {
                background: #ea9999;
                height: 300px;
                border-radius: 6px;
                padding: 50px 0px 40px 50px;
            }

            .box h1 {
                color: #ffffff;
                font-size: 22px;
            }

            label {
                font-size: 20px;
                color: white;
            }

            input {
                font-family: 'Trebuchet MS', sans-serif;
                font-size: 20px;
          ");
                WriteLiteral(@"  }

            .button {
                background-color: #ffffff;
                width: 275px;
                padding: 10px 20px 10px 20px;
                color: #000000;
                border-radius: 25px;
                border: none;
                font-size: 22px;
                cursor: pointer;
                transition: 0.2s;
            }

            .button:hover {
                background-color: #f2c0c0;
            }

            #absoluteCenteredDiv {
                position: absolute;
                top: 0;
                bottom: 0;
                left: 0;
                right: 0;
                width: 800px;
                height: 375px;
                text-align: left;
                margin: 200px auto 0px auto;
            }

            .row {
                width: 100%;
                margin: 0px 0px 20px 0px;
            }

            .column {
                float: left;
                margin: 0px 20px 0px 0px;
            }");
                WriteLiteral(@"

            #personlist {
                padding: 100px 0 0 20px;
            }

            #personlist a {
                text-decoration: none;
                color: #0000ff;
                font-size: 22px;
                transition: 0.2s;
            }

            #personlist a:hover {
                color: #b3b3ff;
            }
        </style>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2638, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(2644, 3246, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f682204d4fcd74e76c93aa9c1bb11fa791d9dd3c10949", async() => {
                BeginContext(2650, 368, true);
                WriteLiteral(@"
        <!-- Colored bar at the top of the page -->
        <div class=""topbar"">
            <!-- The button that opens the sidemenu -->
            <span class=""navbtn"" onclick=""nav()"">&#9776; </span>

            <!-- Page titles -->
            <h1 style=""width: 59%;"">Account aanmaken</h1>

            <!-- Account information button -->
            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3018, "\"", 3047, 1);
#line 117 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Person\CreateAccount.cshtml"
WriteAttributeValue("", 3025, Url.Action("Profile"), 3025, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3048, 19, true);
                WriteLiteral("><img id=\"acc-icon\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3067, "\"", 3110, 1);
#line 117 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Person\CreateAccount.cshtml"
WriteAttributeValue("", 3073, Url.Content("~/Content/account.png"), 3073, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3111, 163, true);
                WriteLiteral(" /></a>\r\n        </div>\r\n\r\n        <!-- Sidemenu overlay -->\r\n        <div id=\"nav\" class=\"overlay\">\r\n            <div class=\"overlay-content\">\r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3274, "\"", 3304, 1);
#line 123 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Person\CreateAccount.cshtml"
WriteAttributeValue("", 3281, Url.Action("Newsfeed"), 3281, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3305, 53, true);
                WriteLiteral(">Nieuws</a>\r\n                <br>\r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3358, "\"", 3397, 1);
#line 125 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Person\CreateAccount.cshtml"
WriteAttributeValue("", 3365, Url.Action("ForumHome","Forum"), 3365, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3398, 53, true);
                WriteLiteral(">Forums</a>\r\n                <br>\r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3451, "\"", 3486, 1);
#line 127 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Person\CreateAccount.cshtml"
WriteAttributeValue("", 3458, Url.Action("Index", "Chat"), 3458, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3487, 51, true);
                WriteLiteral(">Chat</a>\r\n                <br>\r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3538, "\"", 3567, 1);
#line 129 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Person\CreateAccount.cshtml"
WriteAttributeValue("", 3545, Url.Action("Groepen"), 3545, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3568, 54, true);
                WriteLiteral(">Groepen</a>\r\n                <br>\r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3622, "\"", 3654, 1);
#line 131 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Person\CreateAccount.cshtml"
WriteAttributeValue("", 3629, Url.Action("Personlist"), 3629, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3655, 71, true);
                WriteLiteral(">Gebruikers</a>\r\n            </div>\r\n            <div class=\"logout\"><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3726, "\"", 3754, 1);
#line 133 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Person\CreateAccount.cshtml"
WriteAttributeValue("", 3733, Url.Action("Logout"), 3733, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3755, 124, true);
                WriteLiteral(">Log uit</a></div>\r\n        </div>\r\n        \r\n        <!-- Link back to personlist page -->\r\n        <div id=\"personlist\"><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3879, "\"", 3911, 1);
#line 137 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Person\CreateAccount.cshtml"
WriteAttributeValue("", 3886, Url.Action("Personlist"), 3886, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3912, 201, true);
                WriteLiteral(">&#8592; Terug naar gebruikers</a></div>\r\n       \r\n        <!-- Actual content of the page -->\r\n        <div id=\"absoluteCenteredDiv\">\r\n\r\n            <!-- Form to create a new account -->\r\n            ");
                EndContext();
                BeginContext(4113, 1748, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f682204d4fcd74e76c93aa9c1bb11fa791d9dd3c16563", async() => {
                    BeginContext(4160, 1694, true);
                    WriteLiteral(@"
                <div class=""box"">
                    <div class=""row"">
                        <div class=""column"">
                            <h1>Voornaam</h1>
                            <input type=""string"" required name=firstname id=""firstname"" size=""20"">
                        </div>
                        <div class=""column"">
                            <h1>Achternaam</h1>
                            <input type=""string"" required name=lastname id=""lastname"" size=""40"">
                        </div>
                    </div>
                    <div class=""row"" style=""padding-top: 50px;"">
                        <h1>Emailadres</h1>
                        <input type=""string"" required name=email id=""email"" size=""40"">
                    </div>
                    <div class=""row"">
                        <div class=""column"">
                            <h1>Wachtwoord</h1>
                            <input type=""password"" required name=password id=""password"" size=""30"">
         ");
                    WriteLiteral(@"               </div>
                        <div class=""column"">
                            <h1>Wachtwoord herhalen</h1>
                            <input type=""password"" required name=password2 id=""password2"" size=""30"">
                        </div>
                    </div>
                    <div class=""row"" style=""padding-top: 70px;"">
                        <input type=""checkbox"" id=""ismanager"" name=""ismanager"" value=""true"">
                        <label for=""manager"">Manager</label>
                    </div>
                    <input type=""submit"" class=""button"" value=""Account aanmaken"" id=""submit"">
                </div>
            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5861, 22, true);
                WriteLiteral("\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5890, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<meldboek.Models.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
