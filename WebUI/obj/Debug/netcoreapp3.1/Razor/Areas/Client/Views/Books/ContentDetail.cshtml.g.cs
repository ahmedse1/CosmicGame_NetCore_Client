#pragma checksum "C:\Users\Ahmed Hassan\source\repos\CosmicGameNew\CosmicGame_NetCore_Client\WebUI\Areas\Client\Views\Books\ContentDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2f780a50110024642ae60ce09e5074fc1f728ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Client_Views_Books_ContentDetail), @"mvc.1.0.view", @"/Areas/Client/Views/Books/ContentDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2f780a50110024642ae60ce09e5074fc1f728ec", @"/Areas/Client/Views/Books/ContentDetail.cshtml")]
    public class Areas_Client_Views_Books_ContentDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ahmed Hassan\source\repos\CosmicGameNew\CosmicGame_NetCore_Client\WebUI\Areas\Client\Views\Books\ContentDetail.cshtml"
  
    Layout = "~/Areas/Client/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    $(document).ready(function () {
        document.title = 'Content';
    });
</script>

<div class=""page-header"">
    <h1>
        Content Detail
    </h1>
</div>

<div class=""row"">
    <div class=""col-sm-10 col-sm-offset-1"">
        <form class=""form-horizontal center-block"" id=""frmContentDetail"">
            <div class=""row"">

                <div class=""col-xs-12 col-sm-6 pl-2 pr-2"">
                    <div class=""widget-box"">
                        <div class=""widget-header"">
                            <h4 class=""widget-title"">Content Detail</h4>
                        </div>
                        <div class=""widget-body"">
                            <div class=""widget-main"">
                                <div class=""form-group"">
                                    <label class=""col-sm-3 control-label no-padding-right"" for=""ddlBook"">Book</label>
                                    <div class=""col-sm-9"">
                                        <select class=""form-control"" id=""ddlBook"" d");
            WriteLiteral(@"ata-placeholder=""Choose a Book"">
                                        </select>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label class=""col-sm-3 control-label no-padding-right"" for=""ddlChapter"">Chapter</label>
                                    <div class=""col-sm-9"">
                                        <select class=""form-control"" id=""ddlChapter"" data-placeholder=""Choose a Chapter"">
                                        </select>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label class=""col-sm-3 control-label no-padding-right"" for=""ddlHeader"">Header</label>
                                    <div class=""col-sm-9"">
                                        <select class=""form-control"" id=""ddlHeader"" data-placeholder=""Choose a Header"">
       ");
            WriteLiteral(@"                                 </select>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label class=""col-sm-3 control-label no-padding-right"" for=""txtHeaderTitle"">Header Title</label>
                                    <div class=""col-sm-9"">
                                        <input type=""text"" class=""form-control"" id=""txtHeaderTitle"" placeholder=""Title"" />
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label class=""col-sm-3 control-label no-padding-right"" for=""txtContent"">Content</label>
                                    <div class=""col-sm-9"">
                                        <textarea rows=""10"" class=""form-control"" id=""txtContent"" placeholder=""Content""></textarea>
                                    </div>
                               ");
            WriteLiteral(@" </div>
                            </div>
                        </div>


                    </div>
                    <div class=""center"">
                        <button class=""btn btn-success"" type=""submit"">
                            <i class=""ace-icon fa fa-save""></i>
                            Confirm & Save
                        </button>
                        <a class=""btn  btn-inverse"" href=""/client/Books/Contents"">
                            <i class=""ace-icon fa fa-arrow-left""></i>
                            Back
                        </a>
                    </div>
                </div>
            </div>

        </form>

    </div>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2f780a50110024642ae60ce09e5074fc1f728ec6917", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3825, "~/js/Page/books/ContentDetail.js?v=", 3825, 35, true);
#nullable restore
#line 83 "C:\Users\Ahmed Hassan\source\repos\CosmicGameNew\CosmicGame_NetCore_Client\WebUI\Areas\Client\Views\Books\ContentDetail.cshtml"
AddHtmlAttributeValue("", 3860, Utility.GlobalVars.siteVersion, 3860, 31, false);

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