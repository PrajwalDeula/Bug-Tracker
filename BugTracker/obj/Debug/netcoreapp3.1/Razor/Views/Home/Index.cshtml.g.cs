#pragma checksum "C:\Users\Dell\Desktop\Bug-tracker\BugTracker\BugTracker\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "92d3b9d73d03478425d19a12d6a2f479e95eb4ec06371387e19f8ac8ad3d3c2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Dell\Desktop\Bug-tracker\BugTracker\BugTracker\Views\_ViewImports.cshtml"
using BugTracker

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Dell\Desktop\Bug-tracker\BugTracker\BugTracker\Views\_ViewImports.cshtml"
using BugTracker.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"92d3b9d73d03478425d19a12d6a2f479e95eb4ec06371387e19f8ac8ad3d3c2b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5f94891623e5fc7629b8b72a13358549b3533bbfa4ecb2d6c9b2f65981f8477a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Dell\Desktop\Bug-tracker\BugTracker\BugTracker\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Hello</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>



<div class=""row"">
    <div class=""col-md-4"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""input-group mb-3"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">$</span>
                    </div>
                    <input type=""text"" class=""form-control"" aria-label=""Amount (to the nearest dollar)"">
                    <div class=""input-group-append"">
                        <span class=""input-group-text"">.00</span>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-md-4"">
        <div class=""card"">
            <div class=""card-body"">
                <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exa");
            WriteLiteral(@"mpleModal"">
                    Launch demo modal
                </button>

            </div>
        </div>
    </div>
    <div class=""col-md-4"">
        <div class=""card"">
            <div class=""card-body"">
                <h1>right part </h1>
            </div>
        </div>
    </div>

    <div class=""col-md-3"">
        <div class=""card"">
            <div class=""card-body"">
                <h1>right part </h1>
            </div>
        </div>
    </div>

    <div class=""col-md-9"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-md-2"">
                        <button type=""button"" class=""btn btn-primary"">btn1</button>
                    </div>
                    <div class=""col-md-2"">
                        <button type=""button"" class=""btn btn-danger"">btn2</button>
                    </div>
                    <div class=""col-md-2"">
                        <button type=""button"" cl");
            WriteLiteral(@"ass=""btn btn-secondary"">btn3</button>
                    </div>
                    <div class=""col-md-2"">
                        <button type=""button"" class=""btn btn-success"">btn4</button>
                    </div>
                    <div class=""col-md-2"">
                        <span class=""badge badge-success"">New</span></h2>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body");
            WriteLiteral(@""">
                ...
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"">Save changes</button>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
