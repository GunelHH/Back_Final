#pragma checksum "/Users/gunelhesenova/Projects/OnlineShop/OnlineShop/Views/Order/Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af345a0d83213ce42f0cbf0b9bf894fed997d6ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OnlineShop.Views.Order.Views_Order_Cart), @"mvc.1.0.view", @"/Views/Order/Cart.cshtml")]
namespace OnlineShop.Views.Order
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af345a0d83213ce42f0cbf0b9bf894fed997d6ae", @"/Views/Order/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53bd22cc3bebf4ebad8bfe4e1f01a83955e2bc7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Breadcrumb Start -->
<div class=""container-fluid"">
    <div class=""row px-xl-5"">
        <div class=""col-12"">
            <nav class=""breadcrumb bg-light mb-30"">
                <a class=""breadcrumb-item text-dark"" href=""#"">Home</a>
                <a class=""breadcrumb-item text-dark"" href=""#"">Shop</a>
                <span class=""breadcrumb-item active"">Shopping Cart</span>
            </nav>
        </div>
    </div>
</div>
<!-- Breadcrumb End -->
<!-- Cart Start -->
<div class=""container-fluid"">
    <div class=""row px-xl-5"">
        <div class=""col-lg-8 table-responsive mb-5"">
            <table class=""table table-light table-borderless table-hover text-center mb-0"">
                <thead class=""thead-dark"">
                    <tr>
                        <th>Products</th>
                        <th>Price</th>
                        <th>Quantity</th>
                        <th>Total</th>
                        <th>Remove</th>
                    </tr>
                </thead>
                <tb");
            WriteLiteral("ody class=\"align-middle\">\n                    <tr>\n                        <td class=\"align-middle\"><img src=\"img/product-1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1152, "\"", 1158, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 50px;""> Product Name</td>
                        <td class=""align-middle"">$150</td>
                        <td class=""align-middle"">
                            <div class=""input-group quantity mx-auto"" style=""width: 100px;"">
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-sm btn-primary btn-minus"">
                                        <i class=""fa fa-minus""></i>
                                    </button>
                                </div>
                                <input type=""text"" class=""form-control form-control-sm bg-secondary border-0 text-center"" value=""1"">
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-sm btn-primary btn-plus"">
                                        <i class=""fa fa-plus""></i>
                                    </button>
                                </div>
                            </div>
             ");
            WriteLiteral(@"           </td>
                        <td class=""align-middle"">$150</td>
                        <td class=""align-middle""><button class=""btn btn-sm btn-danger""><i class=""fa fa-times""></i></button></td>
                    </tr>
                    <tr>
                        <td class=""align-middle""><img src=""img/product-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2516, "\"", 2522, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 50px;""> Product Name</td>
                        <td class=""align-middle"">$150</td>
                        <td class=""align-middle"">
                            <div class=""input-group quantity mx-auto"" style=""width: 100px;"">
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-sm btn-primary btn-minus"">
                                        <i class=""fa fa-minus""></i>
                                    </button>
                                </div>
                                <input type=""text"" class=""form-control form-control-sm bg-secondary border-0 text-center"" value=""1"">
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-sm btn-primary btn-plus"">
                                        <i class=""fa fa-plus""></i>
                                    </button>
                                </div>
                            </div>
             ");
            WriteLiteral(@"           </td>
                        <td class=""align-middle"">$150</td>
                        <td class=""align-middle""><button class=""btn btn-sm btn-danger""><i class=""fa fa-times""></i></button></td>
                    </tr>
                    <tr>
                        <td class=""align-middle""><img src=""img/product-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3880, "\"", 3886, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 50px;""> Product Name</td>
                        <td class=""align-middle"">$150</td>
                        <td class=""align-middle"">
                            <div class=""input-group quantity mx-auto"" style=""width: 100px;"">
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-sm btn-primary btn-minus"">
                                        <i class=""fa fa-minus""></i>
                                    </button>
                                </div>
                                <input type=""text"" class=""form-control form-control-sm bg-secondary border-0 text-center"" value=""1"">
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-sm btn-primary btn-plus"">
                                        <i class=""fa fa-plus""></i>
                                    </button>
                                </div>
                            </div>
             ");
            WriteLiteral(@"           </td>
                        <td class=""align-middle"">$150</td>
                        <td class=""align-middle""><button class=""btn btn-sm btn-danger""><i class=""fa fa-times""></i></button></td>
                    </tr>
                    <tr>
                        <td class=""align-middle""><img src=""img/product-4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5244, "\"", 5250, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 50px;""> Product Name</td>
                        <td class=""align-middle"">$150</td>
                        <td class=""align-middle"">
                            <div class=""input-group quantity mx-auto"" style=""width: 100px;"">
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-sm btn-primary btn-minus"">
                                        <i class=""fa fa-minus""></i>
                                    </button>
                                </div>
                                <input type=""text"" class=""form-control form-control-sm bg-secondary border-0 text-center"" value=""1"">
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-sm btn-primary btn-plus"">
                                        <i class=""fa fa-plus""></i>
                                    </button>
                                </div>
                            </div>
             ");
            WriteLiteral(@"           </td>
                        <td class=""align-middle"">$150</td>
                        <td class=""align-middle""><button class=""btn btn-sm btn-danger""><i class=""fa fa-times""></i></button></td>
                    </tr>
                    <tr>
                        <td class=""align-middle""><img src=""img/product-5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6608, "\"", 6614, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 50px;""> Product Name</td>
                        <td class=""align-middle"">$150</td>
                        <td class=""align-middle"">
                            <div class=""input-group quantity mx-auto"" style=""width: 100px;"">
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-sm btn-primary btn-minus"">
                                        <i class=""fa fa-minus""></i>
                                    </button>
                                </div>
                                <input type=""text"" class=""form-control form-control-sm bg-secondary border-0 text-center"" value=""1"">
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-sm btn-primary btn-plus"">
                                        <i class=""fa fa-plus""></i>
                                    </button>
                                </div>
                            </div>
             ");
            WriteLiteral(@"           </td>
                        <td class=""align-middle"">$150</td>
                        <td class=""align-middle""><button class=""btn btn-sm btn-danger""><i class=""fa fa-times""></i></button></td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div class=""col-lg-4"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af345a0d83213ce42f0cbf0b9bf894fed997d6ae12543", async() => {
                WriteLiteral(@"
                <div class=""input-group"">
                    <input type=""text"" class=""form-control border-0 p-4"" placeholder=""Coupon Code"">
                    <div class=""input-group-append"">
                        <button class=""btn btn-primary"">Apply Coupon</button>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <h5 class=""section-title position-relative text-uppercase mb-3""><span class=""bg-secondary pr-3"">Cart Summary</span></h5>
            <div class=""bg-light p-30 mb-5"">
                <div class=""border-bottom pb-2"">
                    <div class=""d-flex justify-content-between mb-3"">
                        <h6>Subtotal</h6>
                        <h6>$150</h6>
                    </div>
                    <div class=""d-flex justify-content-between"">
                        <h6 class=""font-weight-medium"">Shipping</h6>
                        <h6 class=""font-weight-medium"">$10</h6>
                    </div>
                </div>
                <div class=""pt-2"">
                    <div class=""d-flex justify-content-between mt-2"">
                        <h5>Total</h5>
                        <h5>$160</h5>
                    </div>
                    <button class=""btn btn-block btn-primary font-weight-bold my-3 py-3"">Proceed To Checkout</button>
                </div>
            </div>
  ");
            WriteLiteral("      </div>\n    </div>\n</div>\n<!-- Cart End -->\n");
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
