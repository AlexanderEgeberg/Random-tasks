#pragma checksum "C:\Users\alexa\Documents\Semester 3 Eksamen\RestCareService\Views\BabyApis\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba76b71da5201d935c36810ab8e3ca9d4eca423c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BabyApis_Create), @"mvc.1.0.view", @"/Views/BabyApis/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba76b71da5201d935c36810ab8e3ca9d4eca423c", @"/Views/BabyApis/Create.cshtml")]
    public class Views_BabyApis_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BabyData.BabyApi>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\alexa\Documents\Semester 3 Eksamen\RestCareService\Views\BabyApis\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>BabyApi</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""UnitNo"" class=""control-label""></label>
                <input asp-for=""UnitNo"" class=""form-control"" />
                <span asp-validation-for=""UnitNo"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Breath"" class=""control-label""></label>
                <input asp-for=""Breath"" class=""form-control"" />
                <span asp-validation-for=""Breath"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Crying"" class=""control-label""></label>
                <input asp-for=""Crying"" class=""form-control"" />
                <span asp-validation-for=""Crying"" class=""text-danger""></span>
            ");
            WriteLiteral("</div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\alexa\Documents\Semester 3 Eksamen\RestCareService\Views\BabyApis\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BabyData.BabyApi> Html { get; private set; }
    }
}
#pragma warning restore 1591
