#pragma checksum "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Chat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0bc1c56b76be4248eff8c9a4cdc5caa83fb19c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_Index), @"mvc.1.0.view", @"/Views/Chat/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chat/Index.cshtml", typeof(AspNetCore.Views_Chat_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0bc1c56b76be4248eff8c9a4cdc5caa83fb19c2", @"/Views/Chat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b303f695a79eb6d1dfd699c250715c9df1ce1a57", @"/Views/_ViewImports.cshtml")]
    public class Views_Chat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Chat\Index.cshtml"
  
    ViewData["Title"] = "Chats";
    Layout = "~/Views/Shared/_LayoutJari.cshtml";

#line default
#line hidden
            BeginContext(92, 31, true);
            WriteLiteral("\r\n    <div class=\"container\">\r\n");
            EndContext();
#line 7 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Chat\Index.cshtml"
         if (ViewBag.success != null)
        {

#line default
#line hidden
            BeginContext(173, 76, true);
            WriteLiteral("            <div class=\"alert alert-success\" role=\"alert\">\r\n                ");
            EndContext();
            BeginContext(250, 15, false);
#line 10 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Chat\Index.cshtml"
           Write(ViewBag.success);

#line default
#line hidden
            EndContext();
            BeginContext(265, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 12 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Chat\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(298, 179, true);
            WriteLiteral("\r\n        <h1 class=\"page-title\">Chatrooms</h1>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                <h2>Deelnemen nieuwe chatroom</h2>\r\n                ");
            EndContext();
            BeginContext(477, 728, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0bc1c56b76be4248eff8c9a4cdc5caa83fb19c25161", async() => {
                BeginContext(497, 249, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"type\" value=\"join\" />\r\n\r\n                    <div class=\"form-group\">\r\n                        <label for=\"join\"></label>\r\n                        <select name=\"chat\" class=\"form-control\" id=\"join\">\r\n");
                EndContext();
#line 25 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Chat\Index.cshtml"
                             foreach (var chat in ViewBag.chatsJoinable)
                            {

#line default
#line hidden
                BeginContext(851, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(883, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0bc1c56b76be4248eff8c9a4cdc5caa83fb19c26193", async() => {
                    BeginContext(913, 9, false);
#line 27 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Chat\Index.cshtml"
                                                        Write(chat.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 27 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Chat\Index.cshtml"
                                   WriteLiteral(chat.ChatId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(931, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 28 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Chat\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(964, 130, true);
                WriteLiteral("                        </select>\r\n                    </div>\r\n\r\n                    <button class=\"btn btn-primary\" type=\"submit\"");
                EndContext();
                BeginWriteAttribute("disabled", " disabled=\"", 1094, "\"", 1160, 1);
#line 32 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Chat\Index.cshtml"
WriteAttributeValue("", 1105, ViewBag.chatsJoinable.Count == 0 ? "disabled" : null, 1105, 55, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1161, 37, true);
                WriteLiteral(">Deelnemen</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1205, 87, true);
            WriteLiteral("\r\n\r\n                <hr />\r\n\r\n                <h2>Mijn chatrooms</h2>\r\n                ");
            EndContext();
            BeginContext(1292, 724, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0bc1c56b76be4248eff8c9a4cdc5caa83fb19c210530", async() => {
                BeginContext(1312, 249, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"type\" value=\"open\" />\r\n\r\n                    <div class=\"form-group\">\r\n                        <label for=\"open\"></label>\r\n                        <select name=\"chat\" class=\"form-control\" id=\"open\">\r\n");
                EndContext();
#line 44 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Chat\Index.cshtml"
                             foreach (var chat in ViewBag.chatsJoined)
                            {

#line default
#line hidden
                BeginContext(1664, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1696, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0bc1c56b76be4248eff8c9a4cdc5caa83fb19c211564", async() => {
                    BeginContext(1726, 9, false);
#line 46 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Chat\Index.cshtml"
                                                        Write(chat.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 46 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Chat\Index.cshtml"
                                   WriteLiteral(chat.ChatId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1744, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 47 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Chat\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(1777, 128, true);
                WriteLiteral("                        </select>\r\n                    </div>\r\n                    <button class=\"btn btn-primary\" type=\"submit\"");
                EndContext();
                BeginWriteAttribute("disabled", " disabled=\"", 1905, "\"", 1969, 1);
#line 50 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Chat\Index.cshtml"
WriteAttributeValue("", 1916, ViewBag.chatsJoined.Count == 0 ? "disabled" : null, 1916, 53, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1970, 39, true);
                WriteLiteral(">Chat openen</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2016, 108, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-6\">\r\n                <h2>Vrienden</h2>\r\n                ");
            EndContext();
            BeginContext(2124, 747, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0bc1c56b76be4248eff8c9a4cdc5caa83fb19c215925", async() => {
                BeginContext(2144, 251, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"type\" value=\"chat\" />\r\n\r\n                    <div class=\"form-group\">\r\n                        <label for=\"join\"></label>\r\n                        <select name=\"chat\" class=\"form-control\" id=\"friend\">\r\n");
                EndContext();
#line 62 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Chat\Index.cshtml"
                             foreach (var Person in ViewBag.friends)
                            {

#line default
#line hidden
                BeginContext(2496, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(2528, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0bc1c56b76be4248eff8c9a4cdc5caa83fb19c216959", async() => {
                    BeginContext(2559, 16, false);
#line 64 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Chat\Index.cshtml"
                                                         Write(Person.FirstName);

#line default
#line hidden
                    EndContext();
                    BeginContext(2575, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(2577, 15, false);
#line 64 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Chat\Index.cshtml"
                                                                           Write(Person.LastName);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 64 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Chat\Index.cshtml"
                                   WriteLiteral(Person.Email);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2601, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 65 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Chat\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(2634, 130, true);
                WriteLiteral("                        </select>\r\n                    </div>\r\n\r\n                    <button class=\"btn btn-primary\" type=\"submit\"");
                EndContext();
                BeginWriteAttribute("disabled", " disabled=\"", 2764, "\"", 2824, 1);
#line 69 "C:\Users\Jari\Dropbox\Development\Asp.net\Meldboek\meldboek\Views\Chat\Index.cshtml"
WriteAttributeValue("", 2775, ViewBag.friends.Count == 0 ? "disabled" : null, 2775, 49, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2825, 39, true);
                WriteLiteral(">Chat openen</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2871, 50, true);
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n    </div>");
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
