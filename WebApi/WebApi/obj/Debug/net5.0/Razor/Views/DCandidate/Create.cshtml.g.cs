#pragma checksum "C:\Users\Domvs\OneDrive\Documentos\Projetos\WebApi\WebApi\Views\DCandidate\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2adaadc18b4bed0a81d940997dffe7a8cabb918"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DCandidate_Create), @"mvc.1.0.view", @"/Views/DCandidate/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2adaadc18b4bed0a81d940997dffe7a8cabb918", @"/Views/DCandidate/Create.cshtml")]
    #nullable restore
    public class Views_DCandidate_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApi.Models.DCandidate>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Domvs\OneDrive\Documentos\Projetos\WebApi\WebApi\Views\DCandidate\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>DCandidate</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""fullName"" class=""control-label""></label>
                <input asp-for=""fullName"" class=""form-control"" />
                <span asp-validation-for=""fullName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""mobile"" class=""control-label""></label>
                <input asp-for=""mobile"" class=""form-control"" />
                <span asp-validation-for=""mobile"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""email"" class=""control-label""></label>
                <input asp-for=""email"" class=""form-control"" />
                <span asp-validation-for=""email"" class=""text-danger""></span>
      ");
            WriteLiteral(@"      </div>
            <div class=""form-group"">
                <label asp-for=""age"" class=""control-label""></label>
                <input asp-for=""age"" class=""form-control"" />
                <span asp-validation-for=""age"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""bloodgroup"" class=""control-label""></label>
                <input asp-for=""bloodgroup"" class=""form-control"" />
                <span asp-validation-for=""bloodgroup"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""address"" class=""control-label""></label>
                <input asp-for=""address"" class=""form-control"" />
                <span asp-validation-for=""address"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>");
            WriteLiteral("\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\Domvs\OneDrive\Documentos\Projetos\WebApi\WebApi\Views\DCandidate\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApi.Models.DCandidate> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591