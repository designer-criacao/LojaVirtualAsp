#pragma checksum "C:\Loja\Views\Produto\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d82a5ed6981c35e3afc94c4a55c9813000866a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Visualizar), @"mvc.1.0.view", @"/Views/Produto/Visualizar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Visualizar.cshtml", typeof(AspNetCore.Views_Produto_Visualizar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d82a5ed6981c35e3afc94c4a55c9813000866a6", @"/Views/Produto/Visualizar.cshtml")]
    public class Views_Produto_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Loja.Models.Produto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 55, true);
            WriteLiteral("\r\n<h3>Produto -> Visualizar</h3>\r\n;)\r\n<br />\r\nRazor: \r\n");
            EndContext();
#line 7 "C:\Loja\Views\Produto\Visualizar.cshtml"
  
    string nome = "Ivo Oliveira";

#line default
#line hidden
            BeginContext(125, 4, true);
            WriteLiteral("<h3>");
            EndContext();
            BeginContext(130, 4, false);
#line 10 "C:\Loja\Views\Produto\Visualizar.cshtml"
Write(nome);

#line default
#line hidden
            EndContext();
            BeginContext(134, 30, true);
            WriteLiteral("</h3>\r\n<br />\r\n<b>Código: </b>");
            EndContext();
            BeginContext(165, 8, false);
#line 12 "C:\Loja\Views\Produto\Visualizar.cshtml"
          Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(173, 22, true);
            WriteLiteral(" <br />\r\n<b>Nome: </b>");
            EndContext();
            BeginContext(196, 10, false);
#line 13 "C:\Loja\Views\Produto\Visualizar.cshtml"
        Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(206, 27, true);
            WriteLiteral(" <br />\r\n<b>Descricao: </b>");
            EndContext();
            BeginContext(234, 15, false);
#line 14 "C:\Loja\Views\Produto\Visualizar.cshtml"
             Write(Model.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(249, 23, true);
            WriteLiteral(" <br />\r\n<b>Valor: </b>");
            EndContext();
            BeginContext(273, 25, false);
#line 15 "C:\Loja\Views\Produto\Visualizar.cshtml"
         Write(Model.Valor.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(298, 55, true);
            WriteLiteral(" <br />\r\n\r\n<br />\r\nTodos os direitos reservados &copy; ");
            EndContext();
            BeginContext(354, 17, false);
#line 18 "C:\Loja\Views\Produto\Visualizar.cshtml"
                               Write(DateTime.Now.Year);

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Loja.Models.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
