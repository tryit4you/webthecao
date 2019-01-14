#pragma checksum "D:\IDE-VisualStudio\WebTheCao\WebTheCao\Areas\Admin\Views\Shared\_UploadFileModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a47796172e5a0d4fcd6fb24a8f86c73f71fcafa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__UploadFileModal), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_UploadFileModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/_UploadFileModal.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared__UploadFileModal))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a47796172e5a0d4fcd6fb24a8f86c73f71fcafa3", @"/Areas/Admin/Views/Shared/_UploadFileModal.cshtml")]
    public class Areas_Admin_Views_Shared__UploadFileModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1290, true);
            WriteLiteral(@"
<div class=""modal fade"" id=""uploadFileModal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""largeModalLabel"">Trình quản lý ảnh</h4>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-md-6"">
                        <form class=""form-inline"" enctype=""multipart/form-data"" method=""post"">
                            <p>Tải hình lên máy chủ</p>
                            <div class=""form-group"">

                                <input type=""file"" name=""file"" value="""" id=""txtFileUpload"" multiple class=""btn btn-primary"" />
                            </div>
                            <div class=""form-group"">
                                <input name=""upload"" type=""button"" id=""btn-upload"" class=""btn btn-info"" value=""Tải lên"" />

                            </div>
  ");
            WriteLiteral(@"                      </form>
                    </div>
                    <div class=""col-md-6 search"">
                        <div class=""form-group pull-right"" style=""margin-bottom:0px"">
                            <div class=""form-inline search-inline"">
");
            EndContext();
            BeginContext(1385, 1668, true);
            WriteLiteral(@"                                <input type=""text"" name=""search"" value="""" placeholder=""Tìm kiếm..."" class=""form-control txtSearch"" />
                                <span id=""search-remove""><i class=""fa fa-times-circle""></i></span>
                                <input type=""button"" name=""search"" value=""tìm"" class=""btn btn-primary"" id=""btn-search"" />
                            </div>
                        </div>


                    </div>
                    <div class=""col-md-12"">
                        <p style=""margin-top:10px"">Tổng dung lượng: <mark id=""capacity""></mark> (MB)|Tổng số file: <mark id=""count""></mark></p>
                    </div>
                    <div class=""clearfix""></div>

                    <hr />
                </div>
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""content img-frame clearfix"">
                        </div>
                        <div class=""clearfix""></div>
            ");
            WriteLiteral(@"        </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-link waves-effect"" data-dismiss=""modal"">Đóng</button>
            </div>
        </div>
    </div>
</div>
<script id=""template-img"" type=""x-tmpl-mustache"">
    <div class=""row-item"">
        <div class=""show-image"">
            <img src=""/images/{{image}}"" data-id=""{{Id}}"" class=""img selectImg"" />
            <span class=""img-caption"">{{image}}</span>
            <span class=""remove"" data-html=""/images/{{image}}"" title=""xóa hình"">X</span>
        </div>
    </div>
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591