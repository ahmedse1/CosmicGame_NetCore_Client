#pragma checksum "D:\WinappTech\Project\Upwork\Raj_Rajendram\CosmicGame_NetCore_Bitbucket\WebUI\Areas\Client\Views\ChartHolder\ChartHolderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82f79ce30975c7284ddbb7276fb02598e529ec7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Client_Views_ChartHolder_ChartHolderDetail), @"mvc.1.0.view", @"/Areas/Client/Views/ChartHolder/ChartHolderDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82f79ce30975c7284ddbb7276fb02598e529ec7c", @"/Areas/Client/Views/ChartHolder/ChartHolderDetail.cshtml")]
    public class Areas_Client_Views_ChartHolder_ChartHolderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\WinappTech\Project\Upwork\Raj_Rajendram\CosmicGame_NetCore_Bitbucket\WebUI\Areas\Client\Views\ChartHolder\ChartHolderDetail.cshtml"
  
    Layout = "~/Areas/Client/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    $(document).ready(function () {
        document.title = 'Chart Holder';
        document.getElementById('txtCurrentDateTime').value = (new Date().toLocaleString([], { hour12: true }));
    });
</script>

<div class=""page-header"">
    <h1>
        Chart Hoder Detail
    </h1>
</div><!-- /.page-header -->

