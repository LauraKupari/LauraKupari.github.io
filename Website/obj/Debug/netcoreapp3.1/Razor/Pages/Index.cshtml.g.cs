#pragma checksum "C:\Users\musap\source\repos\Website\Website\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7db01649bff15e9d0b8ff0d30cb04cc9b0fe26d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Website.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Website.Pages
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
#line 1 "C:\Users\musap\source\repos\Website\Website\Pages\_ViewImports.cshtml"
using Website;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7db01649bff15e9d0b8ff0d30cb04cc9b0fe26d", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee1c14fae1ccc939e6a6f9651f4a0fa3267e60f8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\musap\source\repos\Website\Website\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">

    <div style=""display: flex; flex-direction:row; height: 350px"">
        <div style=""flex:1.3 1; text-align:left;"">
            <h2 class=""display-4"">Tervetuloa</h2>
            <p style=""word-break:break-word"">Olen Laura, 27-vuotias sosiaalipsykologian opiskelija Vantaalta. Perustin yrityksen voidakseni hyödyntää laajaa osaamista harrastusteni, työkokemukseni ja vapaaehtoistyöni pohjalta, 
            ja voidakseni työskennellä omaan tahtiini omana itsenäni. Aito energisyyteni ja iloni on tarttuvaa, ja teen kaiken mihin ryhdyn aina niin hyvin kuin vain osaan. Lue lisää 
            <a href=""/Tietoa_minusta"">minusta ja yrityksestäni</a>.
            </p>
        </div>
        <div class=""page-image"">
        </div>
    </div>

    <div>
        <div style=""text-align: left;"">
            <h3>Tarjoamani palvelut</h3>
            <ul>
                <li><h4><a");
            BeginWriteAttribute("href", " href=\"", 992, "\"", 999, 0);
            EndWriteAttribute();
            WriteLiteral(">LEMMIKKIKUVAUS</a></h4></li>\r\n                <li><h4><a");
            BeginWriteAttribute("href", " href=\"", 1057, "\"", 1064, 0);
            EndWriteAttribute();
            WriteLiteral(">LEMMIKKIEN HOITO, ULKOILUTUS JA KOULUTUS</a></h4></li>\r\n                <li><h4><a");
            BeginWriteAttribute("href", " href=\"", 1148, "\"", 1155, 0);
            EndWriteAttribute();
            WriteLiteral(">PERUSKOULUN JA LUKION TUKIOPETUS, PÄÄSYKOEVALMENNUS</a></h4></li>\r\n                <li><h4><a");
            BeginWriteAttribute("href", " href=\"", 1250, "\"", 1257, 0);
            EndWriteAttribute();
            WriteLiteral(@">TAPAHTUMAT</a></h4></li>
            </ul>
        </div>

        <div style=""text-align: left;"">
            <h3>Hinnoittelu</h3>

            <p>
                Palveluiden hinnat löytyvät jokaisen palvelun omalta sivulta, ja ne on hinnoiteltu joko tuntipalkkana tai projektipalkkana. Kaikkiin hintoihin sisältyy alv 24 %, sekä matkakulut pääkaupunkiseudulla. Matkakulut kauemmas ja mahdolliset päivärahat veloitetaan erikseen.
                Palveluiden hinnoittelun yhteydessä määritetään, mistä hinta koostuu.
            </p>
            <p>
                Maksaminen on mahdollista laskulla (14 päivää maksuaikaa, XX % viivästyskorko) tai käteisellä.
            </p>            
        </div>
        <div>
            <h3>
                Etkö löytänyt etsimääsi?
            </h3>
            <p>
                Tarvitsetko apua jossain, mitä ei sivuilla mainittu? <a href=""/Yhteys_tiedot"">OTA YHTEYTTÄ!</a>
            </p>
        </div>
    </div>

</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
