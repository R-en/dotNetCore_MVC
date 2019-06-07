#pragma checksum "C:\Users\Ren\Documents\exploreCalifornia\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e296ec0df5f1bc3fa4901a7612b121120d770611"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\Ren\Documents\exploreCalifornia\Views\_ViewImports.cshtml"
using exploreCalifornia;

#line default
#line hidden
#line 2 "C:\Users\Ren\Documents\exploreCalifornia\Views\_ViewImports.cshtml"
using exploreCalifornia.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e296ec0df5f1bc3fa4901a7612b121120d770611", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d819bbe57157fb1d7aedb794438052c835d92892", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("no-js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE HTML>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 605, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e296ec0df5f1bc3fa4901a7612b121120d7706114041", async() => {
                BeginContext(41, 592, true);
                WriteLiteral(@"
<meta charset=""utf-8"">
<title>Welcome to Explore California</title>
<meta name=""description"" content=""A lynda.com example of HTML5 and CSS3"">
<meta name=""keywords"" content=""html5, css3, lynda, local storage, canvas, forms, semantics, web apps"">
<!--make sure mobile devices display the page at the proper scale	-->
<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
<!--[if lt IE 9]>
<script src=""http://html5shiv.googlecode.com/svn/trunk/html5.js""></script>
<![endif]-->
<link href=""/css/main.css"" rel=""stylesheet"" type=""text/css"" media=""screen, projection"">
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
            BeginContext(640, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(642, 5232, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e296ec0df5f1bc3fa4901a7612b121120d7706115837", async() => {
                BeginContext(672, 1650, true);
                WriteLiteral(@"
<div id=""wrapper"">
  <header id=""mainHeader""> <a href=""/"" title=""home"" class=""logo"">
   <!-- I need this div because IE is an affront to mankind-->
    <div>
    <h1>Explore California</h1>
    </div>
    </a>
    <nav id=""siteNav"">
      <h1>Where do you want to go?</h1>
      <ul>
       <li><a href=""/tours.htm"" title=""Our tours"">Tours <br /><span class=""tagline"">follow our bliss</span></a>
          <ul>
            <li><a href=""/tours.htm"" title=""Our tours"">All Tours</a></li>
            <li><a href=""/tours.htm"" title=""find tours"">Tours by Activity</a></li>
            <li><a href=""/tours.htm"" title=""find tours"">Tours by Region</a></li>
            <li><a href=""/tours.htm"" title=""find tours"">Tour Finder</a></li>
          </ul>
        </li>
        <li><a href=""mission.htm"" title=""What we believe"">Mission <br /><span class=""tagline"">what makes us different?</span></a></li>
        <li><a href=""resources.htm"" title=""planning resources"">Resources <br /><span class=""tagline"">plan your t");
                WriteLiteral(@"rip</span></a>
          <ul>
            <li><a href=""resources/faq.htm"" title=""Got questions?"">Tour FAQs</a></li>
            <li><a href=""resources/additional_resources.htm"" title=""additional resources"">Tour Information</a></li>
            <li><a href=""resources/terms.htm"" title=""terms and conditions"">Site Terms</a></li>
          </ul>
        </li>
        <li><a href=""explorers.htm"" title=""Our community"">Explorers <br /><span class=""tagline"">join our community</span></a>
          <ul>
            <li><a href=""explorers/join.htm"" title=""join our community"">Join the Explorers</a></li>
            <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2322, "\"", 2356, 1);
#line 45 "C:\Users\Ren\Documents\exploreCalifornia\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2329, Url.Action("Index","Blog"), 2329, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2357, 612, true);
                WriteLiteral(@" title=""read our blog!"">Read our Blog</a></li>
            <li><a href=""explorers/gallery.htm"" title=""contributor photos"">Tour Photos</a></li>
            <li><a href=""_video/EC_podcast_full version.mov"" title=""check out our podcast"">Video podcast</a></li>
          </ul>
        </li>
        <li><a href=""contact.htm"" title=""contact us"" class=""last"">Contact <br /><span class=""tagline"">we're listening</span></a>
          <ul>
            <li><a href=""support.htm"" title=""need help?"">Support</a></li>
          </ul>
        </li>
      </ul>
    </nav>
  </header>
  <section id=""actionCall"">
");
                EndContext();
#line 59 "C:\Users\Ren\Documents\exploreCalifornia\Views\Shared\_Layout.cshtml"
       if(IsSectionDefined("header")){
         

#line default
#line hidden
                BeginContext(3019, 29, false);
#line 60 "C:\Users\Ren\Documents\exploreCalifornia\Views\Shared\_Layout.cshtml"
    Write(RenderSection("header",false));

#line default
#line hidden
                EndContext();
#line 60 "C:\Users\Ren\Documents\exploreCalifornia\Views\Shared\_Layout.cshtml"
                                       
      }else{

#line default
#line hidden
                BeginContext(3064, 47, true);
                WriteLiteral("          <h1>Explore our world your way</h1>\r\n");
                EndContext();
#line 63 "C:\Users\Ren\Documents\exploreCalifornia\Views\Shared\_Layout.cshtml"
      }

#line default
#line hidden
                BeginContext(3120, 75, true);
                WriteLiteral("  </section>\r\n  <div id=\"contentWrapper\">\r\n  <section id=\"mainContent\">\r\n  ");
                EndContext();
                BeginContext(3196, 12, false);
#line 67 "C:\Users\Ren\Documents\exploreCalifornia\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3208, 2363, true);
                WriteLiteral(@"
  </section>
    <aside id=""secondaryContent"">
        <div id=""specials"" class=""callOut"">
            <h1>Monthly Specials</h1>
            <h2 class=""top""><img src=""/images/calm_bug.gif"" alt=""California Calm"" width=""75"" height=""75"">California Calm</h2>
            <p>
                Day Spa Package <br>
                <a href=""/tours/tour_detail_cycle.htm"">$250</a>
            </p>
            <h2><img src=""/images/desert_bug.gif"" alt=""From desert to sea"" width=""75"" height=""75"">From Desert to Sea</h2>
            <p>
                2 Day Salton Sea <br>
                <a href=""/tours/tour_detail_cycle.htm"">$350</a>
            </p>
            <h2><img src=""/images/backpack_bug.gif"" alt=""Backpack Cali"" width=""75"" height=""41"">Backpack Cali</h2>
            <p>
                Big Sur Retreat <br>
                <a href=""/tours/tour_detail_cycle.htm"">$620</a>
            </p>
            <h2><img src=""/images/taste_bug.gif"" alt=""Taste of California"" width=""75"" height=""75"">Taste of Ca");
                WriteLiteral(@"lifornia</h2>
            <p>
                Tapas &amp; Groves <br>
                <a href=""/tours/tour_detail_taste.htm"">$150</a>
            </p>
        </div>
        <div id=""trivia"" class=""callOut"">
            <h1>Did You Know?</h1>
            <p>California produces over 17 million gallons of wine each year!</p>
        </div>
    </aside>
  </div>
  <footer id=""pageFooter"">
  <section id=""quickLinks"">
  <h1>Quick Nav</h1>
    <ul id=""quickNav"">
      <li><a href=""/"" title=""Our home page"">Home</a></li>
      <li><a href=""/tours.htm"" title=""Explore our tours"">Tours</a></li>
      <li><a href=""mission.htm"" title=""What we think"">Mission</a></li>
      <li><a href=""resources.htm"" title=""Guidance and planning"">Resources</a></li>
      <li><a href=""explorers.htm"" title=""Join our community"">Explorers</a></li>
      <li><a href=""contact.htm"" title=""Contact and support"">Contact</a></li>
    </ul>
  </section>
  <section id=""footerResources"">
  <h1>Resources</h1>
    <ul id=""quickNa");
                WriteLiteral(@"v"">
      <li><a href=""resources/faq.htm"" title=""Our home page"">FAQ</a></li>
      <li><a href=""support.htm"" title=""Need help?"">Support</a></li>
      <li><a href=""resources/legal.htm"" title=""The fine print"">Legal</a></li><li><a href=""login.htm"">Login</a></li>
    </ul>
    <p>
      Copyright Jess Chadwick ");
                EndContext();
                BeginContext(5572, 17, false);
#line 119 "C:\Users\Ren\Documents\exploreCalifornia\Views\Shared\_Layout.cshtml"
                         Write(DateTime.Now.Year);

#line default
#line hidden
                EndContext();
                BeginContext(5589, 278, true);
                WriteLiteral(@"
    </p>
  </section>
  <section id=""companyInfo"">
  <h1>Contact</h1>
  <h2>Explore California</h2>
      <p>5605 Nota Street<br />
        Ventura, CA 93003</p>
      <p>866.555.4310<br />866.555.4315 <em>(24 hour support)</em></p>
  </section>
  </footer>
</div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5874, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
