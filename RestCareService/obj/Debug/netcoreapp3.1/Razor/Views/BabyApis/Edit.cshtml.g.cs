#pragma checksum "C:\Users\alexa\Documents\Semester 3 Eksamen\RestCareService\Views\BabyApis\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e11efb5f7c2fefa9c68fa87b896727ae29d89133"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BabyApis_Edit), @"mvc.1.0.view", @"/Views/BabyApis/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e11efb5f7c2fefa9c68fa87b896727ae29d89133", @"/Views/BabyApis/Edit.cshtml")]
    public class Views_BabyApis_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BabyData.BabyApi>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\alexa\Documents\Semester 3 Eksamen\RestCareService\Views\BabyApis\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>BabyApi</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
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
                <span asp-validation-for=""Cry");
            WriteLiteral(@"ing"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\alexa\Documents\Semester 3 Eksamen\RestCareService\Views\BabyApis\Edit.cshtml"
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
