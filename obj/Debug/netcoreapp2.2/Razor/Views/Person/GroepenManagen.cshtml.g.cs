#pragma checksum "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5c30de665394a3d0005bf50bf462451a4297e8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_GroepenManagen), @"mvc.1.0.view", @"/Views/Person/GroepenManagen.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person/GroepenManagen.cshtml", typeof(AspNetCore.Views_Person_GroepenManagen))]
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
#line 1 "C:\Users\amyno\Documents\Repos\meldboek\Views\_ViewImports.cshtml"
using meldboek;

#line default
#line hidden
#line 2 "C:\Users\amyno\Documents\Repos\meldboek\Views\_ViewImports.cshtml"
using meldboek.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5c30de665394a3d0005bf50bf462451a4297e8c", @"/Views/Person/GroepenManagen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b303f695a79eb6d1dfd699c250715c9df1ce1a57", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_GroepenManagen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Topbar_Sidenav.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddPersonToGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePersonFromGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
  
    ViewData["Title"] = "Groepen beheren";

#line default
#line hidden
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(69, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(96, 3437, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c30de665394a3d0005bf50bf462451a4297e8c6196", async() => {
                BeginContext(102, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(108, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c5c30de665394a3d0005bf50bf462451a4297e8c6581", async() => {
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
                BeginContext(179, 3347, true);
                WriteLiteral(@"
    <style>
        #create-groups {
            padding: 10px;
            text-decoration: none;
            color: #0000ff;
            font-size: 22px;
            transition: 0.2s;
        }

        #create-groups:hover {
            color: #b3b3ff;
        }

        #Add-Delete-PersonToGroup {
            /* width: 320px; */
            padding: 15px;
            border: 2px solid #ffed00;
            margin: 50px 0px 40px 0px;
        }

        body {
            font-family: ""Trebuchet MS"", ""Lucida Sans Unicode"", ""Lucida Grande"",
            ""Lucida Sans"", Arial, sans-serif;
        }

        .group-options a {
            font-size: 18px;
            font-family: ""Trebuchet MS"", sans-serif;
        }

        input[type=""submit""] {
            font-family: ""Trebuchet MS"", sans-serif;
            background-color: #ffed00;
            color: white;
            font-size: 18px;
            border-radius: 25px;
            padding: 10px 15px;
            border");
                WriteLiteral(@": none;
            cursor: pointer;
            transition: 0.2s;
        }

        input[type=""submit""]:hover {
            background-color: #fff9a6;
        }

        .topbar {
            background-color: #ffed00;
        }

        .navbtn {
            background-color: #ffed00;
        }

        .overlay {
            background-color: #ffed00; 
        }

        .overlay a:hover, .overlay a:focus, .logout a:hover, .logout a:focus {
            color: #fff9a6;
        }

        .content {
            padding-top: 100px;
            width: 90%;
        }

        .groups {
            position: fixed;
            float: left;
            width: 180px;
            height: 550px;
            padding: 80px 30px 0px 40px;
            border-right: 2px solid #ffed00;
            overflow-y: auto;
        }

        .groups a {
            color: #000000;
            font-size: 24px;
            text-decoration: none;
            display: block;
            ");
                WriteLiteral(@"padding-bottom: 15px;
            transition: 0.2s;
            word-wrap: break-word;
        }

        .groups a:hover {
            color: #fff9a6;
        }

        .group-options {
            padding-top: 40px;
            margin-left: 350px;
        }

        select {
            font-family: 'Trebuchet MS', sans-serif;
            font-size: 18px;
            margin: 15px 0px 20px 0px;
            padding: 5px;
        }

        option {
            font-family: 'Trebuchet MS', sans-serif;
            font-size: 18px;
            padding: 5px;
        }

        input {
            font-family: 'Trebuchet MS', sans-serif;
            font-size: 18px;
            margin-bottom: 10px;
        }

        .delete-button {
            display: block;
            background-color: #ff5252;
            padding: 10px;
            border-radius: 20px;
            width: 160px;
            height: 20px;
            text-align: center;
            cursor: pointer;
  ");
                WriteLiteral(@"          font-size: 20px;
            transition: 0.2s;
        }

        .delete-button a {
            text-decoration: none;
            color: #ffffff;
        }

        .delete-button:hover {
            background-color: #ffa6a6;
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
            BeginContext(3533, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3535, 3558, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c30de665394a3d0005bf50bf462451a4297e8c12271", async() => {
                BeginContext(3541, 153, true);
                WriteLiteral("\r\n    <div class=\"topbar\">\r\n        <span class=\"navbtn\" onclick=\"nav()\">&#9776; </span>\r\n        <h1 style=\"width: 57%;\">Beheer groepen</h1>\r\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3694, "\"", 3723, 1);
#line 153 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 3701, Url.Action("Profile"), 3701, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3724, 19, true);
                WriteLiteral("><img id=\"acc-icon\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3743, "\"", 3786, 1);
#line 153 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 3749, Url.Content("~/Content/account.png"), 3749, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3787, 112, true);
                WriteLiteral(" /></a>\r\n    </div>\r\n\r\n    <div id=\"nav\" class=\"overlay\">\r\n        <div class=\"overlay-content\">\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3899, "\"", 3929, 1);
#line 158 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 3906, Url.Action("Newsfeed"), 3906, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3930, 46, true);
                WriteLiteral(">Nieuws</a> \r\n            <br>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3976, "\"", 4016, 1);
#line 160 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 3983, Url.Action("ForumHome", "Forum"), 3983, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4017, 45, true);
                WriteLiteral(">Forums</a>\r\n            <br>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4062, "\"", 4097, 1);
#line 162 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 4069, Url.Action("Index", "Chat"), 4069, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4098, 43, true);
                WriteLiteral(">Chat</a>\r\n            <br>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", "  href=\"", 4141, "\"", 4171, 1);
#line 164 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 4149, Url.Action("Groepen"), 4149, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4172, 46, true);
                WriteLiteral(">Groepen</a>\r\n            <br>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4218, "\"", 4250, 1);
#line 166 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 4225, Url.Action("Personlist"), 4225, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4251, 183, true);
                WriteLiteral(">Gebruikers</a>\r\n        </div>\r\n        <div class=\"logout\"><a onclick=\"nav()\" href=\"#logout\">Log uit</a></div>\r\n    </div>\r\n    <div class=\"content\">\r\n        <div class=\"groups\">\r\n");
                EndContext();
#line 172 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
            if (Model.OwnedGroups.Count != 0)
            {
               

#line default
#line hidden
#line 174 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
                foreach (var group in Model.OwnedGroups)
                {

#line default
#line hidden
                BeginContext(4573, 22, true);
                WriteLiteral("                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4595, "\"", 4661, 1);
#line 176 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 4602, Url.Action("ManageGroup", new { GroupId = group.GroupId }), 4602, 59, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4662, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(4664, 15, false);
#line 176 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
                                                                                     Write(group.GroupName);

#line default
#line hidden
                EndContext();
                BeginContext(4679, 6, true);
                WriteLiteral("</a>\r\n");
                EndContext();
#line 177 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
                }

#line default
#line hidden
#line 177 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
                 
            } else
            {

#line default
#line hidden
                BeginContext(4739, 52, true);
                WriteLiteral("                <a>Je beheert nog geen groepen</a>\r\n");
                EndContext();
#line 181 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
            }

#line default
#line hidden
                BeginContext(4806, 90, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"group-options\">\r\n            <a id=\"create-groups\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4896, "\"", 4925, 1);
#line 186 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 4903, Url.Action("Groepen"), 4903, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4926, 41, true);
                WriteLiteral(">&#8592; Groepen</a><a id=\"create-groups\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4967, "\"", 5010, 1);
#line 186 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 4974, Url.Action("CreateGroups", "Admin"), 4974, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5011, 28, true);
                WriteLiteral(">Groep maken &#8594;</a>\r\n\r\n");
                EndContext();
#line 188 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
            if (Model.GroupsManagement != null)
            {
               

#line default
#line hidden
#line 190 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
                foreach (var group in Model.GroupsManagement)
                {

#line default
#line hidden
                BeginContext(5185, 111, true);
                WriteLiteral("                    <div id=\"Add-Delete-PersonToGroup\">\r\n                        <a>Voeg een nieuw lid toe aan ");
                EndContext();
                BeginContext(5297, 21, false);
#line 193 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
                                                 Write(group.Group.GroupName);

#line default
#line hidden
                EndContext();
                BeginContext(5318, 30, true);
                WriteLiteral("</a>\r\n                        ");
                EndContext();
                BeginContext(5348, 651, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c30de665394a3d0005bf50bf462451a4297e8c20583", async() => {
                    BeginContext(5398, 65, true);
                    WriteLiteral("\r\n                            <input type=\"hidden\" name=\"GroupId\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 5463, "\"", 5491, 1);
#line 195 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 5471, group.Group.GroupId, 5471, 20, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(5492, 75, true);
                    WriteLiteral(">\r\n\r\n                            <select id=\"PersonId\" name=\"PersonId\">\r\n\r\n");
                    EndContext();
#line 199 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
                                 foreach (var nonmember in group.NonMembers)
                                 {

#line default
#line hidden
                    BeginContext(5681, 36, true);
                    WriteLiteral("                                    ");
                    EndContext();
                    BeginContext(5717, 85, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c30de665394a3d0005bf50bf462451a4297e8c21977", async() => {
                        BeginContext(5754, 19, false);
#line 201 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
                                                                   Write(nonmember.FirstName);

#line default
#line hidden
                        EndContext();
                        BeginContext(5773, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(5775, 18, false);
#line 201 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
                                                                                        Write(nonmember.LastName);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 201 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
                                       WriteLiteral(nonmember.PersonId);

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
                    BeginContext(5802, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 202 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
                                 }

#line default
#line hidden
                    BeginContext(5840, 152, true);
                    WriteLiteral("\r\n                            </select><br>\r\n\r\n                            <input type=\"submit\" value=\"Toevoegen\" id=\"submit\">\r\n                        ");
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
                BeginContext(5999, 30, true);
                WriteLiteral("\r\n                    </div>\r\n");
                EndContext();
                BeginContext(6031, 112, true);
                WriteLiteral("                    <div id=\"Add-Delete-PersonToGroup\">\r\n                        <a>Verwijder een groepslid uit ");
                EndContext();
                BeginContext(6144, 21, false);
#line 211 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
                                                  Write(group.Group.GroupName);

#line default
#line hidden
                EndContext();
                BeginContext(6165, 30, true);
                WriteLiteral("</a>\r\n                        ");
                EndContext();
                BeginContext(6195, 655, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c30de665394a3d0005bf50bf462451a4297e8c27297", async() => {
                    BeginContext(6250, 65, true);
                    WriteLiteral("\r\n                            <input type=\"hidden\" name=\"GroupId\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 6315, "\"", 6343, 1);
#line 213 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 6323, group.Group.GroupId, 6323, 20, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(6344, 81, true);
                    WriteLiteral(">\r\n      \r\n                            <select id=\"PersonId\" name=\"PersonId\">\r\n\r\n");
                    EndContext();
#line 217 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
                                 foreach (var member in group.Group.Members)
                                 {

#line default
#line hidden
                    BeginContext(6539, 36, true);
                    WriteLiteral("                                    ");
                    EndContext();
                    BeginContext(6575, 76, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c30de665394a3d0005bf50bf462451a4297e8c28697", async() => {
                        BeginContext(6609, 16, false);
#line 219 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
                                                                Write(member.FirstName);

#line default
#line hidden
                        EndContext();
                        BeginContext(6625, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(6627, 15, false);
#line 219 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
                                                                                  Write(member.LastName);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 219 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
                                       WriteLiteral(member.PersonId);

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
                    BeginContext(6651, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 220 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
                                 }

#line default
#line hidden
                    BeginContext(6689, 154, true);
                    WriteLiteral("\r\n                            </select><br>\r\n\r\n                            <input type=\"submit\" value=\"Verwijderen\" id=\"submit\">\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
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
                BeginContext(6850, 30, true);
                WriteLiteral("\r\n                    </div>\r\n");
                EndContext();
                BeginContext(6882, 49, true);
                WriteLiteral("                    <div class=\"delete-button\"><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 6931, "\"", 6993, 1);
#line 228 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 6938, Url.Action("DeleteGroup", new { group.Group.GroupId }), 6938, 55, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6994, 30, true);
                WriteLiteral(">Groep verwijderen</a></div>\r\n");
                EndContext();
#line 229 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
                }

#line default
#line hidden
#line 229 "C:\Users\amyno\Documents\Repos\meldboek\Views\Person\GroepenManagen.cshtml"
                 
            }

#line default
#line hidden
                BeginContext(7058, 28, true);
                WriteLiteral("        </div>\r\n    </div>\r\n");
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
            BeginContext(7093, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
