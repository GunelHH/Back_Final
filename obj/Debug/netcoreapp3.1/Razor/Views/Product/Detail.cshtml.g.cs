#pragma checksum "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36f5cc4a0b01fb233d396e4d95fe1b772daa4b40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OnlineShop.Views.Product.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36f5cc4a0b01fb233d396e4d95fe1b772daa4b40", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9b8d0201b53e5a225c6a4c6f2f70af09d676909", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Clothe>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100 h-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/user.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid mr-3 mt-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 45px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
  
    List<Clothe> related = ViewBag.Related;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Breadcrumb Start -->
<div class=""container-fluid"">
    <div class=""row px-xl-5"">
        <div class=""col-12"">
            <nav class=""breadcrumb bg-light mb-30"">
                <a class=""breadcrumb-item text-dark"" href=""#"">Home</a>
                <a class=""breadcrumb-item text-dark"" href=""#"">Shop</a>
                <span class=""breadcrumb-item active"">Shop Detail</span>
            </nav>
        </div>
    </div>
</div>
<!-- Breadcrumb End -->
<!-- Shop Detail Start -->
<div class=""container-fluid pb-5"">
    <div class=""row px-xl-5"">
        <div class=""col-lg-5 mb-30"">
            <div id=""product-carousel"" class=""carousel slide"" data-ride=""carousel"">
                <div class=""carousel-inner bg-light"">
                    <div class=""carousel-item active"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "36f5cc4a0b01fb233d396e4d95fe1b772daa4b406152", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 896, "~/assets/img/products/", 896, 22, true);
