#pragma checksum "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de653bbf41dd5f7d8d1cd3f1b9536215bb2ca1be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OnlineShop.Views.Product.Views_Product_Shop), @"mvc.1.0.view", @"/Views/Product/Shop.cshtml")]
namespace OnlineShop.Views.Product
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
#line 3 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/_ViewImports.cshtml"
using OnlineShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/_ViewImports.cshtml"
using OnlineShop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/_ViewImports.cshtml"
using OnlineShop.ViewModels.Basket;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de653bbf41dd5f7d8d1cd3f1b9536215bb2ca1be", @"/Views/Product/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"800855d3ce19ba046bada49bf4bee6bfd1b4d680", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Clothe>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-clicked", "A-Z", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-clicked", "Price", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

  
<!-- Breadcrumb Start -->
<div class=""container-fluid"">
    <div class=""row px-xl-5"">
        <div class=""col-12"">
            <nav class=""breadcrumb bg-light mb-30"">
                <a class=""breadcrumb-item text-dark"" href=""#"">Home</a>
                <a class=""breadcrumb-item text-dark"" href=""#"">Shop</a>
                <span class=""breadcrumb-item active"">Shop List</span>
            </nav>
        </div>
    </div>
</div>
<!-- Breadcrumb End -->
<!-- Shop Start -->
<div class=""container-fluid"">
    <div class=""row px-xl-5"">
        <!-- Shop Sidebar Start -->
        <div class=""col-lg-3 col-md-4"">
            <!-- Price Start -->
            <h5 class=""section-title position-relative text-uppercase mb-3""><span class=""bg-secondary pr-3"">Filter by price</span></h5>
            <div class=""bg-light p-4 mb-30"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de653bbf41dd5f7d8d1cd3f1b9536215bb2ca1be5954", async() => {
                WriteLiteral(@"
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" checked id=""price-all"">
                        <label class=""custom-control-label"" for=""price-all"">All Price</label>
                        <span class=""badge border font-weight-normal"">1000</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""price-1"">
                        <label class=""custom-control-label"" for=""price-1"">$0 - $100</label>
                        <span class=""badge border font-weight-normal"">150</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-i");
                WriteLiteral(@"nput"" id=""price-2"">
                        <label class=""custom-control-label"" for=""price-2"">$100 - $200</label>
                        <span class=""badge border font-weight-normal"">295</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""price-3"">
                        <label class=""custom-control-label"" for=""price-3"">$200 - $300</label>
                        <span class=""badge border font-weight-normal"">246</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""price-4"">
                        <label class=""custom-control-label"" for=""price-4"">$300 - $400</label>
                        <span class=""badge border font-weight-normal"">145</span>
     ");
                WriteLiteral(@"               </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""price-5"">
                        <label class=""custom-control-label"" for=""price-5"">$400 - $500</label>
                        <span class=""badge border font-weight-normal"">168</span>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <!-- Price End -->
            <!-- Color Start -->
            <h5 class=""section-title position-relative text-uppercase mb-3""><span class=""bg-secondary pr-3"">Filter by color</span></h5>
            <div class=""bg-light p-4 mb-30"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de653bbf41dd5f7d8d1cd3f1b9536215bb2ca1be10097", async() => {
                WriteLiteral(@"
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" checked id=""color-all"">
                        <label class=""custom-control-label"" for=""price-all"">All Color</label>
                        <span class=""badge border font-weight-normal"">1000</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""color-1"">
                        <label class=""custom-control-label"" for=""color-1"">Black</label>
                        <span class=""badge border font-weight-normal"">150</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input");
                WriteLiteral(@""" id=""color-2"">
                        <label class=""custom-control-label"" for=""color-2"">White</label>
                        <span class=""badge border font-weight-normal"">295</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""color-3"">
                        <label class=""custom-control-label"" for=""color-3"">Red</label>
                        <span class=""badge border font-weight-normal"">246</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""color-4"">
                        <label class=""custom-control-label"" for=""color-4"">Blue</label>
                        <span class=""badge border font-weight-normal"">145</span>
                    </div>
   ");
                WriteLiteral(@"                 <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""color-5"">
                        <label class=""custom-control-label"" for=""color-5"">Green</label>
                        <span class=""badge border font-weight-normal"">168</span>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <!-- Color End -->
            <!-- Size Start -->
            <h5 class=""section-title position-relative text-uppercase mb-3""><span class=""bg-secondary pr-3"">Filter by size</span></h5>
            <div class=""bg-light p-4 mb-30"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de653bbf41dd5f7d8d1cd3f1b9536215bb2ca1be14208", async() => {
                WriteLiteral(@"
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" checked id=""size-all"">
                        <label class=""custom-control-label"" for=""size-all"">All Size</label>
                        <span class=""badge border font-weight-normal"">1000</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""size-1"">
                        <label class=""custom-control-label"" for=""size-1"">XS</label>
                        <span class=""badge border font-weight-normal"">150</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""si");
                WriteLiteral(@"ze-2"">
                        <label class=""custom-control-label"" for=""size-2"">S</label>
                        <span class=""badge border font-weight-normal"">295</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""size-3"">
                        <label class=""custom-control-label"" for=""size-3"">M</label>
                        <span class=""badge border font-weight-normal"">246</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""size-4"">
                        <label class=""custom-control-label"" for=""size-4"">L</label>
                        <span class=""badge border font-weight-normal"">145</span>
                    </div>
                    <div c");
                WriteLiteral(@"lass=""custom-control custom-checkbox d-flex align-items-center justify-content-between"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""size-5"">
                        <label class=""custom-control-label"" for=""size-5"">XL</label>
                        <span class=""badge border font-weight-normal"">168</span>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <!-- Size End -->
        </div>
        <!-- Shop Sidebar End -->
        <!-- Shop Product Start -->
        <div class=""col-lg-9 col-md-8"">
            <div class=""row pb-3"">
                <div class=""col-12 pb-1"">
                    <div class=""d-flex align-items-center justify-content-between mb-4"">
                        <div>
                            <button class=""btn btn-sm btn-light""><i class=""fa fa-th-large""></i></button>
                            <button class=""btn btn-sm btn-light ml-2""><i class=""fa fa-bars""></i></button>
                        </div>
                        <div class=""ml-2"">
                            <div class=""btn-group"">
                                <button type=""button"" class=""btn btn-sm btn-light dropdown-toggle"" data-toggle=""dropdown"">Sorting</button>
                                <div class=""dropdown-menu dropdown-menu-right"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de653bbf41dd5f7d8d1cd3f1b9536215bb2ca1be18997", async() => {
                WriteLiteral("Sort by A-Z");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-clicked", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["clicked"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de653bbf41dd5f7d8d1cd3f1b9536215bb2ca1be20976", async() => {
                WriteLiteral("Sort by Z-A");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-clicked", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 150 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Shop.cshtml"
                                                                                                               WriteLiteral("Z-A");

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["clicked"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-clicked", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["clicked"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de653bbf41dd5f7d8d1cd3f1b9536215bb2ca1be23508", async() => {
                WriteLiteral("Sort by Price");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-clicked", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["clicked"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
                            <div class=""btn-group ml-2"">
                                <button type=""button"" class=""btn btn-sm btn-light dropdown-toggle"" data-toggle=""dropdown"">Showing</button>
                                <div class=""dropdown-menu dropdown-menu-right"">
                                    <a class=""dropdown-item"" href=""#"">10</a>
                                    <a class=""dropdown-item"" href=""#"">20</a>
                                    <a class=""dropdown-item"" href=""#"">30</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

");
#nullable restore
#line 166 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Shop.cshtml"
                 if (ViewBag.Message != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-danger\">");
#nullable restore
#line 168 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Shop.cshtml"
                                               Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 169 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Shop.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 172 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Shop.cshtml"
               Write(await Html.PartialAsync("_ClothesPartialView", Model));

#line default
#line hidden
#nullable disable
#nullable restore
#line 172 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Shop.cshtml"
                                                                          

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                <div class=""col-12"">
                    <nav>
                        <ul class=""pagination justify-content-center"">
                            <li class=""page-item disabled""><a class=""page-link"" href=""#"">Previous</a></li>
                            <li class=""page-item active""><a class=""page-link"" href=""#"">1</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">Next</a></li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>
        <!-- Shop Product End -->
    </div>
</div>
<!-- Shop End -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Clothe>> Html { get; private set; }
    }
}
#pragma warning restore 1591
