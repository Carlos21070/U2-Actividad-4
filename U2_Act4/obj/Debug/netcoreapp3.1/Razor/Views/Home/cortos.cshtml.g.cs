#pragma checksum "C:\Users\carlo\source\repos\U2_Act4\U2_Act4\Views\Home\cortos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "117b02841d02fcd3f0721ccf6b21dce56c0c4622"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_cortos), @"mvc.1.0.view", @"/Views/Home/cortos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"117b02841d02fcd3f0721ccf6b21dce56c0c4622", @"/Views/Home/cortos.cshtml")]
    public class Views_Home_cortos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imgPelicula"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\carlo\source\repos\U2_Act4\U2_Act4\Views\Home\cortos.cshtml"
   Layout = "_Layout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"principalPeliculas\">\r\n\r\n    <div id=\"pelis\">\r\n");
#nullable restore
#line 5 "C:\Users\carlo\source\repos\U2_Act4\U2_Act4\Views\Home\cortos.cshtml"
         foreach (var categ in Model.Categoria)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Animaciones</h1>\r\n");
#nullable restore
#line 8 "C:\Users\carlo\source\repos\U2_Act4\U2_Act4\Views\Home\cortos.cshtml"
         foreach (var corto in categ.Cortometraje)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "117b02841d02fcd3f0721ccf6b21dce56c0c46223683", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "117b02841d02fcd3f0721ccf6b21dce56c0c46223954", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 359, "~/images/portadas/", 359, 18, true);
#nullable restore
#line 12 "C:\Users\carlo\source\repos\U2_Act4\U2_Act4\Views\Home\cortos.cshtml"
AddHtmlAttributeValue("", 377, corto.Id, 377, 11, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 388, "_pc.jpg", 388, 7, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 12 "C:\Users\carlo\source\repos\U2_Act4\U2_Act4\Views\Home\cortos.cshtml"
AddHtmlAttributeValue("", 402, corto.Nombre, 402, 13, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 290, "~/cortos/", 290, 9, true);
#nullable restore
#line 11 "C:\Users\carlo\source\repos\U2_Act4\U2_Act4\Views\Home\cortos.cshtml"
AddHtmlAttributeValue("", 299, corto.Nombre.Replace(" ","-"), 299, 30, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"nombrePelicula\">\r\n                <p>");
#nullable restore
#line 15 "C:\Users\carlo\source\repos\U2_Act4\U2_Act4\Views\Home\cortos.cshtml"
              Write(corto.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            \r\n        </div>\r\n");
#nullable restore
#line 19 "C:\Users\carlo\source\repos\U2_Act4\U2_Act4\Views\Home\cortos.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\carlo\source\repos\U2_Act4\U2_Act4\Views\Home\cortos.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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