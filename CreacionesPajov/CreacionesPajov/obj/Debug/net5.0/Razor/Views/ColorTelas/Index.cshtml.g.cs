#pragma checksum "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e58c0436dcc2a293df589db720a40546aad6c657"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ColorTelas_Index), @"mvc.1.0.view", @"/Views/ColorTelas/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e58c0436dcc2a293df589db720a40546aad6c657", @"/Views/ColorTelas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0172f286af4f054d61d3ee661d6488a94b30c38", @"/Views/_ViewImports.cshtml")]
    public class Views_ColorTelas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CreacionesPajov.WEB.Models.Entities.ColorTela>>
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
            WriteLiteral("\r\n<div class=\"content\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"table-responsive\">\r\n            <div class=\"contenedor-index\">\r\n            <div class=\"col-md-7\">\r\n                <h2>Gestión de <b> ");
#nullable restore
#line 11 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"
                              Write(ViewBag.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\r\n            </div>\r\n            <br />\r\n            <div class=\"col-md-7\">\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 425, "\"", 535, 6);
            WriteAttributeValue("", 435, "mostrarModal(\'", 435, 14, true);
#nullable restore
#line 15 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"
WriteAttributeValue("", 449, Url.Action("Crear","ColorTelas",null,Context.Request.Scheme), 449, 61, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 510, "\',\'Crear", 510, 8, true);
            WriteAttributeValue(" ", 518, "Color", 519, 6, true);
            WriteAttributeValue(" ", 524, "De", 525, 3, true);
            WriteAttributeValue(" ", 527, "Telas\')", 528, 8, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-emp\">Crear Color De Tela</a>\r\n            </div>\r\n            </div>\r\n\r\n");
#nullable restore
#line 19 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"
             if (Model.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br>\r\n                <p>No existen Colores De Tela</p>\r\n");
#nullable restore
#line 23 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n            <div class=\"contenedor-tabla\">\r\n                <table class=\"table table-striped\" id=\"tabla\">\r\n                    <thead class=\"thead-dark\">\r\n                        <tr>\r\n                            <th>");
#nullable restore
#line 31 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 32 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>Acciones</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"
                         foreach (var ColorTela in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 40 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"
                               Write(ColorTela.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"
                                 if (ColorTela.Estado)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><span class=\"badge badge-act\">Habilitado</span></td>\r\n");
#nullable restore
#line 46 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><span class=\"badge badge-desc\">Deshabilitado</span></td>\r\n");
#nullable restore
#line 50 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <td>\r\n                                    <a class=\"text-success\"");
            BeginWriteAttribute("href", " href=\"", 2080, "\"", 2224, 5);
            WriteAttributeValue("", 2087, "javascript:mostrarModal(\'", 2087, 25, true);
#nullable restore
#line 53 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"
WriteAttributeValue("", 2112, Url.Action("Detalle","ColorTelas",new {id=ColorTela.ColorTelaId},Context.Request.Scheme), 2112, 89, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2201, "\',\'Detalle", 2201, 10, true);
            WriteAttributeValue(" ", 2211, "Color", 2212, 6, true);
            WriteAttributeValue(" ", 2217, "Tela\')", 2218, 7, true);
            EndWriteAttribute();
            WriteLiteral("><i title=\"Detalle\" class=\"color-icono1 fa-solid fa-magnifying-glass-plus\"></i></a> |\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2350, "\"", 2492, 5);
            WriteAttributeValue("", 2357, "javascript:mostrarModal(\'", 2357, 25, true);
#nullable restore
#line 54 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"
WriteAttributeValue("", 2382, Url.Action("Editar","ColorTelas",new {id=ColorTela.ColorTelaId},Context.Request.Scheme), 2382, 88, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2470, "\',\'Editar", 2470, 9, true);
            WriteAttributeValue(" ", 2479, "Color", 2480, 6, true);
            WriteAttributeValue(" ", 2485, "Tela\')", 2486, 7, true);
            EndWriteAttribute();
            WriteLiteral("><i title=\"Editarr\" class=\"color-icono2 fa-solid fa-user-pen\"></i>|</a>\r\n");
#nullable restore
#line 55 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"
                                     if (ColorTela.Estado)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"text-success\"");
            BeginWriteAttribute("href", " href=\"", 2728, "\"", 2858, 3);
            WriteAttributeValue("", 2735, "javascript:cambiarEstado(\'", 2735, 26, true);
#nullable restore
#line 57 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"
WriteAttributeValue("", 2761, Url.Action("CambiarEstado","ColorTelas",new {id=ColorTela.ColorTelaId},Context.Request.Scheme), 2761, 95, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2856, "\')", 2856, 2, true);
            EndWriteAttribute();
            WriteLiteral("> <i title=\"Deshabilitar\" class=\"color-icono1 fa-solid fa-toggle-on\"></i></a>\r\n");
#nullable restore
#line 58 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"text-secondary\"");
            BeginWriteAttribute("href", " href=\"", 3123, "\"", 3253, 3);
            WriteAttributeValue("", 3130, "javascript:cambiarEstado(\'", 3130, 26, true);
#nullable restore
#line 61 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"
WriteAttributeValue("", 3156, Url.Action("CambiarEstado","ColorTelas",new {id=ColorTela.ColorTelaId},Context.Request.Scheme), 3156, 95, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3251, "\')", 3251, 2, true);
            EndWriteAttribute();
            WriteLiteral("> <i title=\"Habilitar\" class=\"color-icono1 fa-solid fa-toggle-off\"></i></a>\r\n");
#nullable restore
#line 62 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 69 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                </div>\r\n");
#nullable restore
#line 74 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e58c0436dcc2a293df589db720a40546aad6c65713417", async() => {
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
#line 85 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"
        if (TempData["Accion"]!=null && TempData["Accion"].ToString().Equals("Guardar"))
       {
          

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            alertify.set(\'notifier\',\'position\',\'top-right\');\r\n            alertify.notify(\'");
#nullable restore
#line 89 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"
                        Write(TempData["Mansaje"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \', \'success\', 5, function( ) {\r\n\r\n            });\r\n          ");
#nullable restore
#line 92 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ColorTelas\Index.cshtml"
                 
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CreacionesPajov.WEB.Models.Entities.ColorTela>> Html { get; private set; }
    }
}
#pragma warning restore 1591
