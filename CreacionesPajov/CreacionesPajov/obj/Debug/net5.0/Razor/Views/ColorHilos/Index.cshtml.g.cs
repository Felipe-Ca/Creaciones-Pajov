#pragma checksum "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77e9484aff3dce803a20812bbc0aac1335a97469"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ColorHilos_Index), @"mvc.1.0.view", @"/Views/ColorHilos/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77e9484aff3dce803a20812bbc0aac1335a97469", @"/Views/ColorHilos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0172f286af4f054d61d3ee661d6488a94b30c38", @"/Views/_ViewImports.cshtml")]
    public class Views_ColorHilos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CreacionesPajov.WEB.Models.Entities.ColorHilo>>
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
                WriteLiteral("\r\n\r\n    ");
            }
            );
            WriteLiteral("\r\n    <div class=\"content\">\r\n        <div class=\"container-fluid\">\r\n            <div class=\"table-responsive\">\r\n                <div class=\"contenedor-index\">\r\n                    <div class=\"col-md-7\">\r\n                        <h2>Gesti??n de <b> ");
#nullable restore
#line 11 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"
                                      Write(ViewBag.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\r\n                    </div>\r\n                    <br />\r\n                    <div class=\"col-md-7\">\r\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 497, "\"", 606, 6);
            WriteAttributeValue("", 507, "mostrarModal(\'", 507, 14, true);
#nullable restore
#line 15 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"
WriteAttributeValue("", 521, Url.Action("Crear","ColorHilos",null,Context.Request.Scheme), 521, 61, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 582, "\',\'Crear", 582, 8, true);
            WriteAttributeValue(" ", 590, "Color", 591, 6, true);
            WriteAttributeValue(" ", 596, "De", 597, 3, true);
            WriteAttributeValue(" ", 599, "Hilo\')", 600, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-emp\">Crear Color De Hilo</a>\r\n                    </div>\r\n                </div>\r\n\r\n");
#nullable restore
#line 19 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"
                 if (Model.Count() == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <br />\r\n                    <p>No existen Colores De Hilo</p>\r\n");
#nullable restore
#line 23 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"
                    
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <br />
                    <div class=""contenedor-tabla"">
                        <table class=""table table-striped"" id=""tabla"">
                            <thead class=""thead-dark"">
                                <tr>
                                    <th>");
#nullable restore
#line 32 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th>");
#nullable restore
#line 33 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th>Acciones</th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"
                                 foreach (var ColorHilo in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 41 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"
                                       Write(ColorHilo.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"
                                         if (ColorHilo.Estado)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td><span class=\"badge badge-act\">Habilitado</span></td>\r\n");
#nullable restore
#line 47 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td><span class=\"badge badge-desc\">Deshabilitado</span></td>\r\n");
#nullable restore
#line 51 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                        <td>\r\n                                            <a class=\"text-success\"");
            BeginWriteAttribute("href", " href=\"", 2421, "\"", 2565, 5);
            WriteAttributeValue("", 2428, "javascript:mostrarModal(\'", 2428, 25, true);
#nullable restore
#line 55 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"
WriteAttributeValue("", 2453, Url.Action("Detalle","ColorHilos",new {id=ColorHilo.ColorHiloId},Context.Request.Scheme), 2453, 89, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2542, "\',\'Detalle", 2542, 10, true);
            WriteAttributeValue(" ", 2552, "Color", 2553, 6, true);
            WriteAttributeValue(" ", 2558, "Hilo\')", 2559, 7, true);
            EndWriteAttribute();
            WriteLiteral("> <i title=\"Detalle\" class=\"color-icono1 fa-solid fa-magnifying-glass-plus\"></i></a> |\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2700, "\"", 2842, 5);
            WriteAttributeValue("", 2707, "javascript:mostrarModal(\'", 2707, 25, true);
#nullable restore
#line 56 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"
WriteAttributeValue("", 2732, Url.Action("Editar","ColorHilos",new {id=ColorHilo.ColorHiloId},Context.Request.Scheme), 2732, 88, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2820, "\',\'Editar", 2820, 9, true);
            WriteAttributeValue(" ", 2829, "Color", 2830, 6, true);
            WriteAttributeValue(" ", 2835, "Hilo\')", 2836, 7, true);
            EndWriteAttribute();
            WriteLiteral("><i title=\"Editarr\" class=\"color-icono2 fa-solid fa-user-pen\"></i>|</a>\r\n");
#nullable restore
#line 57 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"
                                             if (ColorHilo.Estado)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <a class=\"text-success\"");
            BeginWriteAttribute("href", " href=\"", 3102, "\"", 3232, 3);
            WriteAttributeValue("", 3109, "javascript:cambiarEstado(\'", 3109, 26, true);
#nullable restore
#line 59 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"
WriteAttributeValue("", 3135, Url.Action("CambiarEstado","ColorHilos",new {id=ColorHilo.ColorHiloId},Context.Request.Scheme), 3135, 95, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3230, "\')", 3230, 2, true);
            EndWriteAttribute();
            WriteLiteral("> <i title=\"Deshabilitar\" class=\"color-icono1 fa-solid fa-toggle-on\"></i></a>\r\n");
#nullable restore
#line 60 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <a class=\"text-secondary\"");
            BeginWriteAttribute("href", " href=\"", 3529, "\"", 3659, 3);
            WriteAttributeValue("", 3536, "javascript:cambiarEstado(\'", 3536, 26, true);
#nullable restore
#line 63 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"
WriteAttributeValue("", 3562, Url.Action("CambiarEstado","ColorHilos",new {id=ColorHilo.ColorHiloId},Context.Request.Scheme), 3562, 95, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3657, "\')", 3657, 2, true);
            EndWriteAttribute();
            WriteLiteral("> <i title=\"Habilitar\" class=\"color-icono2 fa-solid fa-toggle-off\"></i></a>\r\n");
#nullable restore
#line 64 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"

                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 71 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
#nullable restore
#line 76 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77e9484aff3dce803a20812bbc0aac1335a9746913908", async() => {
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
                WriteLiteral("\r\n\r\n        <script>\r\n");
#nullable restore
#line 87 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"
        if (TempData["Accion"]!=null && TempData["Accion"].ToString().Equals("Guardar"))
       {
          

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            alertify.set(\'notifier\',\'position\',\'top-right\');\r\n            alertify.notify(\'");
#nullable restore
#line 91 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"
                        Write(TempData["Mansaje"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \', \'success\', 5, function( ) {\r\n\r\n            });\r\n          ");
#nullable restore
#line 94 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorHilos\Index.cshtml"
                 
       }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </script>\r\n\r\n\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CreacionesPajov.WEB.Models.Entities.ColorHilo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
