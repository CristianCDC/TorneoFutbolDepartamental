#pragma checksum "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Partidos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7179f12b2e125e311d6c697dd1088e0ae3aaa724"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TorneoFutbolDepartamental.App.Frontend.Pages.Partidos.Pages_Partidos_Index), @"mvc.1.0.razor-page", @"/Pages/Partidos/Index.cshtml")]
namespace TorneoFutbolDepartamental.App.Frontend.Pages.Partidos
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
#line 1 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\_ViewImports.cshtml"
using TorneoFutbolDepartamental.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7179f12b2e125e311d6c697dd1088e0ae3aaa724", @"/Pages/Partidos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1aa7bef0b60a3efe64c692168ebb6dccf9c9dcd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Partidos_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Listado de Partidos</h1>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">FechaHora</th>
            <th scope=""col"">Marcador</th>
            <th scope=""col"">Arbitro</th>
            <th scope=""col"">EquipoLocal</th>
            <th scope=""col"">EquipoVisitante</th>
            <th scope=""col"">Estadio</th>
            <th scope=""col"">Acciones</th>
        </tr>   
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Partidos\Index.cshtml"
         foreach (var partido in Model.partidos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Partidos\Index.cshtml"
               Write(partido.FechaHora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Partidos\Index.cshtml"
               Write(partido.Marcador);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Partidos\Index.cshtml"
               Write(partido.Arbitro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Partidos\Index.cshtml"
               Write(partido.EquipoLocal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Partidos\Index.cshtml"
               Write(partido.EquipoVisitante);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Partidos\Index.cshtml"
               Write(partido.Estadio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7179f12b2e125e311d6c697dd1088e0ae3aaa7246773", async() => {
                WriteLiteral("Detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Partidoid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Partidos\Index.cshtml"
                                                                             WriteLiteral(partido.PartidoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Partidoid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Partidoid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Partidoid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Partidos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TorneoFutbolDepartamental.App.Frontend.pages.Partidos.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbolDepartamental.App.Frontend.pages.Partidos.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbolDepartamental.App.Frontend.pages.Partidos.IndexModel>)PageContext?.ViewData;
        public TorneoFutbolDepartamental.App.Frontend.pages.Partidos.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
