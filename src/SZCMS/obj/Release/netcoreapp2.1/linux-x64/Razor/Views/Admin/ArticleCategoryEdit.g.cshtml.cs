#pragma checksum "F:\asp.net\webwapi(core)\SyZero.BlogAPI\SZCMS\Views\Admin\ArticleCategoryEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed4409a716747a0cf3ee2fb53d7b7c2dc7afd436"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ArticleCategoryEdit), @"mvc.1.0.view", @"/Views/Admin/ArticleCategoryEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ArticleCategoryEdit.cshtml", typeof(AspNetCore.Views_Admin_ArticleCategoryEdit))]
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
#line 1 "F:\asp.net\webwapi(core)\SyZero.BlogAPI\SZCMS\Views\_ViewImports.cshtml"
using SZCMS;

#line default
#line hidden
#line 2 "F:\asp.net\webwapi(core)\SyZero.BlogAPI\SZCMS\Views\_ViewImports.cshtml"
using SZCMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed4409a716747a0cf3ee2fb53d7b7c2dc7afd436", @"/Views/Admin/ArticleCategoryEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c08668d7bd6090aa73c93cb6fecbbe549a26fd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ArticleCategoryEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/ArticleCategoryEdit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(15, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\asp.net\webwapi(core)\SyZero.BlogAPI\SZCMS\Views\Admin\ArticleCategoryEdit.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_LayUI";

#line default
#line hidden
            DefineSection("Css", async() => {
                BeginContext(91, 83, true);
                WriteLiteral(" \r\n    <link rel=\"stylesheet\" href=\"/lib/layuiadmin/style/admin.css\" media=\"all\">\r\n");
                EndContext();
            }
            );
            BeginContext(177, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(183, 1026, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c93c429968e94064a75026a1782d94d0", async() => {
                BeginContext(239, 963, true);
                WriteLiteral(@"
        <div class=""layui-form"" lay-filter=""layuiadmin-form-tags"" id=""layuiadmin-app-form-tags"" style=""padding-top: 30px; text-align: center;"">
            <div class=""layui-form-item"">
                <label class=""layui-form-label"">分类名</label>
                <div class=""layui-input-inline"">
                    <input type=""text"" name=""name"" lay-verify=""required"" placeholder=""请输入..."" autocomplete=""off"" class=""layui-input"">
                </div>
            </div>

            <div class=""layui-form-item"">
                <label class=""layui-form-label"">描述</label>
                <div class=""layui-input-inline"" style=""width:80%"">
                    <textarea name=""content"" id=""content"" lay-verify=""required"" style=""width: 85%; height: 150px;"" autocomplete=""off"" class=""layui-textarea content""></textarea>
                </div>
            </div>

            <input type=""hidden"" name=""id"" value="""" />
        </div>
        
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1209, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1228, 317, true);
                WriteLiteral(@" 
    <script>
        layui.config({
            base: '/lib/layuiadmin/' //静态资源所在路径
        }).extend({
            index: 'lib/index' //主入口模块
        }).use(['index', 'form'], function(){
            var $ = layui.$ 
                , form = layui.form;

            
        })
    </script>
    

");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<object> Html { get; private set; }
    }
}
#pragma warning restore 1591
