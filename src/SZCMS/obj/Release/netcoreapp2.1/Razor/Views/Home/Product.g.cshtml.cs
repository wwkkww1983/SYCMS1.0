#pragma checksum "F:\项目\SYCMS1.0\src\SZCMS\Views\Home\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e08d72608ad5c6233439a428fe1e4c0a05cff37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Product), @"mvc.1.0.view", @"/Views/Home/Product.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Product.cshtml", typeof(AspNetCore.Views_Home_Product))]
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
#line 1 "F:\项目\SYCMS1.0\src\SZCMS\Views\_ViewImports.cshtml"
using SZCMS;

#line default
#line hidden
#line 2 "F:\项目\SYCMS1.0\src\SZCMS\Views\_ViewImports.cshtml"
using SZCMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e08d72608ad5c6233439a428fe1e4c0a05cff37", @"/Views/Home/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c08668d7bd6090aa73c93cb6fecbbe549a26fd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\项目\SYCMS1.0\src\SZCMS\Views\Home\Product.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_LayCms";

#line default
#line hidden
            BeginContext(79, 2388, true);
            WriteLiteral(@"
<!-- banner部分 -->
<div class=""banner product"">
    <div class=""title"">
        <p>产品展示</p>
        <p class=""en"">Product Display</p>
    </div>
</div>
<!-- main部分 -->
<div class=""main product"">
    <div class=""layui-container"">
        <div class=""content layui-row"">
            <div class=""layui-col-xs12 layui-col-sm6 layui-col-md7 layui-col-lg6 content-img""><img src=""/images/Product_img1.jpg""></div>
            <div class=""layui-col-xs12 layui-col-sm6 layui-col-md5 layui-col-lg6 right"">
                <p class=""label"">JS基础库</p>
                <p class=""detail"">从小屏逐步扩展到大屏，最终实现所有屏幕适配，最终实现所有屏幕适配，适应移动互联潮流。最终实现所有屏幕适配，适应移动互联潮流。最终实现所有屏幕适配，适应移动互联潮流。</p>
                <div><a href=""javascript:;"">查看产品 ></a></div>
            </div>
        </div>
        <div class=""content layui-row"">
            <div class=""layui-col-xs12 layui-col-sm6 layui-col-md7 layui-col-lg6 content-img""><img src=""/images/Product_img2.jpg""></div>
            <div class=""layui-col-xs12 layui-col-sm6 layui-col-md5 layui");
            WriteLiteral(@"-col-lg6 right"">
                <p class=""label"">CSS处理</p>
                <p class=""detail"">从小屏逐步扩展到大屏，最终实现所有屏幕适配，最终实现所有屏幕适配，适应移动互联潮流。最终实现所有屏幕适配，适应移动互联潮流。最终实现所有屏幕适配，适应移动互联潮流。</p>
                <div><a href=""javascript:;"">查看产品 ></a></div>
            </div>
        </div>
        <div class=""content layui-row"">
            <div class=""layui-col-xs12 layui-col-sm6 layui-col-md7 layui-col-lg6 content-img""><img src=""/images/Product_img3.jpg""></div>
            <div class=""layui-col-xs12 layui-col-sm6 layui-col-md5 layui-col-lg6 right"">
                <p class=""label"">兼容性</p>
                <p class=""detail"">从小屏逐步扩展到大屏，最终实现所有屏幕适配，最终实现所有屏幕适配，适应移动互联潮流。最终实现所有屏幕适配，适应移动互联潮流。最终实现所有屏幕适配，适应移动互联潮流。</p>
                <div><a href=""javascript:;"">查看产品 ></a></div>
            </div>
        </div>
        <div class=""content layui-row"">
            <div class=""layui-col-xs12 layui-col-sm6 layui-col-md7 layui-col-lg6 content-img""><img src=""/images/Product_img4.jpg""></div>
            <div class=""layui-co");
            WriteLiteral(@"l-xs12 layui-col-sm6 layui-col-md5 layui-col-lg6 right"">
                <p class=""label"">响应式</p>
                <p class=""detail"">从小屏逐步扩展到大屏，最终实现所有屏幕适配，最终实现所有屏幕适配，适应移动互联潮流。最终实现所有屏幕适配，适应移动互联潮流。最终实现所有屏幕适配，适应移动互联潮流。</p>
                <div><a href=""javascript:;"">查看产品 ></a></div>
            </div>
        </div>
    </div>
</div>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<object> Html { get; private set; }
    }
}
#pragma warning restore 1591
