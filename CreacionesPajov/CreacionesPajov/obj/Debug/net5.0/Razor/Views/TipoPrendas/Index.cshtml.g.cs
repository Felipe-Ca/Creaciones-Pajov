#pragma checksum "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoPrendas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef678223e9cf93c837ad43552e38a73ceecad779"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TipoPrendas_Index), @"mvc.1.0.view", @"/Views/TipoPrendas/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef678223e9cf93c837ad43552e38a73ceecad779", @"/Views/TipoPrendas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0172f286af4f054d61d3ee661d6488a94b30c38", @"/Views/_ViewImports.cshtml")]
    public class Views_TipoPrendas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CreacionesPajov.WEB.Models.Entities.TipoPrenda>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/adminlte/dist/img/fav.ico"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/tabla.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ef678223e9cf93c837ad43552e38a73ceecad7794223", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\n\n");
            }
            );
            WriteLiteral("\n<div class=\"content\">\n    <div class=\"container-fluid\">\n        <div class=\"table-responsive\">\n            <div class=\"contenedor-index\">\n            <div class=\"col-md-7\">\n                <h2>Gestión de <b> ");
#nullable restore
#line 12 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoPrendas\Index.cshtml"
                              Write(ViewBag.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\n            </div>\n            <br />\n            <div class=\"col-md-7\">\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 465, "\"", 573, 5);
            WriteAttributeValue("", 475, "mostrarModal(\'", 475, 14, true);
#nullable restore
#line 16 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoPrendas\Index.cshtml"
WriteAttributeValue("", 489, Url.Action("Crear","TipoPrendas",null,Context.Request.Scheme), 489, 62, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 551, "\',\'Crear", 551, 8, true);
            WriteAttributeValue(" ", 559, "Tipo", 560, 5, true);
            WriteAttributeValue(" ", 564, "Prenda\')", 565, 9, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-emp\">Crear Tipo Prenda</a>\n            </div>\n            </div>\n\n");
#nullable restore
#line 20 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoPrendas\Index.cshtml"
             if (Model.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\n                <p>No existen Tipo De Prenda</p>\n");
#nullable restore
#line 24 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoPrendas\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\n                <div class=\"contenedor-tabla\">\n                <table class=\"table table-striped\" id=\"tabla\">\n                    <thead class=\"thead-dark\">\n                        <tr>\n                            <th>");
#nullable restore
#line 32 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoPrendas\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                            <th>Acciones</th>\n                           \n                        </tr>\n                    </thead>\n                    <tbody>\n");
#nullable restore
#line 38 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoPrendas\Index.cshtml"
                         foreach (var TipoPrenda in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line 41 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoPrendas\Index.cshtml"
                               Write(TipoPrenda.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                               \n\n                               \n\n\n                                <td>\n                                    <a class=\"text-success\"");
            BeginWriteAttribute("href", " href=\"", 1616, "\"", 1764, 5);
            WriteAttributeValue("", 1623, "javascript:mostrarModal(\'", 1623, 25, true);
#nullable restore
#line 48 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoPrendas\Index.cshtml"
WriteAttributeValue("", 1648, Url.Action("Detalle","TipoPrendas",new {id=TipoPrenda.TipoPrendaId},Context.Request.Scheme), 1648, 92, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1740, "\',\'Detalle", 1740, 10, true);
            WriteAttributeValue(" ", 1750, "Tipo", 1751, 5, true);
            WriteAttributeValue(" ", 1755, "Prenda\')", 1756, 9, true);
            EndWriteAttribute();
            WriteLiteral("> <i title=\"Detalle\" class=\"color-icono1 fa-solid fa-magnifying-glass-plus\"></i></a> |\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1890, "\"", 2036, 5);
            WriteAttributeValue("", 1897, "javascript:mostrarModal(\'", 1897, 25, true);
#nullable restore
#line 49 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoPrendas\Index.cshtml"
WriteAttributeValue("", 1922, Url.Action("Editar","TipoPrendas",new {id=TipoPrenda.TipoPrendaId},Context.Request.Scheme), 1922, 91, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2013, "\',\'Editar", 2013, 9, true);
            WriteAttributeValue(" ", 2022, "Tipo", 2023, 5, true);
            WriteAttributeValue(" ", 2027, "Prenda\')", 2028, 9, true);
            EndWriteAttribute();
            WriteLiteral("><i title=\"Editar\" class=\"color-icono2 fa-solid fa-user-pen\"></i></a>\n                                </td>\n                            </tr>\n");
#nullable restore
#line 52 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoPrendas\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n                    </div>\n");
#nullable restore
#line 57 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoPrendas\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef678223e9cf93c837ad43552e38a73ceecad77911413", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    <script>\n");
#nullable restore
#line 68 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoPrendas\Index.cshtml"
        if (TempData["Accion"]!=null && TempData["Accion"].ToString().Equals("Guardar"))
       {
          

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            alertify.set(\'notifier\',\'position\',\'top-right\');\n            alertify.notify(\'");
#nullable restore
#line 72 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoPrendas\Index.cshtml"
                        Write(TempData["Mansaje"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \', \'success\', 5, function( ) {\n\n            });\n          ");
#nullable restore
#line 75 "C:\Users\ADMIN\Desktop\CreacionesPajov act\CreacionesPajov\Views\TipoPrendas\Index.cshtml"
                 
       }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </script>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CreacionesPajov.WEB.Models.Entities.TipoPrenda>> Html { get; private set; }
    }
}
#pragma warning restore 1591