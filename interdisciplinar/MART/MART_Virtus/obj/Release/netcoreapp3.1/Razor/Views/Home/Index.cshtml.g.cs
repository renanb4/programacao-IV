#pragma checksum "C:\Users\augus\OneDrive\Documentos\Trabalhos\Mart-Projeto\Mart-Projeto\MART\MART_Virtus\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67d3a3d83f94103b54e16e05dc119e43ec92d486"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\augus\OneDrive\Documentos\Trabalhos\Mart-Projeto\Mart-Projeto\MART\MART_Virtus\Views\_ViewImports.cshtml"
using MART_Virtus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\augus\OneDrive\Documentos\Trabalhos\Mart-Projeto\Mart-Projeto\MART\MART_Virtus\Views\_ViewImports.cshtml"
using MART_Virtus.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67d3a3d83f94103b54e16e05dc119e43ec92d486", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"160a5c13d25b6ffee6aeebce3f0086c2f6522321", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\augus\OneDrive\Documentos\Trabalhos\Mart-Projeto\Mart-Projeto\MART\MART_Virtus\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""Titulo"">
    <h1 class=""display-4"">MART</h1>
    <p>Sistemas para automação comercial.</p>
</div>

<div id=""HCarrosel"" class=""container"">

    <div id=""meu_slideshow"" class=""carousel slide carousel-fade"" data-ride=""carousel"">

        <ol class=""carousel-indicators"">
            <li data-target=""#meu_slideshow"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#meu_slideshow"" data-slide-to=""1""></li>

        </ol>

        <div class=""carousel-inner"">

            <div class=""carousel-item active"">
                <img src=""css/Code1.png"" alt=""imag1"" style=""max-height: 550px;"">
                <div class=""carousel-caption d-none d-md-block"">
                    <h5>Códigos seguros e otimizados!</h5>
                    <p>Com nossos códigos você pôde otimizar suas funções e ficar tranquilo</p>
                </div>
            </div>


            <div class=""carousel-item"">
                <img src=""css/Code2.png"" alt=""imag2"" style=""max-height: 550px;""");
            WriteLiteral(@">
                <div class=""carousel-caption d-none d-md-block"">
                    <h5>Contrate nosso serviço de suporte avançado!</h5>
                    <p>Nosso serviço de suporte avançado oferece suporte 24 horas por dia!</p>
                </div>
            </div>



        </div>

        <a class=""carousel-control-prev"" href=""#meu_slideshow"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon""></span>
            <span class=""sr-only"">Anterior</span>
        </a>

        <a class=""carousel-control-next"" href=""#meu_slideshow"" data-slide=""next"">
            <span class=""carousel-control-next-icon""></span>
            <span class=""sr-only"">Posterior</span>

        </a>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
