#pragma checksum "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoNovedadEmpleados\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b49046289e4f82115d3cd7a9e661caf66ed3338"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TipoNovedadEmpleados_Index), @"mvc.1.0.view", @"/Views/TipoNovedadEmpleados/Index.cshtml")]
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
#line 1 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\_ViewImports.cshtml"
using CreacionesPajov;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\_ViewImports.cshtml"
using CreacionesPajov.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b49046289e4f82115d3cd7a9e661caf66ed3338", @"/Views/TipoNovedadEmpleados/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0172f286af4f054d61d3ee661d6488a94b30c38", @"/Views/_ViewImports.cshtml")]
    public class Views_TipoNovedadEmpleados_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CreacionesPajov.WEB.Models.Entities.TipoNovedadEmpleado>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/tabla.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("<div class=\"content\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"table-responsive\">\r\n            <div class=\"contenedor-index\">\r\n            <div class=\"col-md-7\">\r\n                <h2>Gesti??n de <b> ");
#nullable restore
#line 10 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoNovedadEmpleados\Index.cshtml"
                              Write(ViewBag.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\r\n            </div>\r\n            <br />\r\n            <div class=\"col-md-7\">\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 433, "\"", 555, 5);
            WriteAttributeValue("", 443, "mostrarModal(\'", 443, 14, true);
#nullable restore
#line 14 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoNovedadEmpleados\Index.cshtml"
WriteAttributeValue("", 457, Url.Action("Crear","TipoNovedadEmpleados",null,Context.Request.Scheme), 457, 71, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 528, "\',\'Crear", 528, 8, true);
            WriteAttributeValue(" ", 536, "Novedad", 537, 8, true);
            WriteAttributeValue(" ", 544, "Empleado\')", 545, 11, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-emp\">Crear novedad empleado</a>\r\n            </div>\r\n            </div>\r\n\r\n");
#nullable restore
#line 18 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoNovedadEmpleados\Index.cshtml"
             if (Model.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n                <p>No existen Novedades De Empleado</p>\r\n");
#nullable restore
#line 22 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoNovedadEmpleados\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n                <div class=\"contenedor-tabla\">\r\n                <table class=\"table table-striped\" id=\"tabla\">\r\n                    <thead class=\"thead-dark\">\r\n                        <tr>\r\n                            <th>");
#nullable restore
#line 30 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoNovedadEmpleados\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.EmpleadoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 31 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoNovedadEmpleados\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                         \r\n                            <th>Acciones</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoNovedadEmpleados\Index.cshtml"
                         foreach (var tiponovedadempleado in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 40 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoNovedadEmpleados\Index.cshtml"
                               Write(tiponovedadempleado.Empleados.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 41 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoNovedadEmpleados\Index.cshtml"
                               Write(tiponovedadempleado.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                              \r\n\r\n                                <td>\r\n                                    <a class=\"text-success\"");
            BeginWriteAttribute("href", " href=\"", 1798, "\"", 1978, 5);
            WriteAttributeValue("", 1805, "javascript:mostrarModal(\'", 1805, 25, true);
#nullable restore
#line 46 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoNovedadEmpleados\Index.cshtml"
WriteAttributeValue("", 1830, Url.Action("Detalle","TipoNovedadEmpleados",new {id=tiponovedadempleado.TipoNovedadEmpleadoId},Context.Request.Scheme), 1830, 119, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1949, "\',\'Detalle", 1949, 10, true);
            WriteAttributeValue(" ", 1959, "novedad", 1960, 8, true);
            WriteAttributeValue(" ", 1967, "empleado\')", 1968, 11, true);
            EndWriteAttribute();
            WriteLiteral("> <i title=\"Detalle\" class=\"color-icono1 fa-solid fa-magnifying-glass-plus\"></i></a> |\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2105, "\"", 2283, 5);
            WriteAttributeValue("", 2112, "javascript:mostrarModal(\'", 2112, 25, true);
#nullable restore
#line 47 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoNovedadEmpleados\Index.cshtml"
WriteAttributeValue("", 2137, Url.Action("Editar","TipoNovedadEmpleados",new {id=tiponovedadempleado.TipoNovedadEmpleadoId},Context.Request.Scheme), 2137, 118, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2255, "\',\'Editar", 2255, 9, true);
            WriteAttributeValue(" ", 2264, "novedad", 2265, 8, true);
            WriteAttributeValue(" ", 2272, "empleado\')", 2273, 11, true);
            EndWriteAttribute();
            WriteLiteral("><i title=\"Editar\" class=\"color-icono2 fa-solid fa-user-pen\"></i>|</a>\r\n                                    \r\n\r\n\r\n\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 54 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoNovedadEmpleados\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                    </div>\r\n");
#nullable restore
#line 59 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoNovedadEmpleados\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b49046289e4f82115d3cd7a9e661caf66ed333810667", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <script>\r\n");
#nullable restore
#line 73 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoNovedadEmpleados\Index.cshtml"
        if (TempData["Accion"]!=null && TempData["Accion"].ToString().Equals("Guardar"))
       {
          

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            alertify.set(\'notifier\',\'position\',\'top-right\');\r\n            alertify.notify(\'");
#nullable restore
#line 77 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoNovedadEmpleados\Index.cshtml"
                        Write(TempData["Mansaje"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \', \'success\', 5, function( ) {\r\n\r\n            });\r\n          ");
#nullable restore
#line 80 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoNovedadEmpleados\Index.cshtml"
                 
       }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </script>\r\n\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CreacionesPajov.WEB.Models.Entities.TipoNovedadEmpleado>> Html { get; private set; }
    }
}
#pragma warning restore 1591
