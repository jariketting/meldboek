#pragma checksum "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ab12ace10564fdae5dfa377a5dab0aef6ef279b"
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
#line 1 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/_ViewImports.cshtml"
using meldboek;

#line default
#line hidden
#line 2 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/_ViewImports.cshtml"
using meldboek.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ab12ace10564fdae5dfa377a5dab0aef6ef279b", @"/Views/Person/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8de9e6b9d5c199835f9faa7d02b60c87e660435", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<meldboek.ViewModels.Profile>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Topbar_Sidenav.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
  
    ViewData["Title"] = "Profiel";

#line default
#line hidden
            BeginContext(40, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(76, 28, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n    ");
            EndContext();
            BeginContext(104, 3148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ab12ace10564fdae5dfa377a5dab0aef6ef279b5506", async() => {
                BeginContext(110, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(119, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2ab12ace10564fdae5dfa377a5dab0aef6ef279b5888", async() => {
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
                BeginContext(190, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(199, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ab12ace10564fdae5dfa377a5dab0aef6ef279b7290", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(258, 2987, true);
                WriteLiteral(@"
        <style>
            .topbar {
                background-color: orange;
            }

            .navbtn {
                background-color: orange;
            }

            .overlay {
                background-color: orange;
            }

            .overlay a:hover, .overlay a:focus, .logout a:hover, .logout a:focus {
                color: #ffe4b3;
            }

            body {
                font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;

            }

            .profile-content {
                margin-left: 10%;
                padding-bottom: 10%;
            }
            
            /* Information about the current Person. */
            .info h1 {
                font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
                color: orange;
                font-size: 26px;
                font-weight: bold;
                padding-top: 150px;
            }

        ");
                WriteLiteral(@"    .info h2 {
                padding-top: 10px;
                color: #000000;
                font-size: 22px;
            }

            /* Persons list includes friends and incoming/outgoing friend requests. */
            .person-list {
                padding-top: 40px;
            }

            .personlist-content {
                width: 100%;
                overflow: hidden;
                padding-top: 100px;
                padding-bottom: 50px;
            }

            .person-list h1 {
                color: orange;
                font-size: 24px;
            }

            /* Single person */
            .person {
                width: 90%;
                overflow: hidden;
                border-bottom: 1px solid orange;
            }

            /* Person content consists of name (h1) and friend/unfriend options (a). */
            .person-content {
                float: left;
                width: 80%;
            }

            .person-content h1 {
                color: #000000;
");
                WriteLiteral(@"                font-size: 22px;
                padding-bottom: 10px;
                padding-top: 20px;
            }

            .person-options {
                margin-top: 20px;
                margin-left: 83%;
            }

            .person-options a {
                text-decoration: none;
                font-size: 20px;
            }

            /* Link to accept and incoming friend request. */
            #accept-friend {
                color: #00ff00;
                transition: 0.2s;
                display: block;
            }

            #accept-friend:hover {
                color: #b3ffb3;
            }

            /* Link to delete a friend or deny an incoming friend request. */
            #deny-delete-friend {
                color: #ff0000;
                transition: 0.2s;
            }

            #deny-delete-friend:hover {
                color: #ffb3b3;
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
            BeginContext(3252, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(3257, 4498, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ab12ace10564fdae5dfa377a5dab0aef6ef279b12454", async() => {
                BeginContext(3263, 320, true);
                WriteLiteral(@"    
        <div class=""topbar"">

            <!-- The button that opens the sidemenu -->
            <span class=""navbtn"" onclick=""nav()"">&#9776; </span>

            <!-- Page title -->
            <h1 style=""width: 53%;"">Profiel</h1>

            <!-- Account information button -->
            <a><img id=""acc-icon""");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3583, "\"", 3626, 1);
#line 133 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
WriteAttributeValue("", 3589, Url.Content("~/Content/account.png"), 3589, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3627, 157, true);
                WriteLiteral(" /></a>\n        </div>\n\n        <!-- Sidemenu overlay -->\n        <div id=\"nav\" class=\"overlay\">\n            <div class=\"overlay-content\">\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3784, "\"", 3814, 1);
#line 139 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
WriteAttributeValue("", 3791, Url.Action("Newsfeed"), 3791, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3815, 51, true);
                WriteLiteral(">Nieuws</a>\n                <br>\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3866, "\"", 3905, 1);
#line 141 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
WriteAttributeValue("", 3873, Url.Action("ForumHome","Forum"), 3873, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3906, 51, true);
                WriteLiteral(">Forums</a>\n                <br>\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3957, "\"", 3992, 1);
#line 143 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
WriteAttributeValue("", 3964, Url.Action("Index", "Chat"), 3964, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3993, 49, true);
                WriteLiteral(">Chat</a>\n                <br>\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4042, "\"", 4071, 1);
#line 145 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
WriteAttributeValue("", 4049, Url.Action("Groepen"), 4049, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4072, 52, true);
                WriteLiteral(">Groepen</a>\n                <br>\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4124, "\"", 4156, 1);
#line 147 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
WriteAttributeValue("", 4131, Url.Action("Personlist"), 4131, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4157, 69, true);
                WriteLiteral(">Gebruikers</a>\n            </div>\n            <div class=\"logout\"><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4226, "\"", 4254, 1);
#line 149 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
WriteAttributeValue("", 4233, Url.Action("Logout"), 4233, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4255, 260, true);
                WriteLiteral(@">Log uit</a></div>
        </div>

        <!-- Actual content of the page -->
        <div class=""profile-content"">

            <!-- Information of the current Person -->
            <div class=""info"">
                <h1>Info</h1>
                <h2>Naam: ");
                EndContext();
                BeginContext(4516, 10, false);
#line 158 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
                     Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(4526, 33, true);
                WriteLiteral("</h2>\n                <h2>Email: ");
                EndContext();
                BeginContext(4560, 11, false);
#line 159 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
                      Write(Model.Email);

#line default
#line hidden
                EndContext();
                BeginContext(4571, 192, true);
                WriteLiteral("</h2>\n            </div>\n\n            <!-- This personlist includes friends and incoming/outgoing friend requests. -->\n            <div class=\"person-list\">\n                <h1>Vrienden</h1>\n\n");
                EndContext();
#line 166 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
                foreach (var person in Model.PersonInfos)
                {


#line default
#line hidden
                BeginContext(4840, 138, true);
                WriteLiteral("                   <!-- If the Person from the model is friends with the current Person, they are placed in the friendlist attribute. -->\n");
                EndContext();
#line 170 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
                    if (person.Status == "IsFriendsWith")
                    {

#line default
#line hidden
                BeginContext(5058, 138, true);
                WriteLiteral("                        <div class=\"person\">\n                            <div class=\"person-content\">\n                                <h1>");
                EndContext();
                BeginContext(5197, 23, false);
#line 174 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
                               Write(person.Person.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(5220, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(5222, 22, false);
#line 174 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
                                                        Write(person.Person.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(5244, 156, true);
                WriteLiteral("</h1>\n                            </div>\n                            <div class=\"person-options\">\n                                <a id=\"deny-delete-friend\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5400, "\"", 5494, 1);
#line 177 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
WriteAttributeValue("", 5407, Url.Action("DeleteFriendProfile", "Person", new { FriendId = person.Person.PersonId }), 5407, 87, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5495, 90, true);
                WriteLiteral(">Vriend verwijderen</a>\n                            </div>\n                        </div>\n");
                EndContext();
#line 180 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
                    }

#line default
#line hidden
#line 180 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
                     
                }

#line default
#line hidden
                BeginContext(5625, 132, true);
                WriteLiteral("\n            </div>\n\n            <div class=\"person-list\">\n                <h1>Ontvangen vriendschapsverzoeken</h1>\n               \n");
                EndContext();
#line 188 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
                foreach (var person in Model.PersonInfos)
                {

#line default
#line hidden
                BeginContext(5833, 166, true);
                WriteLiteral("                   <!-- If the current from the model is a pending friend to the Person from the model, they are placed in the incoming friendrequests attribute. -->\n");
                EndContext();
#line 191 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
                    if (person.Status == "requested")
                    {

#line default
#line hidden
                BeginContext(6075, 138, true);
                WriteLiteral("                        <div class=\"person\">\n                            <div class=\"person-content\">\n                                <h1>");
                EndContext();
                BeginContext(6214, 23, false);
#line 195 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
                               Write(person.Person.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(6237, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(6239, 22, false);
#line 195 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
                                                        Write(person.Person.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(6261, 177, true);
                WriteLiteral("</h1>\n                            </div>\n                            <div class=\"person-options\" style=\"margin-top: 10px;\">\n                                <a id=\"accept-friend\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 6438, "\"", 6552, 1);
#line 198 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
WriteAttributeValue("", 6445, Url.Action("AcceptFriend", "Person", new { PersonRequestedId = person.Person.PersonId, page = "Profile" }), 6445, 107, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6553, 81, true);
                WriteLiteral(">Vriend accepteren</a>\n                                <a id=\"deny-delete-friend\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 6634, "\"", 6742, 1);
#line 199 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
WriteAttributeValue("", 6641, Url.Action("RefuseFriendReq", "Person", new { PersonId = person.Person.PersonId, page = "Profile" }), 6641, 101, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6743, 87, true);
                WriteLiteral(">Vriend afwijzen</a>\n                            </div>\n                        </div>\n");
                EndContext();
#line 202 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
                    }

#line default
#line hidden
#line 202 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
                     
                }

#line default
#line hidden
                BeginContext(6870, 118, true);
                WriteLiteral("\n            </div>\n\n            <div class=\"person-list\">\n                <h1>Verstuurde vriendschapsverzoeken</h1>\n\n");
                EndContext();
#line 210 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
                foreach (var person in Model.PersonInfos)
                {


#line default
#line hidden
                BeginContext(7065, 158, true);
                WriteLiteral("                   <!-- If the Person from the model is a pending friend to the current Person, they are placed in the outgoing friendrequests attribute. -->\n");
                EndContext();
#line 214 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
                    if (person.Status == "FriendPending")
                    {

#line default
#line hidden
                BeginContext(7303, 138, true);
                WriteLiteral("                        <div class=\"person\">\n                            <div class=\"person-content\">\n                                <h1>");
                EndContext();
                BeginContext(7442, 23, false);
#line 218 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
                               Write(person.Person.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(7465, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(7467, 22, false);
#line 218 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
                                                        Write(person.Person.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(7489, 180, true);
                WriteLiteral("</h1>\n                            </div>\n                            <div class=\"person-options\"><a style=\"color: #0000ff;\">In behandeling</a></div>\n                        </div>\n");
                EndContext();
#line 222 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
                    }

#line default
#line hidden
#line 222 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Person/Profile.cshtml"
                     
                }

#line default
#line hidden
                BeginContext(7709, 39, true);
                WriteLiteral("\n            </div>\n        </div>\n    ");
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
            BeginContext(7755, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<meldboek.ViewModels.Profile> Html { get; private set; }
    }
}
#pragma warning restore 1591
