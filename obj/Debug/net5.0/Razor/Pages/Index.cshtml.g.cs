#pragma checksum "D:\Projects\E-commerce System\Solution\ShoppingSite\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c94acb0b933c451da313464363104f06f5696b93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ShoppingSite.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ShoppingSite.Pages
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
#line 1 "D:\Projects\E-commerce System\Solution\ShoppingSite\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\E-commerce System\Solution\ShoppingSite\Pages\_ViewImports.cshtml"
using ShoppingSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\E-commerce System\Solution\ShoppingSite\Pages\_ViewImports.cshtml"
using ShoppingSite.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c94acb0b933c451da313464363104f06f5696b93", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ff197a6ec18eb41062f2f975238bb3ef3920b0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Projects\E-commerce System\Solution\ShoppingSite\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""main"">
    <div class=""container py-5"">
        <div class=""row py-4"">
            <div class=""col-lg-7 pt-5 text-center"">
                <h1 class=""pt-5"">IPhone 10X on Sale!</h1>
                <button class=""btn1 mt-3"">More Tips</button>
            </div>
        </div>
    </div>
</section>


<section class=""<new"">
    <div class=""container py-1"">
        <div class=""=row pt-4"">
            <div class=""col-lg-7 m-auto"">
                <div class=""row text-center"">
                    <div class=""col-lg-4"">
                        <img src=""./Images/Man.png"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 695, "\"", 701, 0);
            EndWriteAttribute();
            WriteLiteral("/>\r\n                        <h6>Man</h6>\r\n                    </div>\r\n                    <div class=\"col-lg-4\">\r\n                        <img src=\"./Images/some.png\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 886, "\"", 892, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <h6>Some</h6>\r\n                    </div>\r\n                    <div class=\"col-lg-4\">\r\n                        <img src=\"./Images/BMW.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 1078, "\"", 1084, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        <h6>BMW</h6>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""product"">
    <div class=""container"">
        <div class=""row"">

        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
