#pragma checksum "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c93fd3821f8271633862b850ddfe7a2e1da9990"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_RazorPageGenerator_Versioned_Bootstrap3_DeletePageModel), @"mvc.1.0.view", @"/Templates/RazorPageGenerator_Versioned/Bootstrap3/DeletePageModel.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c93fd3821f8271633862b850ddfe7a2e1da9990", @"/Templates/RazorPageGenerator_Versioned/Bootstrap3/DeletePageModel.cshtml")]
    public class Templates_RazorPageGenerator_Versioned_Bootstrap3_DeletePageModel : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Threading.Tasks;\r\nusing Microsoft.AspNetCore.Mvc;\r\nusing Microsoft.AspNetCore.Mvc.RazorPages;\r\nusing Microsoft.EntityFrameworkCore;\r\n");
#nullable restore
#line 11 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
  
    var entitySetName = Model.ModelMetadata.EntitySetName;
    var entitySetVar = Model.EntitySetVariable ??
        (String.IsNullOrEmpty(entitySetName)
            ? entitySetName
            : (entitySetName.Substring(0, length: 1).ToLowerInvariant() + entitySetName.Substring(1)));

    var primaryKeyName = Model.ModelMetadata.PrimaryKeys[0].PropertyName;
    var primaryKeyShortTypeName = Model.ModelMetadata.PrimaryKeys[0].ShortTypeName;
    var primaryKeyType = Model.ModelMetadata.PrimaryKeys[0].TypeName;
    var primaryKeyNullableTypeName = GetNullableTypeName(primaryKeyType, primaryKeyShortTypeName);
    var lambdaVar = Model.ModelVariable[0];
    var relatedProperties = new Dictionary<string, dynamic>();
    foreach (var nav in Model.ModelMetadata.Navigations)
    {
        relatedProperties.Add(nav.AssociationPropertyName, nav);

    }
    var inlineIncludes = "";
    foreach (var property in relatedProperties.Values)
    {
        inlineIncludes += string.Format("{0}                .Include({1} => {1}.{2})", Environment.NewLine, lambdaVar, property.AssociationPropertyName);
    }

    foreach (var namespaceName in Model.RequiredNamespaces)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("using ");
#nullable restore
#line 37 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
   Write(namespaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n");
#nullable restore
#line 38 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nnamespace ");
#nullable restore
#line 41 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
     Write(Model.NamespaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n{\r\n    public class ");
#nullable restore
#line 43 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
            Write(Model.PageModelClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : PageModel\r\n    {\r\n        private readonly ");
#nullable restore
#line 45 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
                    Write(Model.ContextTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" _context;\r\n\r\n        public ");
#nullable restore
#line 47 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
           Write(Model.PageModelClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("(");
#nullable restore
#line 47 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
                                      Write(Model.ContextTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" context)\r\n        {\r\n            _context = context;\r\n        }\r\n\r\n        [BindProperty]\r\n        public ");
#nullable restore
#line 53 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
          Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 53 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
                                       Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" { get; set; }\r\n\r\n        public async Task<IActionResult> OnGetAsync(");
#nullable restore
#line 55 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
                                               Write(primaryKeyNullableTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" id)\r\n        {\r\n            if (id == null)\r\n            {\r\n                return NotFound();\r\n            }\r\n\r\n            ");
#nullable restore
#line 62 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
       Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = await _context.");
#nullable restore
#line 62 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
                                                      Write(entitySetName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
                                                                      Write(inlineIncludes);

#line default
#line hidden
#nullable disable
            WriteLiteral(".FirstOrDefaultAsync(m => m.");
#nullable restore
#line 62 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
                                                                                                                  Write(primaryKeyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" == id);\r\n\r\n            if (");
#nullable restore
#line 64 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
           Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" == null)\r\n            {\r\n                return NotFound();\r\n            }\r\n            return Page();\r\n        }\r\n\r\n        public async Task<IActionResult> OnPostAsync(");
#nullable restore
#line 71 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
                                                Write(primaryKeyNullableTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" id)\r\n        {\r\n            if (id == null)\r\n            {\r\n                return NotFound();\r\n            }\r\n\r\n            ");
#nullable restore
#line 78 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
       Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = await _context.");
#nullable restore
#line 78 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
                                                      Write(entitySetName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".FindAsync(id);\r\n\r\n            if (");
#nullable restore
#line 80 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
           Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" != null)\r\n            {\r\n                _context.");
#nullable restore
#line 82 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
                     Write(entitySetName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".Remove(");
#nullable restore
#line 82 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
                                            Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n                await _context.SaveChangesAsync();\r\n            }\r\n\r\n            return RedirectToPage(\"./Index\");\r\n        }\r\n    }\r\n}\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator_Versioned\Bootstrap3\DeletePageModel.cshtml"
 
    // This function converts the primary key short type name to its nullable equivalent when possible. This is required to make
    // sure that an HTTP 400 error is thrown when the user tries to access the edit, delete, or details action with null values.
    string GetNullableTypeName(string typeName, string shortTypeName)
    {
        // The exceptions are caught because if for any reason the type is user defined, then the short type name will be used.
        // In that case the user will receive a server error if null is passed to the edit, delete, or details actions.
        Type primaryKeyType = null;
        try
        {
            primaryKeyType = Type.GetType(typeName);
        }
        catch
        {
        }
        if (primaryKeyType != null && (!Microsoft.VisualStudio.Web.CodeGeneration.Templating.TypeUtilities.IsNullable(primaryKeyType) || IsGuid(typeName)))
        {
            return shortTypeName + "?";
        }
        return shortTypeName;
    }

    bool IsGuid(string typeName) {
        return String.Equals("System.Guid", typeName, StringComparison.OrdinalIgnoreCase);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