#nullable restore
#line 25 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
AddHtmlAttributeValue("", 918, Model.ImageClothes.FirstOrDefault(i=>i.IsMain==true)?.Name, 918, 59, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
AddHtmlAttributeValue("", 984, Model.Name, 984, 11, false);

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
            WriteLiteral("\n                    </div>\n                    <div class=\"carousel-item\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "36f5cc4a0b01fb233d396e4d95fe1b772daa4b408295", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1127, "~/assets/img/products/", 1127, 22, true);
#nullable restore
#line 28 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
AddHtmlAttributeValue("", 1149, Model.ImageClothes.FirstOrDefault(i=>i.IsMain==false)?.Name, 1149, 60, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 28 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
AddHtmlAttributeValue("", 1216, Model.Name, 1216, 11, false);

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
            WriteLiteral("\n                    </div>\n                    <div class=\"carousel-item\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "36f5cc4a0b01fb233d396e4d95fe1b772daa4b4010445", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1359, "~/assets/img/products/", 1359, 22, true);
#nullable restore
#line 31 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
AddHtmlAttributeValue("", 1381, Model.ImageClothes.FirstOrDefault(i=>i.IsMain==false)?.Name, 1381, 60, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 31 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
AddHtmlAttributeValue("", 1448, Model.Name, 1448, 11, false);

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
            WriteLiteral("\n                    </div>\n                    <div class=\"carousel-item\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "36f5cc4a0b01fb233d396e4d95fe1b772daa4b4012596", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1591, "~/assets/img/products/", 1591, 22, true);
#nullable restore
#line 34 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
AddHtmlAttributeValue("", 1613, Model.ImageClothes.FirstOrDefault(i=>i.IsMain==false)?.Name, 1613, 60, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 34 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
AddHtmlAttributeValue("", 1680, Model.Name, 1680, 11, false);

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
            WriteLiteral(@"
                    </div>
                </div>
                <a class=""carousel-control-prev"" href=""#product-carousel"" data-slide=""prev"">
                    <i class=""fa fa-2x fa-angle-left text-dark""></i>
                </a>
                <a class=""carousel-control-next"" href=""#product-carousel"" data-slide=""next"">
                    <i class=""fa fa-2x fa-angle-right text-dark""></i>
                </a>
            </div>
        </div>

        <div class=""col-lg-7 h-auto mb-30"">
            <div class=""h-100 bg-light p-30"">
                <h3>Product Name Goes Here</h3>
               
                <h3 class=""font-weight-semi-bold mb-4"">$");
#nullable restore
#line 50 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
                                                   Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                <p class=\"mb-4\">\n                   ");
#nullable restore
#line 52 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
               Write(Model.Desc.Count()>200 ? Model.Desc.Substring(0,200) : Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </p>\n                <div class=\"d-flex mb-3\">\n                    <strong class=\"text-dark mr-3\">Sizes:</strong>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36f5cc4a0b01fb233d396e4d95fe1b772daa4b4016077", async() => {
                WriteLiteral(@"
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" class=""custom-control-input"" id=""size-1"" name=""size"">
                            <label class=""custom-control-label"" for=""size-1"">XS</label>
                        </div>
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" class=""custom-control-input"" id=""size-2"" name=""size"">
                            <label class=""custom-control-label"" for=""size-2"">S</label>
                        </div>
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" class=""custom-control-input"" id=""size-3"" name=""size"">
                            <label class=""custom-control-label"" for=""size-3"">M</label>
                        </div>
                        <div class=""custom-control custom-radio custom-control-inline"">
          ");
                WriteLiteral(@"                  <input type=""radio"" class=""custom-control-input"" id=""size-4"" name=""size"">
                            <label class=""custom-control-label"" for=""size-4"">L</label>
                        </div>
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" class=""custom-control-input"" id=""size-5"" name=""size"">
                            <label class=""custom-control-label"" for=""size-5"">XL</label>
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
            WriteLiteral("\n                </div>\n                <div class=\"d-flex mb-4\">\n                    <strong class=\"text-dark mr-3\">Colors:</strong>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36f5cc4a0b01fb233d396e4d95fe1b772daa4b4019116", async() => {
                WriteLiteral(@"
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" class=""custom-control-input"" id=""color-1"" name=""color"">
                            <label class=""custom-control-label"" for=""color-1"">Black</label>
                        </div>
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" class=""custom-control-input"" id=""color-2"" name=""color"">
                            <label class=""custom-control-label"" for=""color-2"">White</label>
                        </div>
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" class=""custom-control-input"" id=""color-3"" name=""color"">
                            <label class=""custom-control-label"" for=""color-3"">Red</label>
                        </div>
                        <div class=""custom-control custom-radio custom-control-i");
                WriteLiteral(@"nline"">
                            <input type=""radio"" class=""custom-control-input"" id=""color-4"" name=""color"">
                            <label class=""custom-control-label"" for=""color-4"">Blue</label>
                        </div>
                        <div class=""custom-control custom-radio custom-control-inline"">
                            <input type=""radio"" class=""custom-control-input"" id=""color-5"" name=""color"">
                            <label class=""custom-control-label"" for=""color-5"">Green</label>
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
                <div class=""d-flex align-items-center mb-4 pt-2"">
                    <div class=""input-group quantity mr-3"" style=""width: 130px;"">
                        <div class=""input-group-btn"">
                            <button class=""btn btn-primary btn-minus"">
                                <i class=""fa fa-minus""></i>
                            </button>
                        </div>
                        <input type=""text"" class=""form-control bg-secondary border-0 text-center"" value=""1"">
                        <div class=""input-group-btn"">
                            <button class=""btn btn-primary btn-plus"">
                                <i class=""fa fa-plus""></i>
                            </button>
                        </div>
                    </div>
                    <button class=""btn btn-primary px-3"">
                        <i class=""fa fa-shopping-cart mr-1""></i> Add To
                        Cart
                    </button>
                </div");
            WriteLiteral(">\n                <div class=\"d-flex pt-2\">\n                    <strong class=\"text-dark mr-2\">Share on:</strong>\n                    <div class=\"d-inline-flex\">\n                        <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 7216, "\"", 7223, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            <i class=\"fab fa-facebook-f\"></i>\n                        </a>\n                        <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 7366, "\"", 7373, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            <i class=\"fab fa-twitter\"></i>\n                        </a>\n                        <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 7513, "\"", 7520, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            <i class=\"fab fa-linkedin-in\"></i>\n                        </a>\n                        <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 7664, "\"", 7671, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""fab fa-pinterest""></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row px-xl-5"">
        <div class=""col"">
            <div class=""bg-light p-30"">
                <div class=""nav nav-tabs mb-4"">
                    <a class=""nav-item nav-link text-dark active"" data-toggle=""tab"" href=""#tab-pane-1"">Description</a>
                    <a class=""nav-item nav-link text-dark"" data-toggle=""tab"" href=""#tab-pane-2"">Information</a>
                    <a class=""nav-item nav-link text-dark"" data-toggle=""tab"" href=""#tab-pane-3"">Reviews (0)</a>
                </div>
                <div class=""tab-content"">
                    <div class=""tab-pane fade show active"" id=""tab-pane-1"">
                        <h4 class=""mb-3"">Product Description</h4>
                        <p>");
#nullable restore
#line 154 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
                      Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\n                                          <p>  ");
#nullable restore
#line 155 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
                                           Write(Model.Desc.Count()>500 ? Model.Desc.Substring(0,500) : Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        \n                    </div>\n                    <div class=\"tab-pane fade\" id=\"tab-pane-2\">\n                        <h4 class=\"mb-3\">");
#nullable restore
#line 159 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
                                    Write(Model.ClotheInformation.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                        <p>");
#nullable restore
#line 160 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
                      Write(Model.ClotheInformation.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <ul class=""list-group list-group-flush"">
                                    <li class=""list-group-item px-0"">
                                        ");
#nullable restore
#line 165 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
                                    Write(Model.Desc.Count()>64 ? Model.Desc.Substring(0,64) : Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </li>\n                                    <li class=\"list-group-item px-0\">\n                                        ");
#nullable restore
#line 168 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
                                    Write(Model.Desc.Count()>64 ? Model.Desc.Substring(0,64) : Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </li>\n                                    <li class=\"list-group-item px-0\">\n                                        ");
#nullable restore
#line 171 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
                                    Write(Model.Desc.Count()>64 ? Model.Desc.Substring(0,64) : Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </li>\n                                    <li class=\"list-group-item px-0\">\n                                       ");
#nullable restore
#line 174 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
                                   Write(Model.Desc.Count()>64 ? Model.Desc.Substring(0,64) : Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </ul>
                            </div>
                            <div class=""col-md-6"">
                                <ul class=""list-group list-group-flush"">
                                    <li class=""list-group-item px-0"">
                                        ");
#nullable restore
#line 180 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
                                    Write(Model.Desc.Count()>64 ? Model.Desc.Substring(0,64) : Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </li>\n                                    <li class=\"list-group-item px-0\">\n                                        ");
#nullable restore
#line 183 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
                                    Write(Model.Desc.Count()>64 ? Model.Desc.Substring(0,64) : Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </li>\n                                    <li class=\"list-group-item px-0\">\n                                        ");
#nullable restore
#line 186 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
                                    Write(Model.Desc.Count()>64 ? Model.Desc.Substring(0,64) : Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </li>\n                                    <li class=\"list-group-item px-0\">\n                                        ");
#nullable restore
#line 189 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
                                    Write(Model.Desc.Count()>64 ? Model.Desc.Substring(0,64) : Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class=""tab-pane fade"" id=""tab-pane-3"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <h4 class=""mb-4"">1 review for ""Product Name""</h4>
                                <div class=""media mb-4"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "36f5cc4a0b01fb233d396e4d95fe1b772daa4b4030979", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <div class=""media-body"">
                                        <h6>John Doe<small> - <i>01 Jan 2045</i></small></h6>
                                        <div class=""text-primary mb-2"">
                                            <i class=""fas fa-star""></i>
                                            <i class=""fas fa-star""></i>
                                            <i class=""fas fa-star""></i>
                                            <i class=""fas fa-star-half-alt""></i>
                                            <i class=""far fa-star""></i>
                                        </div>
                                        <p>Diam amet duo labore stet elitr ea clita ipsum, tempor labore accusam ipsum et no at. Kasd diam tempor rebum magna dolores sed sed eirmod ipsum.</p>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                    ");
            WriteLiteral(@"            <h4 class=""mb-4"">Leave a review</h4>
                                <small>Your email address will not be published. Required fields are marked *</small>
                                <div class=""d-flex my-3"">
                                    <p class=""mb-0 mr-2"">Your Rating * :</p>
                                    <div class=""text-primary"">
                                        <i class=""far fa-star""></i>
                                        <i class=""far fa-star""></i>
                                        <i class=""far fa-star""></i>
                                        <i class=""far fa-star""></i>
                                        <i class=""far fa-star""></i>
                                    </div>
                                </div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36f5cc4a0b01fb233d396e4d95fe1b772daa4b4034148", async() => {
                WriteLiteral(@"
                                    <div class=""form-group"">
                                        <label for=""message"">Your Review *</label>
                                        <textarea id=""message"" cols=""30"" rows=""5"" class=""form-control""></textarea>
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""name"">Your Name *</label>
                                        <input type=""text"" class=""form-control"" id=""name"">
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""email"">Your Email *</label>
                                        <input type=""email"" class=""form-control"" id=""email"">
                                    </div>
                                    <div class=""form-group mb-0"">
                                        <input type=""submit"" value=""Leave Your Review"" class=""btn btn-pri");
                WriteLiteral("mary px-3\">\n                                    </div>\n                                ");
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
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Shop Detail End -->
<!-- Products Start -->
<div class=""container-fluid py-5"">
    <h2 class=""section-title position-relative text-uppercase mx-xl-5 mb-4""><span class=""bg-secondary pr-3"">You May Also Like</span></h2>
    <div class=""row px-xl-5"">
        <div class=""col"">



");
            WriteLiteral("\n\n\n");
            WriteLiteral("\n\n           \n            ");
#nullable restore
#line 298 "/Users/gunelhesenova/Desktop/OnlineShop/OnlineShop/Views/Product/Detail.cshtml"
       Write(await Html.PartialAsync("_ClothesPartialView",related));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        </div>\n    </div>\n</div>\n<!-- Products End -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Clothe> Html { get; private set; }
    }
}
#pragma warning restore 1591
