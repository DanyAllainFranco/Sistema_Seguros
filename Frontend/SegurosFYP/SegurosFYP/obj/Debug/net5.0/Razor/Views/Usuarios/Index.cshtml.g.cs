#pragma checksum "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4058932b8ce92d6a10033254e33a9d90c471a890"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Index), @"mvc.1.0.view", @"/Views/Usuarios/Index.cshtml")]
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
#line 1 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\_ViewImports.cshtml"
using SegurosFYP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\_ViewImports.cshtml"
using SegurosFYP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4058932b8ce92d6a10033254e33a9d90c471a890", @"/Views/Usuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea44def9759b7c4184a824174e6e654cf5b12dff", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SegurosFYP.Models.UsuarioViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary FetchData"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#EditarModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#ModalEliminar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Usuarios\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["ModelName"] = "UsuarioViewModel".Replace("ViewModel", "");

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card-header\">\r\n    <h1>");
#nullable restore
#line 8 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Usuarios\Index.cshtml"
   Write(ViewData["ModelName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <p>\r\n");
            WriteLiteral(@"        <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal""><i class=""mdi mdi-folder-plus""></i>Nuevo</button>
    </p>
</div>
<table class=""table table-bordered"" id=""Example"">
    <thead>
        <tr>

            <th>
                ");
#nullable restore
#line 20 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Usuar_Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Perso_NombreCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Roles_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Usuarios\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Usuarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Usuar_Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Usuarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Perso_NombreCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Usuarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Roles_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4058932b8ce92d6a10033254e33a9d90c471a8909285", async() => {
                WriteLiteral("<i class=\"bi bi-pencil\"></i>Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Usuarios\Index.cshtml"
                         WriteLiteral(item.Usuar_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Usuarios\Index.cshtml"
                                                                                                                                          Write(item.Usuar_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-id", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4058932b8ce92d6a10033254e33a9d90c471a89012232", async() => {
                WriteLiteral("<i class=\"bi bi-eye\"></i>Detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Usuarios\Index.cshtml"
                         WriteLiteral(item.Usuar_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4058932b8ce92d6a10033254e33a9d90c471a89014543", async() => {
                WriteLiteral("<i class=\"bi bi-trash\"></i>Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Usuarios\Index.cshtml"
                         WriteLiteral(item.Usuar_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1919, "ObtenerID(\'", 1919, 11, true);
#nullable restore
#line 50 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Usuarios\Index.cshtml"
AddHtmlAttributeValue("", 1930, item.Usuar_Id, 1930, 14, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1944, "\')", 1944, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 53 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Usuarios\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<div class=""modal fade"" id=""EditarModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Editar</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        ");
#nullable restore
#line 66 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Usuarios\Index.cshtml"
                   Write(Html.Partial("_Update", new SegurosFYP.Models.UsuarioViewModel ()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Insertar</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        ");
#nullable restore
#line 81 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Usuarios\Index.cshtml"
                   Write(Html.Partial("_Insert", new SegurosFYP.Models.UsuarioViewModel ()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""modal fade"" id=""ModalEliminar"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Eliminar</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        ");
#nullable restore
#line 96 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Usuarios\Index.cshtml"
                   Write(Html.Partial("_Delete", new SegurosFYP.Models.UsuarioViewModel ()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    <script>
        document.querySelectorAll('.FetchData').forEach(item => {
            item.addEventListener('click', function () {
                var UsuarId = this.getAttribute('data-id');
                console.log(UsuarId);
                fetchData(UsuarId);
            });
        });
        function fetchData(UsuarId) {
            console.log(UsuarId);
            fetch('https://localhost:44327/Usuario/Cargar/Usuario?Usuar_Id=' + UsuarId)
                .then(response => response.json())
                .then(data => {
                    console.log(data);

                    // Construir opciones para el selector Emple_Id
                    var empleSelect = document.getElementById('Emple_Id');
                    empleSelect.innerHTML = ''; // Limpiar las opciones anteriores

                    data.data.forEach(function (item) {
                        var option = document.crea");
            WriteLiteral(@"teElement('option');
                        option.value = item.emple_Id;
                        option.textContent = item.perso_NombreCompleto; // Cambia por el nombre del campo de descripción correcto
                        empleSelect.appendChild(option);
                    });

                    // Seleccionar la opción correcta en Emple_Id
                    document.getElementById('Emple_Id').value = data.data[0].emple_Id;

                    // Construir opciones para el selector Roles_Id
                    var rolesSelect = document.getElementById('Roles_Id');
                    rolesSelect.innerHTML = ''; // Limpiar las opciones anteriores

                    data.data.forEach(function (item) {
                        var option = document.createElement('option');
                        option.value = item.roles_Id;
                        option.textContent = item.roles_Descripcion; // Cambia por el nombre del campo de descripción correcto
                        rolesSe");
            WriteLiteral(@"lect.appendChild(option);
                    });

                    // Seleccionar la opción correcta en Roles_Id
                    document.getElementById('Roles_Id').value = data.data[0].roles_Id;

                    document.getElementById('Usuar_Id').value = data.data[0].usuar_Id;
                    document.getElementById('Usuar_Usuario').value = data.data[0].usuar_Usuario;
                    document.getElementById('Usuar_Contrasena').value = data.data[0].usuar_Contrasena;
                    document.getElementById('Usuar_Admin').checked = data.data[0].usuar_Admin;
                })
                .catch(error => console.error('Hubo un error:', error));
        }

                </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SegurosFYP.Models.UsuarioViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
