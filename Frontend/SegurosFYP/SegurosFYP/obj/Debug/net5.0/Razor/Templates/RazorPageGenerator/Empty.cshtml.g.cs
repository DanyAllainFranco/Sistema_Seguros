#pragma checksum "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\Empty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1533f953c14d117b84ad56318e7327622ace6a63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_RazorPageGenerator_Empty), @"mvc.1.0.view", @"/Templates/RazorPageGenerator/Empty.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\Empty.cshtml"
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\Empty.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\Empty.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1533f953c14d117b84ad56318e7327622ace6a63", @"/Templates/RazorPageGenerator/Empty.cshtml")]
    public class Templates_RazorPageGenerator_Empty : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("@page\r\n");
#nullable restore
#line 6 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\Empty.cshtml"
  
    if (!Model.NoPageModel)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("@model ");
#nullable restore
#line 9 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\Empty.cshtml"
     Write(Model.NamespaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 9 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\Empty.cshtml"
                          Write(Model.PageModelClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\Empty.cshtml"
    }
    if (Model.IsPartialView)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("@*\r\n");
            WriteLiteral("    For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860\r\n");
            WriteLiteral("*");
            WriteLiteral("@\r\n");
#nullable restore
#line 16 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\Empty.cshtml"

    }
    else if (Model.IsLayoutPageSelected)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("@{\r\n    ");
            WriteLiteral("ViewData[\"Title\"] = \"");
#nullable restore
#line 21 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\Empty.cshtml"
                      Write(Model.RazorPageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 22 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\Empty.cshtml"
        if (!string.IsNullOrEmpty(Model.LayoutPageFile))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("Layout = \"");
#nullable restore
#line 24 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\Empty.cshtml"
           Write(Model.LayoutPageFile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 25 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\Empty.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("}\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<h1>");
#nullable restore
#line 28 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\Empty.cshtml"
 Write(Model.RazorPageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\Empty.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("@{\r\n    ");
            WriteLiteral("Layout = null;\r\n");
            WriteLiteral("}\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<!DOCTYPE html>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<html>\r\n");
            WriteLiteral("<head>\r\n    ");
            WriteLiteral("<meta name=\"viewport\" content=\"width=device-width\" />\r\n    ");
            WriteLiteral("<title>");
#nullable restore
#line 42 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\Empty.cshtml"
        Write(Model.RazorPageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
            WriteLiteral("</head>\r\n");
            WriteLiteral("<body>\r\n");
#nullable restore
#line 45 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\Empty.cshtml"
    }
    if (Model.ReferenceScriptLibraries)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("@section Scripts {\r\n    ");
            WriteLiteral("@{await Html.RenderPartialAsync(\"_ValidationScriptsPartial\");}\r\n");
            WriteLiteral("}\r\n");
#nullable restore
#line 51 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\Empty.cshtml"
    }
    // The following code closes the tag used in the case of a view using a layout page and the body and html tags in the case of a regular view page
    if (!Model.IsPartialView && !Model.IsLayoutPageSelected)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("</body>\r\n");
            WriteLiteral("</html>\r\n");
#nullable restore
#line 57 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\RazorPageGenerator\Empty.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
