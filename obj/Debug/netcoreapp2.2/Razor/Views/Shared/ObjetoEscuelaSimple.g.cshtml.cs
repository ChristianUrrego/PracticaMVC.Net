#pragma checksum "D:\Cursos\ASP.NET_Core_MVC\Views\Shared\ObjetoEscuelaSimple.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc550b81c25355f7d32258de11881a54e0d08e97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ObjetoEscuelaSimple), @"mvc.1.0.view", @"/Views/Shared/ObjetoEscuelaSimple.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ObjetoEscuelaSimple.cshtml", typeof(AspNetCore.Views_Shared_ObjetoEscuelaSimple))]
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
#line 1 "D:\Cursos\ASP.NET_Core_MVC\Views\_ViewImports.cshtml"
using ASP.NET_Core_MVC;

#line default
#line hidden
#line 2 "D:\Cursos\ASP.NET_Core_MVC\Views\_ViewImports.cshtml"
using ASP.NET_Core_MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc550b81c25355f7d32258de11881a54e0d08e97", @"/Views/Shared/ObjetoEscuelaSimple.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7efaf91dce81bddc7014c380b11138873f87db74", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ObjetoEscuelaSimple : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ObjetoEscuelaBase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 17, true);
            WriteLiteral("<p>\r\n    Nombre: ");
            EndContext();
            BeginContext(45, 12, false);
#line 3 "D:\Cursos\ASP.NET_Core_MVC\Views\Shared\ObjetoEscuelaSimple.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(57, 16, true);
            WriteLiteral(" <br/>\r\n    Id: ");
            EndContext();
            BeginContext(74, 8, false);
#line 4 "D:\Cursos\ASP.NET_Core_MVC\Views\Shared\ObjetoEscuelaSimple.cshtml"
   Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(82, 6, true);
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ObjetoEscuelaBase> Html { get; private set; }
    }
}
#pragma warning restore 1591
