#pragma checksum "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ControllerGenerator\ControllerWithActions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c2fe848161d8c1b5f35820b24798d584c2c7497"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ControllerGenerator_ControllerWithActions), @"mvc.1.0.view", @"/Templates/ControllerGenerator/ControllerWithActions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c2fe848161d8c1b5f35820b24798d584c2c7497", @"/Templates/ControllerGenerator/ControllerWithActions.cshtml")]
    public class Templates_ControllerGenerator_ControllerWithActions : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Threading.Tasks;\r\nusing Microsoft.AspNetCore.Http;\r\nusing Microsoft.AspNetCore.Mvc;\r\n\r\n");
#nullable restore
#line 9 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ControllerGenerator\ControllerWithActions.cshtml"
  string modelName = (Model.ClassName.EndsWith("Controller")? Model.ClassName.Substring(0,Model.ClassName.Length-10): Model.ClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("namespace ");
#nullable restore
#line 10 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ControllerGenerator\ControllerWithActions.cshtml"
     Write(Model.NamespaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n{\r\n    public class ");
#nullable restore
#line 12 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ControllerGenerator\ControllerWithActions.cshtml"
            Write(Model.ClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : Controller\r\n    {\r\n        // GET: ");
#nullable restore
#line 14 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ControllerGenerator\ControllerWithActions.cshtml"
           Write(modelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        public ActionResult Index()\r\n        {\r\n            return View();\r\n        }\r\n\r\n        // GET: ");
#nullable restore
#line 20 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ControllerGenerator\ControllerWithActions.cshtml"
           Write(modelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("/Details/5\r\n        public ActionResult Details(int id)\r\n        {\r\n            return View();\r\n        }\r\n\r\n        // GET: ");
#nullable restore
#line 26 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ControllerGenerator\ControllerWithActions.cshtml"
           Write(modelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("/Create\r\n        public ActionResult Create()\r\n        {\r\n            return View();\r\n        }\r\n\r\n        // POST: ");
#nullable restore
#line 32 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ControllerGenerator\ControllerWithActions.cshtml"
            Write(modelName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ");
#nullable restore
#line 49 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ControllerGenerator\ControllerWithActions.cshtml"
           Write(modelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("/Edit/5\r\n        public ActionResult Edit(int id)\r\n        {\r\n            return View();\r\n        }\r\n\r\n        // POST: ");
#nullable restore
#line 55 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ControllerGenerator\ControllerWithActions.cshtml"
            Write(modelName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ");
#nullable restore
#line 72 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ControllerGenerator\ControllerWithActions.cshtml"
           Write(modelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("/Delete/5\r\n        public ActionResult Delete(int id)\r\n        {\r\n            return View();\r\n        }\r\n\r\n        // POST: ");
#nullable restore
#line 78 "C:\Users\ACER\OneDrive\Escritorio\Seguros\Sistema_Seguros\Frontend\SegurosFYP\SegurosFYP\Templates\ControllerGenerator\ControllerWithActions.cshtml"
            Write(modelName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}");
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
