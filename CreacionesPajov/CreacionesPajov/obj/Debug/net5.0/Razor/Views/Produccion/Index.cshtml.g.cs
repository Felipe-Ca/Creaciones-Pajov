#pragma checksum "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "540586c1f0a9f3d155ec851161e7b1c1e80b281e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produccion_Index), @"mvc.1.0.view", @"/Views/Produccion/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"540586c1f0a9f3d155ec851161e7b1c1e80b281e", @"/Views/Produccion/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0172f286af4f054d61d3ee661d6488a94b30c38", @"/Views/_ViewImports.cshtml")]
    public class Views_Produccion_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CreacionesPajov.WEB.Models.Entities.Produccion>>
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
            WriteLiteral("\r\n<div class=\"content\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"table-responsive\">\r\n            <div class=\"contenedor-index\">\r\n                <div class=\"col-md-7\">\r\n                    <h2>Gestión de <b> ");
#nullable restore
#line 8 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
                                  Write(ViewBag.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\r\n                </div>\r\n                <br />\r\n                <div class=\"col-md-7\">\r\n                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 427, "\"", 533, 4);
            WriteAttributeValue("", 437, "mostrarModal(\'", 437, 14, true);
#nullable restore
#line 12 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
WriteAttributeValue("", 451, Url.Action("Crear","Produccion",null,Context.Request.Scheme), 451, 61, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 512, "\',\'Crear", 512, 8, true);
            WriteAttributeValue(" ", 520, "producción\')", 521, 13, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-emp\">Crear Producción</a>\r\n                </div>\r\n            </div>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
             if (Model.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n                <p>No existen Producciones</p>\r\n");
#nullable restore
#line 20 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <br />
                <div class=""contenedor-tabla"">
                    <table class=""table table-striped"" id=""tabla"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th>");
#nullable restore
#line 29 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 30 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 31 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 32 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Fases));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
            WriteLiteral("                                <th>");
#nullable restore
#line 34 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
            WriteLiteral("                                <th>Acciones</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
                             foreach (var Produccion in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 43 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
                               Write(Produccion.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 44 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
                               Write(Produccion.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <th>");
#nullable restore
#line 45 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
                               Write(Produccion.FechaRegistro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 46 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
                               Write(Produccion.Fases.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
                                 if (Produccion.Estado)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><span class=\"badge badge-act\">Habilitado</span></td>\r\n");
#nullable restore
#line 56 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><span class=\"badge badge-desc\">Deshabilitado</span></td>\r\n");
#nullable restore
#line 60 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <td>\r\n                                    <a class=\"text-success\"");
            BeginWriteAttribute("href", " href=\"", 2934, "\"", 3080, 4);
            WriteAttributeValue("", 2941, "javascript:mostrarModal(\'", 2941, 25, true);
#nullable restore
#line 64 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
WriteAttributeValue("", 2966, Url.Action("Detalle","Produccion",new {id=Produccion.ProduccionId},Context.Request.Scheme), 2966, 91, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3057, "\',\'Detalle", 3057, 10, true);
            WriteAttributeValue(" ", 3067, "Producción\')", 3068, 13, true);
            EndWriteAttribute();
            WriteLiteral("> <i title=\"Detalle\" class=\"color-icono1 fa-solid fa-magnifying-glass-plus\"></i></a> |\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3207, "\"", 3351, 4);
            WriteAttributeValue("", 3214, "javascript:mostrarModal(\'", 3214, 25, true);
#nullable restore
#line 65 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
WriteAttributeValue("", 3239, Url.Action("Editar","Produccion",new {id=Produccion.ProduccionId},Context.Request.Scheme), 3239, 90, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3329, "\',\'Editar", 3329, 9, true);
            WriteAttributeValue(" ", 3338, "Producción\')", 3339, 13, true);
            EndWriteAttribute();
            WriteLiteral("><i title=\"Editar\" class=\"color-icono2 fa-solid fa-user-pen\"></i>|</a>\r\n");
#nullable restore
#line 66 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
                                     if (Produccion.Estado)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"text-success\"");
            BeginWriteAttribute("href", " href=\"", 3587, "\"", 3719, 3);
            WriteAttributeValue("", 3594, "javascript:cambiarEstado(\'", 3594, 26, true);
#nullable restore
#line 68 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
WriteAttributeValue("", 3620, Url.Action("CambiarEstado","Produccion",new {id=Produccion.ProduccionId},Context.Request.Scheme), 3620, 97, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3717, "\')", 3717, 2, true);
            EndWriteAttribute();
            WriteLiteral("> <i title=\"Deshabilitar\" class=\"color-icono1 fa-solid fa-toggle-on\"></i></a>\r\n");
#nullable restore
#line 69 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"text-secondary\"");
            BeginWriteAttribute("href", " href=\"", 3984, "\"", 4116, 3);
            WriteAttributeValue("", 3991, "javascript:cambiarEstado(\'", 3991, 26, true);
#nullable restore
#line 72 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
WriteAttributeValue("", 4017, Url.Action("CambiarEstado","Produccion",new {id=Produccion.ProduccionId},Context.Request.Scheme), 4017, 97, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4114, "\')", 4114, 2, true);
            EndWriteAttribute();
            WriteLiteral("> <i title=\"Habilitar\" class=\"color-icono2 fa-solid fa-toggle-off\"></i></a>\r\n");
#nullable restore
#line 73 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 81 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n");
#nullable restore
#line 86 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "540586c1f0a9f3d155ec851161e7b1c1e80b281e15182", async() => {
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
#line 97 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
        if (TempData["Accion"]!=null && TempData["Accion"].ToString().Equals("Guardar"))
       {
          

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            alertify.set(\'notifier\',\'position\',\'top-right\');\r\n            alertify.notify(\'");
#nullable restore
#line 101 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
                        Write(TempData["Mansaje"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \', \'success\', 5, function( ) {\r\n\r\n            });\r\n          ");
#nullable restore
#line 104 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\Produccion\Index.cshtml"
                 
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CreacionesPajov.WEB.Models.Entities.Produccion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
