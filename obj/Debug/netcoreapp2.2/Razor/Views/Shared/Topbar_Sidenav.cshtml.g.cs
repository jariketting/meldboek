#pragma checksum "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Shared/Topbar_Sidenav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ea0496998f33169ce7622ca6a463eab0395434a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Topbar_Sidenav), @"mvc.1.0.view", @"/Views/Shared/Topbar_Sidenav.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Topbar_Sidenav.cshtml", typeof(AspNetCore.Views_Shared_Topbar_Sidenav))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ea0496998f33169ce7622ca6a463eab0395434a", @"/Views/Shared/Topbar_Sidenav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8de9e6b9d5c199835f9faa7d02b60c87e660435", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Topbar_Sidenav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 857, true);
            WriteLiteral(@"<style>
    .topbar {
        background-color: #000000; /* Verander deze naar de kleur uit de mockups van je view. */
    }

    .navbtn {
        background-color: #000000; /* Verander deze naar de kleur uit de mockups van je view. */
    }

    .overlay {
        background-color: #000000; /* Verander deze naar de kleur uit de mockups van je view. */
    }

    .overlay a:hover, .overlay a:focus, .logout a:hover, .logout a:focus {
        color: #000000; /* Deze is anders van de vorige 3, dit is de kleur die tekst krijg bij hover (is ook in de mockups te vinden). */
    }
</style>

<!-- Colored bar at the top of the page -->
<div class=""topbar"">

    <!-- The button that opens the sidemenu -->
    <span class=""navbtn"" onclick=""nav()"">&#9776; </span>

    <!-- Page title -->
    <h1>Newsfeed</h1>

    <!-- Account information button -->
    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 857, "\"", 886, 1);
#line 29 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Shared/Topbar_Sidenav.cshtml"
WriteAttributeValue("", 864, Url.Action("Profile"), 864, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(887, 19, true);
            WriteLiteral("><img id=\"acc-icon\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 906, "\"", 949, 1);
#line 29 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Shared/Topbar_Sidenav.cshtml"
WriteAttributeValue("", 912, Url.Content("~/Content/account.png"), 912, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(950, 410, true);
            WriteLiteral(@"/></a>
</div>

<!-- Sidemenu overlay -->
<div id=""nav"" class=""overlay"">
    <div class=""overlay-content"">
        <p style=""color: #ffffff;"">Newsfeed</p> <!-- Dit is hoe een optie eruit ziet als het de huidige pagina is, dit moet je dus ook veranderen. -->
        <br>                                    <!-- Zorg dat de kleur hetzelfde is als de kleur van hover (laatste element in de <style>).-->
        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1360, "\"", 1399, 1);
#line 37 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Shared/Topbar_Sidenav.cshtml"
WriteAttributeValue("", 1367, Url.Action("ForumHome","Forum"), 1367, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1400, 168, true);
            WriteLiteral(">Forums</a> <!-- Dit is hoe je opties neerzet die niet je huidige pagina zijn. -->\n        <br>\n        <a onclick=\"nav()\" href=\"#chat\">Chat</a>\n        <br>\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1568, "\"", 1597, 1);
#line 41 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Shared/Topbar_Sidenav.cshtml"
WriteAttributeValue("", 1575, Url.Action("Groepen"), 1575, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1598, 36, true);
            WriteLiteral(">Groepen</a>\n        <br>\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1634, "\"", 1666, 1);
#line 43 "/Users/yasemin/Documents/Inf_jaar_2/Project D/meldboek/Views/Shared/Topbar_Sidenav.cshtml"
WriteAttributeValue("", 1641, Url.Action("Personlist"), 1641, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1667, 109, true);
            WriteLiteral(">Gebruikers</a>\n    </div>\n    <div class=\"logout\"><a onclick=\"nav()\" href=\"#logout\">Log uit</a></div>\n</div>");
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
