#pragma checksum "D:\Test Projects\.Net 5\Bug\DotNet5_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffeba5f9516124c3f0609de4215431c73752fa20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Index.cshtml")]
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
#nullable restore
#line 1 "D:\Test Projects\.Net 5\Bug\DotNet5_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml"
using DotNet5_Store_Application.Services.Users.Queries.GetUsers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffeba5f9516124c3f0609de4215431c73752fa20", @"/Areas/Admin/Views/Users/Index.cshtml")]
    public class Areas_Admin_Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResultGetUsersDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Test Projects\.Net 5\Bug\DotNet5_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
            <div class=""container-fluid""><!-- Zero configuration table -->
<section id=""configuration"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <div class=""card-title-wrap bar-success"">
                        <h4 class=""card-title""> لیست کاربران </h4>
                    </div>
                </div>
                <div class=""card-body collapse show"">
                    <div class=""card-block card-dashboard"">
                        <p class=""card-text"">داده های جداول اغلب ویژگی های پیش فرض را فعال می کنند، بنابراین همه چیزهایی که باید برای استفاده از آن با استفاده از ables خود انجام دهید، تماس با تابع ساخت است: $ (). DataTable ()؛</p>
                        <div id=""DataTables_Table_0_wrapper"" class=""dataTables_wrapper container-fluid dt-bootstrap4""><div class=""row""><div class=""col-sm-12 col-md-6""><div class=""dataTables_length"" id=""DataTables_Table_0_lengt");
            WriteLiteral(@"h""><label>نمایش <select name=""DataTables_Table_0_length"" aria-controls=""DataTables_Table_0"" class=""form-control form-control-sm""><option value=""10"">10</option><option value=""25"">25</option><option value=""50"">50</option><option value=""100"">100</option></select> سطر</label></div></div><div class=""col-sm-12 col-md-6""><div id=""DataTables_Table_0_filter"" class=""dataTables_filter""><label>جستجو:<input type=""search"" class=""form-control form-control-sm""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1671, "\"", 1685, 0);
            EndWriteAttribute();
            WriteLiteral(@" aria-controls=""DataTables_Table_0""></label></div></div></div><div class=""row""><div class=""col-sm-12""><table class=""table table-striped table-bordered zero-configuration dataTable"" id=""DataTables_Table_0"" role=""grid"" aria-describedby=""DataTables_Table_0_info"">
                            <thead>
                                <tr role=""row""><th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""نام: activate to sort column descending"" style=""width: 155.55px;"">نام</th>
                                    <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-label=""ایمیل: activate to sort column ascending"" style=""width: 289.062px;"">ایمیل</th>
                                    <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-label="" activate to sort column ascending"" style=""width: 107.062px;""></>
                            </thead>
       ");
            WriteLiteral("                     <tbody>\r\n                                \r\n");
#nullable restore
#line 30 "D:\Test Projects\.Net 5\Bug\DotNet5_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml"
                                 foreach (var item in Model.Users)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr role=\"row\" class=\"odd\">\r\n                                    <td class=\"sorting_1\">");
#nullable restore
#line 33 "D:\Test Projects\.Net 5\Bug\DotNet5_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml"
                                                     Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 34 "D:\Test Projects\.Net 5\Bug\DotNet5_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml"
                                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    <td>
                                        <button class=""btn btn-info"">ویرایش</button>
                                        <button class=""btn btn-danger"">حذف</button>
                                        <button class=""btn btn-warning"">غیر فعال</button>
                                    </td>
                                    </tr>
");
#nullable restore
#line 41 "D:\Test Projects\.Net 5\Bug\DotNet5_Store\EndPoint.Site\Areas\Admin\Views\Users\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            \r\n                            </tbody>\r\n");
            WriteLiteral(@"                        </table></div></div><div class=""row""><div class=""col-sm-12 col-md-5""><div class=""dataTables_info"" id=""DataTables_Table_0_info"" role=""status"" aria-live=""polite"">نمایش 1 تا 10 از 57 سطرها</div></div><div class=""col-sm-12 col-md-7""><div class=""dataTables_paginate paging_simple_numbers"" id=""DataTables_Table_0_paginate""><ul class=""pagination""><li class=""paginate_button page-item previous disabled"" id=""DataTables_Table_0_previous""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""0"" tabindex=""0"" class=""page-link"">قبلی</a></li><li class=""paginate_button page-item active""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""1"" tabindex=""0"" class=""page-link"">1</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""2"" tabindex=""0"" class=""page-link"">2</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""3"" tabindex=""0"" class=""page-link"">3</a></li><li class=""paginate_button pa");
            WriteLiteral(@"ge-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""4"" tabindex=""0"" class=""page-link"">4</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""5"" tabindex=""0"" class=""page-link"">5</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""6"" tabindex=""0"" class=""page-link"">6</a></li><li class=""paginate_button page-item next"" id=""DataTables_Table_0_next""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""7"" tabindex=""0"" class=""page-link"">بعدی</a></li></ul></div></div></div></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--/ Zero configuration table -->
<!-- Default ordering table -->
<!--/ Language - Comma decimal place table -->

            </div>
          </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResultGetUsersDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
