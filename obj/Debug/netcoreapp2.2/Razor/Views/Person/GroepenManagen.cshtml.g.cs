#pragma checksum "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc75897b97e35b41441f84f7dc3fccdcf6b168f6"
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
#line 1 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/_ViewImports.cshtml"
using meldboek;

#line default
#line hidden
#line 2 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/_ViewImports.cshtml"
using meldboek.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc75897b97e35b41441f84f7dc3fccdcf6b168f6", @"/Views/Person/GroepenManagen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8de9e6b9d5c199835f9faa7d02b60c87e660435", @"/Views/_ViewImports.cshtml")]
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
#line 1 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
  
    ViewData["Title"] = "Groepen beheren";

#line default
#line hidden
            BeginContext(48, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(64, 24, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(88, 2781, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc75897b97e35b41441f84f7dc3fccdcf6b168f66173", async() => {
                BeginContext(94, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(99, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bc75897b97e35b41441f84f7dc3fccdcf6b168f66549", async() => {
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
                BeginContext(170, 2692, true);
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
            border: none;
            cursor: pointer;
 ");
                WriteLiteral(@"           transition: 0.2s;
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
            padding-bottom: 15px;
            transition: 0.2s;
            word-wrap: break-wo");
                WriteLiteral(@"rd;
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
            BeginContext(2869, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(2870, 3332, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc75897b97e35b41441f84f7dc3fccdcf6b168f611509", async() => {
                BeginContext(2876, 149, true);
                WriteLiteral("\n    <div class=\"topbar\">\n        <span class=\"navbtn\" onclick=\"nav()\">&#9776; </span>\n        <h1 style=\"width: 57%;\">Beheer groepen</h1>\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3025, "\"", 3054, 1);
#line 131 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
WriteAttributeValue("", 3032, Url.Action("Profile"), 3032, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3055, 19, true);
                WriteLiteral("><img id=\"acc-icon\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3074, "\"", 3117, 1);
#line 131 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
WriteAttributeValue("", 3080, Url.Content("~/Content/account.png"), 3080, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3118, 107, true);
                WriteLiteral(" /></a>\n    </div>\n\n    <div id=\"nav\" class=\"overlay\">\n        <div class=\"overlay-content\">\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3225, "\"", 3255, 1);
#line 136 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
WriteAttributeValue("", 3232, Url.Action("Newsfeed"), 3232, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3256, 44, true);
                WriteLiteral(">Nieuws</a> \n            <br>\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3300, "\"", 3340, 1);
#line 138 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
WriteAttributeValue("", 3307, Url.Action("ForumHome", "Forum"), 3307, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3341, 43, true);
                WriteLiteral(">Forums</a>\n            <br>\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3384, "\"", 3419, 1);
#line 140 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
WriteAttributeValue("", 3391, Url.Action("Index", "Chat"), 3391, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3420, 41, true);
                WriteLiteral(">Chat</a>\n            <br>\n            <a");
                EndContext();
                BeginWriteAttribute("href", "  href=\"", 3461, "\"", 3491, 1);
#line 142 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
WriteAttributeValue("", 3469, Url.Action("Groepen"), 3469, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3492, 44, true);
                WriteLiteral(">Groepen</a>\n            <br>\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3536, "\"", 3568, 1);
#line 144 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
WriteAttributeValue("", 3543, Url.Action("Personlist"), 3543, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3569, 177, true);
                WriteLiteral(">Gebruikers</a>\n        </div>\n        <div class=\"logout\"><a onclick=\"nav()\" href=\"#logout\">Log uit</a></div>\n    </div>\n    <div class=\"content\">\n        <div class=\"groups\">\n");
                EndContext();
#line 150 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
            if (Model.OwnedGroups.Count != 0)
            {
               

#line default
#line hidden
#line 152 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
                foreach (var group in Model.OwnedGroups)
                {

#line default
#line hidden
                BeginContext(3881, 22, true);
                WriteLiteral("                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3903, "\"", 3969, 1);
#line 154 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
WriteAttributeValue("", 3910, Url.Action("ManageGroup", new { GroupId = group.GroupId }), 3910, 59, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3970, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(3972, 15, false);
#line 154 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
                                                                                     Write(group.GroupName);

#line default
#line hidden
                EndContext();
                BeginContext(3987, 5, true);
                WriteLiteral("</a>\n");
                EndContext();
#line 155 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
                }

#line default
#line hidden
#line 155 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
                 
            } else
            {

#line default
#line hidden
                BeginContext(4043, 51, true);
                WriteLiteral("                <a>Je beheert nog geen groepen</a>\n");
                EndContext();
#line 159 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
            }

#line default
#line hidden
                BeginContext(4108, 86, true);
                WriteLiteral("\n        </div>\n\n        <div class=\"group-options\">\n            <a id=\"create-groups\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4194, "\"", 4223, 1);
#line 164 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
WriteAttributeValue("", 4201, Url.Action("Groepen"), 4201, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4224, 41, true);
                WriteLiteral(">&#8592; Groepen</a><a id=\"create-groups\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4265, "\"", 4308, 1);
#line 164 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
WriteAttributeValue("", 4272, Url.Action("CreateGroups", "Admin"), 4272, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4309, 26, true);
                WriteLiteral(">Groep maken &#8594;</a>\n\n");
                EndContext();
#line 166 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
            if (Model.GroupsManagement != null)
            {
               

#line default
#line hidden
#line 168 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
                foreach (var group in Model.GroupsManagement)
                {

#line default
#line hidden
                BeginContext(4477, 110, true);
                WriteLiteral("                    <div id=\"Add-Delete-PersonToGroup\">\n                        <a>Voeg een nieuw lid toe aan ");
                EndContext();
                BeginContext(4588, 21, false);
#line 171 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
                                                 Write(group.Group.GroupName);

#line default
#line hidden
                EndContext();
                BeginContext(4609, 29, true);
                WriteLiteral("</a>\n                        ");
                EndContext();
                BeginContext(4638, 638, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc75897b97e35b41441f84f7dc3fccdcf6b168f619860", async() => {
                    BeginContext(4688, 64, true);
                    WriteLiteral("\n                            <input type=\"hidden\" name=\"GroupId\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 4752, "\"", 4780, 1);
#line 173 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
WriteAttributeValue("", 4760, group.Group.GroupId, 4760, 20, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(4781, 71, true);
                    WriteLiteral(">\n\n                            <select id=\"PersonId\" name=\"PersonId\">\n\n");
                    EndContext();
#line 177 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
                                 foreach (var nonmember in group.NonMembers)
                                 {

#line default
#line hidden
                    BeginContext(4964, 36, true);
                    WriteLiteral("                                    ");
                    EndContext();
                    BeginContext(5000, 85, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc75897b97e35b41441f84f7dc3fccdcf6b168f621250", async() => {
                        BeginContext(5037, 19, false);
#line 179 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
                                                                   Write(nonmember.FirstName);

#line default
#line hidden
                        EndContext();
                        BeginContext(5056, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(5058, 18, false);
#line 179 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
                                                                                        Write(nonmember.LastName);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 179 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
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
                    BeginContext(5085, 1, true);
                    WriteLiteral("\n");
                    EndContext();
#line 180 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
                                 }

#line default
#line hidden
                    BeginContext(5121, 148, true);
                    WriteLiteral("\n                            </select><br>\n\n                            <input type=\"submit\" value=\"Toevoegen\" id=\"submit\">\n                        ");
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
                BeginContext(5276, 28, true);
                WriteLiteral("\n                    </div>\n");
                EndContext();
                BeginContext(5305, 111, true);
                WriteLiteral("                    <div id=\"Add-Delete-PersonToGroup\">\n                        <a>Verwijder een groepslid uit ");
                EndContext();
                BeginContext(5417, 21, false);
#line 189 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
                                                  Write(group.Group.GroupName);

#line default
#line hidden
                EndContext();
                BeginContext(5438, 29, true);
                WriteLiteral("</a>\n                        ");
                EndContext();
                BeginContext(5467, 642, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc75897b97e35b41441f84f7dc3fccdcf6b168f626542", async() => {
                    BeginContext(5522, 64, true);
                    WriteLiteral("\n                            <input type=\"hidden\" name=\"GroupId\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 5586, "\"", 5614, 1);
#line 191 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
WriteAttributeValue("", 5594, group.Group.GroupId, 5594, 20, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(5615, 77, true);
                    WriteLiteral(">\n      \n                            <select id=\"PersonId\" name=\"PersonId\">\n\n");
                    EndContext();
#line 195 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
                                 foreach (var member in group.Group.Members)
                                 {

#line default
#line hidden
                    BeginContext(5804, 36, true);
                    WriteLiteral("                                    ");
                    EndContext();
                    BeginContext(5840, 76, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc75897b97e35b41441f84f7dc3fccdcf6b168f627938", async() => {
                        BeginContext(5874, 16, false);
#line 197 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
                                                                Write(member.FirstName);

#line default
#line hidden
                        EndContext();
                        BeginContext(5890, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(5892, 15, false);
#line 197 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
                                                                                  Write(member.LastName);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 197 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
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
                    BeginContext(5916, 1, true);
                    WriteLiteral("\n");
                    EndContext();
#line 198 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
                                 }

#line default
#line hidden
                    BeginContext(5952, 150, true);
                    WriteLiteral("\n                            </select><br>\n\n                            <input type=\"submit\" value=\"Verwijderen\" id=\"submit\">\n                        ");
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
                BeginContext(6109, 28, true);
                WriteLiteral("\n                    </div>\n");
                EndContext();
#line 205 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
                }

#line default
#line hidden
#line 205 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/GroepenManagen.cshtml"
                 
            }

#line default
#line hidden
                BeginContext(6169, 26, true);
                WriteLiteral("        </div>\n    </div>\n");
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
            BeginContext(6202, 8, true);
            WriteLiteral("\n</html>");
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
