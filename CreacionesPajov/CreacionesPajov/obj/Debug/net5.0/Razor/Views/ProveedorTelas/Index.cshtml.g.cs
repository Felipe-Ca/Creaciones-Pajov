#pragma checksum "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1616fa671b788ff9450a796a37aeef0e26ce30d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProveedorTelas_Index), @"mvc.1.0.view", @"/Views/ProveedorTelas/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1616fa671b788ff9450a796a37aeef0e26ce30d", @"/Views/ProveedorTelas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0172f286af4f054d61d3ee661d6488a94b30c38", @"/Views/_ViewImports.cshtml")]
    public class Views_ProveedorTelas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CreacionesPajov.WEB.Models.Entities.ProveedorTela>>
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
            WriteLiteral("<div class=\"content\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"table-responsive\">\r\n            <div class=\"contenedor-index\"> \r\n            <div class=\"col-md-7\">\r\n                <h2>Gestión de <b> ");
#nullable restore
#line 10 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
                              Write(ViewBag.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\r\n            </div>\r\n            <br />\r\n            <div class=\"col-md-7\">\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 432, "\"", 546, 5);
            WriteAttributeValue("", 442, "mostrarModal(\'", 442, 14, true);
#nullable restore
#line 14 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
WriteAttributeValue("", 456, Url.Action("Crear","ProveedorTelas",null,Context.Request.Scheme), 456, 65, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 521, "\',\'Crear", 521, 8, true);
            WriteAttributeValue(" ", 529, "proveedor", 530, 10, true);
            WriteAttributeValue(" ", 539, "tela\')", 540, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-emp\">Crear proveedor tela</a>\r\n            </div>\r\n            </div>\r\n\r\n");
#nullable restore
#line 18 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
             if (Model.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n                <p>No existen Proveedores De Tela</p>\r\n");
#nullable restore
#line 22 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n                <div class=\"contenedor-index\">\r\n                <table class=\"table table-striped\" id=\"tabla\">\r\n                    <thead class=\"thead-dark\">\r\n                        <tr>\r\n                            <th>");
#nullable restore
#line 30 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.NIT));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 31 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 32 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 33 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 34 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 35 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>Acciones</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
                         foreach (var proveedortela in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 43 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
                               Write(proveedortela.NIT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 44 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
                               Write(proveedortela.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
                               Write(proveedortela.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 46 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
                               Write(proveedortela.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 47 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
                               Write(proveedortela.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
                                 if (proveedortela.Estado)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><span class=\"badge badge-act\">Habilitado</span></td>\r\n");
#nullable restore
#line 53 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><span class=\"badge badge-desc\">Deshabilitado</span></td>\r\n");
#nullable restore
#line 57 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <td>\r\n                                    <a class=\"text-success\"");
            BeginWriteAttribute("href", " href=\"", 2704, "\"", 2864, 5);
            WriteAttributeValue("", 2711, "javascript:mostrarModal(\'", 2711, 25, true);
#nullable restore
#line 60 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
WriteAttributeValue("", 2736, Url.Action("Detalle","ProveedorTelas",new {id=proveedortela.ProveedorTelaId},Context.Request.Scheme), 2736, 101, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2837, "\',\'Detalle", 2837, 10, true);
            WriteAttributeValue(" ", 2847, "proveedor", 2848, 10, true);
            WriteAttributeValue(" ", 2857, "tela\')", 2858, 7, true);
            EndWriteAttribute();
            WriteLiteral("> <i title=\"Detalle\" class=\"color-icono1 fa-solid fa-magnifying-glass-plus\"></i></a> |\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2991, "\"", 3149, 5);
            WriteAttributeValue("", 2998, "javascript:mostrarModal(\'", 2998, 25, true);
#nullable restore
#line 61 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
WriteAttributeValue("", 3023, Url.Action("Editar","ProveedorTelas",new {id=proveedortela.ProveedorTelaId},Context.Request.Scheme), 3023, 100, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3123, "\',\'Editar", 3123, 9, true);
            WriteAttributeValue(" ", 3132, "proveedor", 3133, 10, true);
            WriteAttributeValue(" ", 3142, "tela\')", 3143, 7, true);
            EndWriteAttribute();
            WriteLiteral("><i title=\"Editar\" class=\"color-icono2 fa-solid fa-user-pen\"></i>|</a>\r\n");
#nullable restore
#line 62 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
                                     if (proveedortela.Estado)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"text-success\"");
            BeginWriteAttribute("href", " href=\"", 3388, "\"", 3530, 3);
            WriteAttributeValue("", 3395, "javascript:cambiarEstado(\'", 3395, 26, true);
#nullable restore
#line 64 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
WriteAttributeValue("", 3421, Url.Action("CambiarEstado","ProveedorTelas",new {id=proveedortela.ProveedorTelaId},Context.Request.Scheme), 3421, 107, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3528, "\')", 3528, 2, true);
            EndWriteAttribute();
            WriteLiteral("> <i title=\"Deshabilitar\" class=\"color-icono1 fa-solid fa-toggle-on\"></i></a>\r\n");
#nullable restore
#line 65 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"text-secondary\"");
            BeginWriteAttribute("href", " href=\"", 3795, "\"", 3937, 3);
            WriteAttributeValue("", 3802, "javascript:cambiarEstado(\'", 3802, 26, true);
#nullable restore
#line 68 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
WriteAttributeValue("", 3828, Url.Action("CambiarEstado","ProveedorTelas",new {id=proveedortela.ProveedorTelaId},Context.Request.Scheme), 3828, 107, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3935, "\')", 3935, 2, true);
            EndWriteAttribute();
            WriteLiteral("> <i title=\"Habilitar\" class=\"color-icono1 fa-solid fa-toggle-off\"></i></a>\r\n");
#nullable restore
#line 69 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 76 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                    </div>\r\n");
#nullable restore
#line 81 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1616fa671b788ff9450a796a37aeef0e26ce30d15991", async() => {
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
#line 96 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
        if (TempData["Accion"]!=null && TempData["Accion"].ToString().Equals("Guardar"))
       {
          

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            alertify.set(\'notifier\',\'position\',\'top-right\');\r\n            alertify.notify(\'");
#nullable restore
#line 100 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
                        Write(TempData["Mansaje"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \', \'success\', 5, function( ) {\r\n            });\r\n          ");
#nullable restore
#line 102 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\ProveedorTelas\Index.cshtml"
                 
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CreacionesPajov.WEB.Models.Entities.ProveedorTela>> Html { get; private set; }
    }
}
#pragma warning restore 1591