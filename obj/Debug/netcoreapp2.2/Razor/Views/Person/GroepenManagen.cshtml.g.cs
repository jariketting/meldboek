#pragma checksum "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e56863acdaeb2b946cf7c874c11e0685e23c521"
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
#line 1 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\_ViewImports.cshtml"
using meldboek;

#line default
#line hidden
#line 2 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\_ViewImports.cshtml"
using meldboek.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e56863acdaeb2b946cf7c874c11e0685e23c521", @"/Views/Person/GroepenManagen.cshtml")]
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
#line 1 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
  
    ViewData["Title"] = "Groepen beheren";

#line default
#line hidden
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(69, 31, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n    ");
            EndContext();
            BeginContext(100, 3954, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e56863acdaeb2b946cf7c874c11e0685e23c5216205", async() => {
                BeginContext(106, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(116, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1e56863acdaeb2b946cf7c874c11e0685e23c5216595", async() => {
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
                BeginContext(187, 3860, true);
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
  ");
                WriteLiteral(@"              border-radius: 25px;
                padding: 10px 15px;
                border: none;
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
                border-right: 2px solid ");
                WriteLiteral(@"#ffed00;
                overflow-y: auto;
            }

            .groups a {
                color: #000000;
                font-size: 24px;
                text-decoration: none;
                display: block;
                padding-bottom: 15px;
                transition: 0.2s;
                word-wrap: break-word;
            }

            .groups a:hover {
                color: #fff9a6;
            }

            #no-groups:hover {
                color: #000000;
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

            inp");
                WriteLiteral(@"ut {
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
                font-size: 20px;
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
            BeginContext(4054, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(4060, 4693, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e56863acdaeb2b946cf7c874c11e0685e23c52112802", async() => {
                BeginContext(4066, 369, true);
                WriteLiteral(@"

        <!-- Colored bar at the top of the page -->
        <div class=""topbar"">

            <!-- The button that opens the sidemenu -->
            <span class=""navbtn"" onclick=""nav()"">&#9776; </span>

            <!-- Page title -->
            <h1 style=""width: 57%;"">Beheer groepen</h1>

            <!-- Account information button -->
            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4435, "\"", 4464, 1);
#line 164 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 4442, Url.Action("Profile"), 4442, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4465, 19, true);
                WriteLiteral("><img id=\"acc-icon\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 4484, "\"", 4527, 1);
#line 164 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 4490, Url.Content("~/Content/account.png"), 4490, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4528, 163, true);
                WriteLiteral(" /></a>\r\n        </div>\r\n\r\n        <!-- Sidemenu overlay -->\r\n        <div id=\"nav\" class=\"overlay\">\r\n            <div class=\"overlay-content\">\r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4691, "\"", 4721, 1);
#line 170 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 4698, Url.Action("Newsfeed"), 4698, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4722, 53, true);
                WriteLiteral(">Nieuws</a>\r\n                <br>\r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4775, "\"", 4815, 1);
#line 172 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 4782, Url.Action("ForumHome", "Forum"), 4782, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4816, 53, true);
                WriteLiteral(">Forums</a>\r\n                <br>\r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4869, "\"", 4904, 1);
#line 174 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 4876, Url.Action("Index", "Chat"), 4876, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4905, 51, true);
                WriteLiteral(">Chat</a>\r\n                <br>\r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4956, "\"", 4985, 1);
#line 176 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 4963, Url.Action("Groepen"), 4963, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4986, 54, true);
                WriteLiteral(">Groepen</a>\r\n                <br>\r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5040, "\"", 5072, 1);
#line 178 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 5047, Url.Action("Personlist"), 5047, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5073, 71, true);
                WriteLiteral(">Gebruikers</a>\r\n            </div>\r\n            <div class=\"logout\"><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5144, "\"", 5172, 1);
#line 180 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 5151, Url.Action("Logout"), 5151, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5173, 301, true);
                WriteLiteral(@">Log uit</a></div>
        </div>

        <!-- Actual content of the page -->
        <div class=""content"">
            <div class=""groups"">

                <!-- Placing all the groups the Person owns in the sidemenu, if the Person doesn't own any groups a message is shown on the page. -->
");
                EndContext();
#line 188 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
                 if (Model.OwnedGroups.Count != 0)
                {
                    

#line default
#line hidden
#line 190 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
                     foreach (var group in Model.OwnedGroups)
                    {

#line default
#line hidden
                BeginContext(5631, 26, true);
                WriteLiteral("                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5657, "\"", 5723, 1);
#line 192 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 5664, Url.Action("ManageGroup", new { GroupId = group.GroupId }), 5664, 59, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5724, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(5726, 15, false);
#line 192 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
                                                                                         Write(group.GroupName);

#line default
#line hidden
                EndContext();
                BeginContext(5741, 6, true);
                WriteLiteral("</a>\r\n");
                EndContext();
#line 193 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
                    }

#line default
#line hidden
#line 193 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
                     
                }
                else
                {

#line default
#line hidden
                BeginContext(5830, 71, true);
                WriteLiteral("                    <a id=\"no-groups\">Je beheert nog geen groepen</a>\r\n");
                EndContext();
#line 198 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
                }

#line default
#line hidden
                BeginContext(5920, 195, true);
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"group-options\">\r\n\r\n                <!-- Links back to the list of groups and to the create a group page. -->\r\n                <a id=\"create-groups\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 6115, "\"", 6144, 1);
#line 205 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 6122, Url.Action("Groepen"), 6122, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6145, 41, true);
                WriteLiteral(">&#8592; Groepen</a><a id=\"create-groups\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 6186, "\"", 6229, 1);
#line 205 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 6193, Url.Action("CreateGroups", "Admin"), 6193, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6230, 142, true);
                WriteLiteral(">Groep maken &#8594;</a>\r\n\r\n                <!-- If the Person selects a group from the sidemenu they have access groupmanaging options. -->\r\n");
                EndContext();
#line 208 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
                if (Model.GroupsManagement != null)
                {
                   

#line default
#line hidden
#line 210 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
                    foreach (var group in Model.GroupsManagement)
                    {

#line default
#line hidden
                BeginContext(6534, 199, true);
                WriteLiteral("                        <!-- Option 1: Add a Person to the selected group. -->\r\n                        <div id=\"Add-Delete-PersonToGroup\">\r\n                            <a>Voeg een nieuw lid toe aan ");
                EndContext();
                BeginContext(6734, 21, false);
#line 214 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
                                                     Write(group.Group.GroupName);

#line default
#line hidden
                EndContext();
                BeginContext(6755, 34, true);
                WriteLiteral("</a>\r\n                            ");
                EndContext();
                BeginContext(6789, 668, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e56863acdaeb2b946cf7c874c11e0685e23c52122458", async() => {
                    BeginContext(6839, 69, true);
                    WriteLiteral("\r\n                                <input type=\"hidden\" name=\"GroupId\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 6908, "\"", 6936, 1);
#line 216 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 6916, group.Group.GroupId, 6916, 20, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(6937, 79, true);
                    WriteLiteral(">\r\n\r\n                                <select id=\"PersonId\" name=\"PersonId\">\r\n\r\n");
                    EndContext();
#line 220 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
                                foreach (var nonmember in group.NonMembers)
                                {

#line default
#line hidden
                    BeginContext(7128, 36, true);
                    WriteLiteral("                                    ");
                    EndContext();
                    BeginContext(7164, 85, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e56863acdaeb2b946cf7c874c11e0685e23c52123860", async() => {
                        BeginContext(7201, 19, false);
#line 222 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
                                                                   Write(nonmember.FirstName);

#line default
#line hidden
                        EndContext();
                        BeginContext(7220, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(7222, 18, false);
#line 222 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
                                                                                        Write(nonmember.LastName);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 222 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
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
                    BeginContext(7249, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 223 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
                                }

#line default
#line hidden
                    BeginContext(7286, 164, true);
                    WriteLiteral("\r\n                                </select><br>\r\n\r\n                                <input type=\"submit\" value=\"Toevoegen\" id=\"submit\">\r\n                            ");
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
                BeginContext(7457, 34, true);
                WriteLiteral("\r\n                        </div>\r\n");
                EndContext();
                BeginContext(7493, 205, true);
                WriteLiteral("                        <!-- Option 2: Delete a Person from the selected group. -->\r\n                        <div id=\"Add-Delete-PersonToGroup\">\r\n                            <a>Verwijder een groepslid uit ");
                EndContext();
                BeginContext(7699, 21, false);
#line 233 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
                                                      Write(group.Group.GroupName);

#line default
#line hidden
                EndContext();
                BeginContext(7720, 34, true);
                WriteLiteral("</a>\r\n                            ");
                EndContext();
                BeginContext(7754, 666, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e56863acdaeb2b946cf7c874c11e0685e23c52129303", async() => {
                    BeginContext(7809, 69, true);
                    WriteLiteral("\r\n                                <input type=\"hidden\" name=\"GroupId\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 7878, "\"", 7906, 1);
#line 235 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 7886, group.Group.GroupId, 7886, 20, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(7907, 79, true);
                    WriteLiteral(">\r\n\r\n                                <select id=\"PersonId\" name=\"PersonId\">\r\n\r\n");
                    EndContext();
#line 239 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
                                foreach (var member in group.Group.Members)
                                {

#line default
#line hidden
                    BeginContext(8098, 36, true);
                    WriteLiteral("                                    ");
                    EndContext();
                    BeginContext(8134, 76, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e56863acdaeb2b946cf7c874c11e0685e23c52130705", async() => {
                        BeginContext(8168, 16, false);
#line 241 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
                                                                Write(member.FirstName);

#line default
#line hidden
                        EndContext();
                        BeginContext(8184, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(8186, 15, false);
#line 241 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
                                                                                  Write(member.LastName);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 241 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
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
                    BeginContext(8210, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 242 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
                                }

#line default
#line hidden
                    BeginContext(8247, 166, true);
                    WriteLiteral("\r\n                                </select><br>\r\n\r\n                                <input type=\"submit\" value=\"Verwijderen\" id=\"submit\">\r\n                            ");
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
                BeginContext(8420, 34, true);
                WriteLiteral("\r\n                        </div>\r\n");
                EndContext();
                BeginContext(8456, 115, true);
                WriteLiteral("                        <!-- Option 3: Delete the group. -->\r\n                        <div class=\"delete-button\"><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 8571, "\"", 8633, 1);
#line 251 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
WriteAttributeValue("", 8578, Url.Action("DeleteGroup", new { group.Group.GroupId }), 8578, 55, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8634, 30, true);
                WriteLiteral(">Groep verwijderen</a></div>\r\n");
                EndContext();
#line 252 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
                    }

#line default
#line hidden
#line 252 "C:\Users\ses-9\Desktop\Meldboek\meldboek\Views\Person\GroepenManagen.cshtml"
                     
                }

#line default
#line hidden
                BeginContext(8706, 40, true);
                WriteLiteral("            </div>\r\n        </div>\r\n    ");
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
            BeginContext(8753, 9, true);
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
