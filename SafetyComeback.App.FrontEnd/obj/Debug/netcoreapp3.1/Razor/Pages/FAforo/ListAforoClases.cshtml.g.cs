#pragma checksum "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2b2580d478b7d0f9a28279befefe59b4b664330"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SafetyComeback.App.FrontEnd.Pages.FAforo.Pages_FAforo_ListAforoClases), @"mvc.1.0.razor-page", @"/Pages/FAforo/ListAforoClases.cshtml")]
namespace SafetyComeback.App.FrontEnd.Pages.FAforo
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
#line 1 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\_ViewImports.cshtml"
using SafetyComeback.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2b2580d478b7d0f9a28279befefe59b4b664330", @"/Pages/FAforo/ListAforoClases.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9504b98970e990b7b1a48cbfa4217c35add9489", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FAforo_ListAforoClases : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./CreateAforoClase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditAforoClase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DeleteAforoClase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DetailsAforoClase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
  
    ViewData["Title"] = "ListadoClase";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n");
#nullable restore
#line 7 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
     if (TempData["mensaje"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning alert-dimissible fade show\" role=\"alert\">\r\n            ");
#nullable restore
#line 10 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
       Write(TempData["mensaje"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button type=\"button\" class=\"close\" date-dismiss=\"alert\" aria-label=\"close\" >\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n        </div>\r\n");
#nullable restore
#line 15 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-sm-6\">\r\n            <h5>Control asistencia Salon: ");
#nullable restore
#line 18 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
                                     Write(Model.act_clase.Salon.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5>Programa: ");
#nullable restore
#line 19 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
                     Write(Model.act_clase.Programa.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5>Fecha: ");
#nullable restore
#line 20 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
                   Write(String.Format("{0:dd/MM/yyyy}",@Model.act_clase.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Hora: ");
#nullable restore
#line 20 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
                                                                                   Write(String.Format("{0:hh:mm tt}",@Model.act_clase.Hora));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5>Aforo máximo permitido:");
#nullable restore
#line 21 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
                                  Write(Model.act_clase.Salon.Aforo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n        </div>\r\n");
#nullable restore
#line 23 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
         if (Model.listAforoClases.Count()<@Model.act_clase.Salon.Aforo)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-6\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2b2580d478b7d0f9a28279befefe59b4b6643309112", async() => {
                WriteLiteral("Crear");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-claseId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
                                                      WriteLiteral(Model.identificador_clase);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["claseId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-claseId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["claseId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 28 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-sm-6\">\r\n            <p class=\"btn btn-danger d-block\" >Aforo completo</p>\r\n            </div>\r\n");
#nullable restore
#line 34 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 37 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
         if (Model.listAforoClases.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-bordered table-striped"">

                <thead>
                    <tr>
                        <td>Id</td>
                        <td>Identificación</td>
                        <td>Nombre</td>
                        <td>Resultado COVID</td>
                        <td>Acciones</td>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 51 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
                     foreach (var asistente in Model.listAforoClases)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 54 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
                           Write(asistente.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 55 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
                           Write(asistente.Persona.Identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 56 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
                           Write(asistente.Persona.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 56 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
                                                      Write(asistente.Persona.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 57 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
                           Write(asistente.Persona.Estado_COVID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2b2580d478b7d0f9a28279befefe59b4b66433014756", async() => {
                WriteLiteral("\r\n                                    <i class=\"fas fa-address-book fa-lg\" aria-hidden=\"true\"></i>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-aforoClaseId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
                                            WriteLiteral(asistente.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["aforoClaseId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-aforoClaseId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["aforoClaseId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2b2580d478b7d0f9a28279befefe59b4b66433017221", async() => {
                WriteLiteral("\r\n                                    <i class=\"fas fa-address-book fa-lg\" aria-hidden=\"true\"></i>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-aforoClaseId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
                                            WriteLiteral(asistente.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["aforoClaseId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-aforoClaseId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["aforoClaseId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2b2580d478b7d0f9a28279befefe59b4b66433019686", async() => {
                WriteLiteral("\r\n                                    <i class=\"fas fa-info-circle fa-lg\" aria-hidden=\"true\"></i>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-aforoClaseId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
                                        WriteLiteral(asistente.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["aforoClaseId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-aforoClaseId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["aforoClaseId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 73 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n\r\n            </table>\r\n");
#nullable restore
#line 77 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No existen asistentes</p>\r\n");
#nullable restore
#line 81 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5>Total asistentes: ");
#nullable restore
#line 82 "C:\work\proyectoDW\SafetyComeback.App\SafetyComeback.App.FrontEnd\Pages\FAforo\ListAforoClases.cshtml"
                         Write(Model.listAforoClases.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SafetyComeback.App.FrontEnd.Pages.FAforo.ListAforoClasesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SafetyComeback.App.FrontEnd.Pages.FAforo.ListAforoClasesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SafetyComeback.App.FrontEnd.Pages.FAforo.ListAforoClasesModel>)PageContext?.ViewData;
        public SafetyComeback.App.FrontEnd.Pages.FAforo.ListAforoClasesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591