#pragma checksum "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Rol\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4022012fdba0b6643c43a3875bf897fa8763e10a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rol_Edit), @"mvc.1.0.view", @"/Views/Rol/Edit.cshtml")]
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
#line 1 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\_ViewImports.cshtml"
using SegurosFYP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\_ViewImports.cshtml"
using SegurosFYP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4022012fdba0b6643c43a3875bf897fa8763e10a", @"/Views/Rol/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea44def9759b7c4184a824174e6e654cf5b12dff", @"/Views/_ViewImports.cshtml")]
    public class Views_Rol_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SegurosFYP.Models.RolesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Rol\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card-header "">
    <div class=""d-flex justify-content-between"">
        <h3 class=""card-title"">Editar Rol</h3>
    </div>
</div>

<div class=""card-body"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card-header row"">
                <div class=""col-md-6"">
                    <input type=""text"" id=""txtRol"" name=""txtRol""");
            BeginWriteAttribute("value", " value=\"", 508, "\"", 540, 1);
#nullable restore
#line 19 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Rol\Edit.cshtml"
WriteAttributeValue("", 516, Model.Roles_Descripcion, 516, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Nombre del Rol"" class=""form-control"" />
                </div>
                <div class="" form-switch col-md-6"">
                    <div class=""checkbox-wrapper-14"">
                        <input class=""form-check-input switch"" type=""checkbox"" id=""checkTodos"">
                        <label class=""form-check-label"" for=""checkTodos"">Seleccionar Todos</label>
                    </div>
                </div>
            </div>
            <div class=""card-body"" style=""margin-left:5%;"">
                <h5 class=""card-title"">Pantallas</h5>
                <div class=""row justify-content-center"">
");
#nullable restore
#line 31 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Rol\Edit.cshtml"
                     foreach (var pantalla in Model.pantallas)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4\">\r\n                        <div");
            BeginWriteAttribute("class", " class=\"", 1330, "\"", 1338, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"checkbox-wrapper-14\">\r\n                                <input class=\"form-check-input pantalla-checkbox switch\" type=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 1509, "\"", 1541, 2);
            WriteAttributeValue("", 1514, "pantalla-", 1514, 9, true);
#nullable restore
#line 36 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Rol\Edit.cshtml"
WriteAttributeValue("", 1523, pantalla.Panta_Id, 1523, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"pantallasSeleccionadas\"");
            BeginWriteAttribute("value", " value=\"", 1572, "\"", 1598, 1);
#nullable restore
#line 36 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Rol\Edit.cshtml"
WriteAttributeValue("", 1580, pantalla.Panta_Id, 1580, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 36 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Rol\Edit.cshtml"
                                                                                                                                                                                               Write(Model.PantallasID.Contains(pantalla.Panta_Id) ? "checked" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 1731, "\"", 1764, 2);
            WriteAttributeValue("", 1737, "pantalla-", 1737, 9, true);
#nullable restore
#line 37 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Rol\Edit.cshtml"
WriteAttributeValue("", 1746, pantalla.Panta_Id, 1746, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 38 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Rol\Edit.cshtml"
                               Write(pantalla.Panta_Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </label>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 44 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Rol\Edit.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
            <div class=""card-footer"">
                <div class=""row"">
                    <div class=""col-sm-4"">
                        <button id=""btnAgregar"" type=""button"" class=""btn btn-primary"">Editar</button>
                    </div>
                    <div class=""col-sm-4"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4022012fdba0b6643c43a3875bf897fa8763e10a9273", async() => {
                WriteLiteral("Regresar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>

<script>
    $(document).ready(function () {
        $('#checkTodos').change(function () {
            if (this.checked) {
                $('.pantalla-checkbox').prop('checked', true);
            } else {
                $('.pantalla-checkbox').prop('checked', false);
            }
        });
    });

    $('#btnAgregar').click(function () {
        var rol = $('#txtRol').val();

        var pantallasSeleccionadas = [];
        console.log(rol)
        $('.pantalla-checkbox:checked').each(function () {
            pantallasSeleccionadas.push($(this).val());
        });
        var formData = {
            Roles_Id: 0,
            txtRol: rol,
            pantallasSeleccionadas: pantallasSeleccionadas,
        };

        console.log(formData)

        $.ajax({
            url: 'https://localhost:443");
            WriteLiteral(@"27/API/Roles/UpdateRol/',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(formData),
            success: function (response) {
                window.location.href = 'Rol/Index';
            },
            error: function (xhr, status, error) {
                console.error(error);
            }
        });
    });

</script>



");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 109 "C:\Users\LAB1\Desktop\Proyecto_Dany\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Views\Rol\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SegurosFYP.Models.RolesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