<div class=""row"">
    <div class=""col-sm-10 col-sm-offset-1"">
        <form class=""form-horizontal center-block"" id=""frmChartHolderDetail"">
            <div class=""row"">

                <div class=""col-xs-12 col-sm-6 pl-2 pr-2"">
                    <div class=""widget-box"">
                        <div class=""widget-header"">
                            <h4 class=""widget-title"">Personal Information</h4>
                        </div>
                        <div class=""widget-body"">
                            <div class=""widget-main"">
                                <div class=""form-group"">
                                    <label class=""col-sm-3 control-label no-padd");
            WriteLiteral(@"ing-right"" for=""txtContact"">Contact</label>
                                    <div class=""col-sm-9"">
                                        <input type=""text"" class=""form-control"" id=""txtContact"" placeholder=""Contact"" />
                                    </div>
                                </div>

");
            WriteLiteral(@"
                                <div class=""form-group"">
                                    <label class=""col-sm-3 control-label no-padding-right"" for=""txtChildName"">Child Name</label>
                                    <div class=""col-sm-9"">
                                        <input type=""text"" class=""form-control"" id=""txtChildName"" placeholder=""Ex. Smith"" />
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <label class=""col-sm-3 control-label no-padding-right"" for=""txtFatherName"">Father Name</label>
                                    <div class=""col-sm-9"">
                                        <input type=""text"" class=""form-control"" id=""txtFatherName"" placeholder=""Ex. michele"" />
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <la");
            WriteLiteral(@"bel class=""col-sm-3 control-label no-padding-right"" for=""txtMotherName"">Mother Name</label>
                                    <div class=""col-sm-9"">
                                        <input type=""text"" class=""form-control"" id=""txtMotherName"" placeholder=""Ex. Michelle"" />
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""control-group"">
                                        <label class=""col-sm-3 control-label no-padding-right"">Gender</label>
                                        <div class=""radio col-sm-3"">
                                            <label>
                                                <input name=""rdoGender"" type=""radio"" class=""ace"" id=""rdMale"" />
                                                <span class=""lbl""> Male</span>
                                            </label>
                                        </div>

   ");
            WriteLiteral(@"                                     <div class=""radio col-sm-6"">
                                            <label>
                                                <input name=""rdoGender"" type=""radio"" class=""ace"" id=""rdFemale"" />
                                                <span class=""lbl""> Female</span>
                                            </label>
                                        </div>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label class=""col-sm-3 control-label no-padding-right"" for=""txtBirthDate"">Birth Date</label>
                                    <div class=""col-sm-9"">
                                        <div class=""input-group"">
                                            <input id=""txtBirthDate"" type=""text"" class=""form-control datetimepicker"" />
                                            <span class=""input-group-addon"">
       ");
            WriteLiteral(@"                                         <i class=""fa fa-clock-o bigger-110""></i>
                                            </span>
                                        </div>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""control-group"">
                                        <label class=""col-sm-3 control-label no-padding-right"">Aynamsa Policy</label>

                                        <div class=""radio col-sm-3"">
                                            <label>
                                                <input name=""rdoAynamsa"" class=""rdoAynamsa"" type=""radio"" class=""ace"" id=""rdNirayana"" />
                                                <span class=""lbl""> Nirayana</span>
                                            </label>
                                        </div>

                                        <div class=""radio col-sm");
            WriteLiteral(@"-6"">
                                            <label>
                                                <input name=""rdoAynamsa"" class=""rdoAynamsa"" type=""radio"" class=""ace"" id=""rdSayana"" />
                                                <span class=""lbl""> Sayana</span>
                                            </label>
                                        </div>

                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label class=""col-sm-3 control-label no-padding-right"" for=""ddlAynamsa"">Aynamsa</label>
                                    <div class=""col-sm-9"">
                                        <select class=""form-control"" id=""ddlAynamsa"" data-placeholder=""Choose a Aynamsa"">
                                            <option value=""0"">--Select Aynamsa--</option>
                                            <option value=""AL"">NA</option>
                           ");
            WriteLiteral(@"                 <option value=""AK"">lahiri</option>
                                            <option value=""AZ"">Raman</option>
                                        </select>
                                    </div>
                                </div>
                                <div class=""form-group"" sstyle=""padding-bottom:25px;"">
                                    <label class=""col-sm-3 control-label no-padding-right"" for=""ddlHouseSys"">House System</label>
                                    <div class=""col-sm-9"">
                                        <select class=""form-control"" id=""ddlHouseSys"" data-placeholder=""Choose a House sys"">
                                            <option value=""0"">--House System--</option>
                                            <option value=""AL"">P</option>
                                        </select>
                                    </div>
                                </div>
                            </div>
                 ");
            WriteLiteral(@"       </div>
                    </div>
                </div>
                <div class=""col-xs-12 col-sm-6 pl-2 pr-2"">
                    <div class=""widget-box"">
                        <div class=""widget-header"">
                            <h4 class=""widget-title"">Location Information</h4>
                        </div>

                        <div class=""widget-body"">
                            <div class=""widget-main"">
                                <div class=""form-group"">
                                    <label class=""col-sm-3 control-label no-padding-right"" for=""txtEmail"">Email</label>
                                    <div class=""col-sm-9"">
                                        <input type=""text"" class=""form-control"" id=""txtEmail"" placeholder=""youremailaddress@mail.com"" />
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <label class=""col-sm-");
            WriteLiteral(@"3 control-label no-padding-right"" for=""txtBirthPlace"">Birth Place</label>
                                    <div class=""col-sm-9"">
                                        <input type=""text"" class=""form-control"" id=""txtBirthPlace"" placeholder=""Birth Address"" />
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <label class=""col-sm-3 control-label no-padding-right"" for=""txtCity"">City</label>
                                    <div class=""col-sm-9"">
                                        <input type=""text"" class=""form-control"" id=""txtCity"" />
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <label class=""col-sm-3 control-label no-padding-right"" for=""txtState"">State</label>
                                    <div class=""col-sm-9"">
             ");
            WriteLiteral(@"                           <input type=""text"" class=""form-control"" id=""txtState"" />
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <label class=""col-sm-3 control-label no-padding-right"" for=""ddlCountry"">Country</label>
                                    <div class=""col-sm-9"">
                                        <select class=""chosen-select form-control"" id=""ddlCountry"" data-placeholder=""Choose a Country"">
                                        </select>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label class=""col-sm-3 control-label no-padding-right"" for=""txtPostalCode"">Postal Code</label>
                                    <div class=""col-sm-9"">
                                        <input type=""text"" class=""form-control"" id=""txtP");
            WriteLiteral(@"ostalCode"" />
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label class=""col-sm-3 control-label no-padding-right"" for=""ddlTimeZone"">Time Zone</label>
                                    <div class=""col-sm-9"">
                                        <select class=""chosen-select form-control"" id=""ddlTimeZone"" data-placeholder=""Choose a Time zone"">
                                        </select>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label class=""col-sm-3 control-label no-padding-right"" for=""txtLatitude"">Latitude</label>
                                    <div class=""col-sm-4"">
                                        <input type=""text"" class=""form-control"" id=""txtLatitude"" />
                                    </div>
              ");
            WriteLiteral(@"                      <div class=""col-sm-2"">
                                        <input type=""text"" class=""form-control"" id=""txtLatLocator"" disabled />
                                    </div>
                                    <div class=""col-sm-3"">
                                        <input type=""text"" class=""form-control"" id=""txtDMSLat"" disabled />
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label class=""col-sm-3 control-label no-padding-right"" for=""txtLongitude"">Longitude</label>
                                    <div class=""col-sm-4"">
                                        <input type=""text"" class=""form-control"" id=""txtLongitude"" />
                                    </div>
                                    <div class=""col-sm-2"">
                                        <input type=""text"" class=""form-control"" id=""txtLngLocator"" disabled />
     ");
            WriteLiteral(@"                               </div>
                                    <div class=""col-sm-3"">
                                        <input type=""text"" class=""form-control"" id=""txtDMSLong"" disabled />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div id=""showMapModal"" class=""modal"" role=""dialog"" data-backdrop=""false"">
                    <div class=""modal-dialog"">
                        <!-- Modal content-->
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                                <h4 class=""modal-title"">Map View</h4>
                            </div>
                            <div class=""modal-body"">
                                <div class=""row");
            WriteLiteral(@""">
                                    <div id=""map-canvas"" style=""visibility:hidden;width:100%!important;min-height:500px!important;""></div>
                                </div>
                            </div>
                            <div class=""modal-footer"">
                                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                            </div>
                        </div>

                    </div>
                </div>
                <div id=""CustAddressModal"" class=""modal"" role=""dialog"" data-backdrop=""false"">
                    <div class=""modal-dialog"">
                        <!-- Modal content-->
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                                <h4 class=""modal-title"">Customer Current Address</h4>
                  ");
            WriteLiteral(@"          </div>
                            <div class=""modal-body"">
                                <div class=""row"">
                                    <div class=""col-xs-12"">

                                        <div class=""form-group"">
                                            <label class=""col-sm-3 control-label no-padding-right"" for=""txtAddress"">Address</label>
                                            <div class=""col-sm-9"">
                                                <input type=""text"" class=""form-control"" id=""txtAddress"" placeholder=""Current Address"" />
                                            </div>
                                        </div>

                                        <div class=""form-group"">
                                            <label class=""col-sm-3 control-label no-padding-right"" for=""txtCCity"">City</label>
                                            <div class=""col-sm-9"">
                                                <input type=""text"" cl");
            WriteLiteral(@"ass=""form-control"" id=""txtCCity"" />
                                            </div>
                                        </div>

                                        <div class=""form-group"">
                                            <label class=""col-sm-3 control-label no-padding-right"" for=""txtCState"">State</label>
                                            <div class=""col-sm-9"">
                                                <input type=""text"" class=""form-control"" id=""txtCState"" />
                                            </div>
                                        </div>

                                        <div class=""form-group"">
                                            <label class=""col-sm-3 control-label no-padding-right"" for=""ddlCCountry"">Country</label>
                                            <div class=""col-sm-9"">
                                                <select class=""chosen-select form-control"" id=""ddlCCountry"" data-placeholder=""Choose a Country"">");
            WriteLiteral(@"
                                                </select>
                                            </div>
                                        </div>
                                        <div class=""form-group"">
                                            <label class=""col-sm-3 control-label no-padding-right"" for=""txtCPostalCode"">Postal Code</label>
                                            <div class=""col-sm-9"">
                                                <input type=""text"" class=""form-control"" id=""txtCPostalCode"" />
                                            </div>
                                        </div>
                                        <div class=""form-group"">
                                            <label class=""col-sm-3 control-label no-padding-right"" for=""ddlCTimeZone"">Time Zone</label>
                                            <div class=""col-sm-9"">
                                                <select class=""chosen-select form-control"" id=""ddlCTimeZo");
            WriteLiteral(@"ne"" data-placeholder=""Choose a Time zone"">
                                                </select>
                                            </div>
                                        </div>
                                        <div class=""form-group"">
                                            <label class=""col-sm-3 control-label no-padding-right"" for=""txtLatitude"">Latitude</label>
                                            <div class=""col-sm-4"">
                                                <input type=""text"" class=""form-control"" id=""txtCLatitude"" />
                                            </div>
                                            <div class=""col-sm-2"">
                                                <input type=""text"" class=""form-control"" id=""txtCLatLocator"" disabled />
                                            </div>
                                            <div class=""col-sm-3"">
                                                <input type=""text"" class=""form-co");
            WriteLiteral(@"ntrol"" id=""txtCDMSLat"" disabled />
                                            </div>
                                        </div>
                                        <div class=""form-group"">
                                            <label class=""col-sm-3 control-label no-padding-right"" for=""txtLongitude"">Longitude</label>
                                            <div class=""col-sm-4"">
                                                <input type=""text"" class=""form-control"" id=""txtCLongitude"" />
                                            </div>
                                            <div class=""col-sm-2"">
                                                <input type=""text"" class=""form-control"" id=""txtCLngLocator"" disabled />
                                            </div>
                                            <div class=""col-sm-3"">
                                                <input type=""text"" class=""form-control"" id=""txtCDMSLong"" disabled />
                           ");
            WriteLiteral(@"                 </div>
                                        </div>

                                        <div class=""form-group"">
                                            <label class=""col-sm-3 control-label no-padding-right"" for=""txtCPhoneNumber"">Phone Number</label>
                                            <div class=""col-sm-9"">
                                                <input type=""text"" class=""form-control"" id=""txtCPhoneNumber"" />
                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </div>
                            <div class=""modal-footer"">
                                <button type=""button"" class=""btn btn-success"" id=""btnSaveCurrentAddress"">Save</button>
                                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                            </div>
          ");
            WriteLiteral("              </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <!-- /.row -->\r\n            <div class=\"row\">\r\n                <div class=\"col-xs-12 col-sm-12 mb-2 mt-2\">\r\n");
            WriteLiteral(@"                    <div class=""center"">
                        <a class=""btn btn-warning"">
                            <i class=""ace-icon fa fa-area-chart""></i>
                            View Chart
                        </a>
                        <button class=""btn btn-success"" type=""submit"">
                            <i class=""ace-icon fa fa-save""></i>
                            Confirm & Save
                        </button>
                        <a class=""btn  btn-info2"" id=""btnViewMap"">
                            <i class=""ace-icon fa fa-map-marker""></i>
                            Show Map
                        </a>
                        <a class=""btn  btn-inverse"" href=""/client/chartholder"">
                            <i class=""ace-icon fa fa-arrow-left""></i>
                            Back
                        </a>
                    </div>
");
            WriteLiteral(@"                </div>

            </div>
        </form>
        <div class=""row"">
            <div class=""col-xs-12 pl-2 pr-2"">
                <div class=""widget-box"">
                    <div class=""widget-header"">
                        <h4 class=""widget-title"">Select Custom Address And Date - Time </h4>
                    </div>

                    <div class=""widget-body"">
                        <div class=""widget-main"">
                            <div class=""form-group form-group col-sm-12 mb-10"">
                                <label class=""col-sm-3 control-label  align-right mt-5"" for=""txtCurrentDateTime"">Current Date Time :</label>
                                <div class=""col-sm-5"">
                                    <input type=""text"" class=""form-control"" id=""txtCurrentDateTime"" />
                                </div>
                                <div class=""col-sm-4"">
                                    <a class=""btn btn-sm btn-success"" id=""btnCreateAddress"">
 ");
            WriteLiteral(@"                                       <i class=""ace-icon fa fa-plus-circle""></i>
                                        Create New
                                    </a>
                                </div>
                            </div>
                            <table id=""simple-table"" class=""table table-striped table-bordered table-hover"">
                                <thead>
                                    <tr>
                                        <th>Select</th>
                                        <th>Address</th>
                                        <th>City</th>
                                        <th>State</th>
                                        <th>Country</th>
                                        <th>PostalCode</th>
                                        <th>Phone Number</th>
                                        <th>Edit</th>
                                    </tr>
                                </thead>

                            ");
            WriteLiteral(@"    <tbody id=""tblListBody"">
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>

            </div>

        </div>
    </div>
</div>

<script type=""text/x-jquery-tmpl"" id=""tmpltblList"">
    <tr>
        <td class=""center"">
            <label class=""pos-rel"">
                <input type=""checkbox"" class=""ace"" />
                <span class=""lbl""></span>
            </label>
        </td>
        <td>${wrAddress}</td>
        <td>${wrCity}</td>
        <td>${wrState}</td>
        <td>${wrCountry}</td>
        <td>${wrPostalCode}</td>
        <td>${wrPhoneNumber}</td>
        <td>
            <div class=""hidden-sm hidden-xs btn-group"">
                <a class=""btn btn-xs btn-success tooltip-success"" id=""btnupdate-${wrCurrentAddressID}"" onmouseover=""showToolTip(this)"" data-placement=""top"" data-original-title=""Update"" onclick=""getCurrentAddressValue('${wrCurrentAddressID}');"">");
            WriteLiteral("\n                    <i class=\"ace-icon fa fa-pencil bigger-120\"></i>\r\n                </a>\r\n            </div>\r\n        </td>\r\n    </tr>\r\n\r\n</script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82f79ce30975c7284ddbb7276fb02598e529ec7c29738", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 25788, "~/js/Page/ChartHolder/ChartHolderDetail.js?v=", 25788, 45, true);
#nullable restore
#line 436 "D:\WinappTech\Project\Upwork\Raj_Rajendram\CosmicGame_NetCore_Bitbucket\WebUI\Areas\Client\Views\ChartHolder\ChartHolderDetail.cshtml"
AddHtmlAttributeValue("", 25833, Utility.GlobalVars.siteVersion, 25833, 31, false);

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
            WriteLiteral("\r\n<script type=\"text/javascript\" src=\"https://maps.googleapis.com/maps/api/js?key=AIzaSyCFu1GOWyVu9Wc4GGP34PFjJpeo-a1PjDM\"></script>\r\n");
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
