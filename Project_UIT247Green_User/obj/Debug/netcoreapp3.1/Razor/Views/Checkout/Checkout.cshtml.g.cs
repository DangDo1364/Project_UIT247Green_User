#pragma checksum "C:\Users\dangdo1364\Desktop\Project_UIT247Green_User\Project_UIT247Green_User\Views\Checkout\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4220b19b9fdb559980ce3b2e42f872e013851166"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_Checkout), @"mvc.1.0.view", @"/Views/Checkout/Checkout.cshtml")]
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
#line 1 "C:\Users\dangdo1364\Desktop\Project_UIT247Green_User\Project_UIT247Green_User\Views\_ViewImports.cshtml"
using Project_UIT247Green_User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dangdo1364\Desktop\Project_UIT247Green_User\Project_UIT247Green_User\Views\_ViewImports.cshtml"
using Project_UIT247Green_User.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4220b19b9fdb559980ce3b2e42f872e013851166", @"/Views/Checkout/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"201d0a56ecb2a413f867885e113dfd4d715e426f", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3513", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3514", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3515", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3516", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("res layout-subpage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4220b19b9fdb559980ce3b2e42f872e0138511665125", async() => {
                WriteLiteral(@"
	
	<!-- Main Container  -->
	<div class=""main-container container"">
		<ul class=""breadcrumb"">
			<li><a href=""#""><i class=""fa fa-home""></i></a></li>
			<li><a href=""#"">Thanh toán</a></li>
			
		</ul>
		
		<div class=""row"">
			<!--Middle Part Start-->
			<div id=""content"" class=""col-sm-12"">
			  <h2 class=""title"">Thanh toán</h2>
			  <div class=""so-onepagecheckout "">
				<div class=""col-left col-sm-3"">
				  <div class=""panel panel-default"">
					<div class=""panel-heading"">
					  <h4 class=""panel-title""><i class=""fa fa-sign-in""></i> Chưa là thành viên?</h4>
					</div>
					  <div class=""panel-body"">
							<div class=""radio"">
							  <label>
								<input type=""radio"" value=""register"" name=""account"">
								Tạo tài khoản</label>
							</div>
							<!-- <div class=""radio"">
							  <label>
								<input type=""radio"" checked=""checked"" value=""guest"" name=""account"">
								Đăng nhập</label>
							</div> -->
							<div class=""radio"">
							  <label>
								<input type=");
                WriteLiteral(@"""radio"" value=""returning"" name=""account"">
								Khách vãng lai</label>
							</div>
							<br>
					  </div>
				  </div>
				  <div class=""panel panel-default"">
					<div class=""panel-heading"">
					  <h4 class=""panel-title""><i class=""fa fa-user""></i> Thông tin khách hàng</h4>
					</div>
					  <div class=""panel-body"">
							<fieldset id=""account"">
							  <div class=""form-group required"">
								<label for=""input-payment-firstname"" class=""control-label"">Họ tên</label>
								<input type=""text"" class=""form-control"" id=""input-payment-firstname"" placeholder=""Họ tên""");
                BeginWriteAttribute("value", " value=\"", 1781, "\"", 1789, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""firstname"">
							  </div>
							  <!-- <div class=""form-group required"">
								<label for=""input-payment-lastname"" class=""control-label"">Last Name</label>
								<input type=""text"" class=""form-control"" id=""input-payment-lastname"" placeholder=""Last Name"" value="""" name=""lastname"">
							  </div> -->
							  <div class=""form-group required"">
								<label for=""input-payment-email"" class=""control-label"">E-mail</label>
								<input type=""text"" class=""form-control"" id=""input-payment-email"" placeholder=""E-mail""");
                BeginWriteAttribute("value", " value=\"", 2325, "\"", 2333, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""email"">
							  </div>
							  <div class=""form-group required"">
								<label for=""input-payment-telephone"" class=""control-label"">Số điện thoại</label>
								<input type=""text"" class=""form-control"" id=""input-payment-telephone"" placeholder=""Số điện thoại""");
                BeginWriteAttribute("value", " value=\"", 2605, "\"", 2613, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"telephone\">\r\n\t\t\t\t\t\t\t  </div>\r\n\t\t\t\t\t\t\t  <div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<label for=\"input-payment-fax\" class=\"control-label\">Tên tài khoản</label>\r\n\t\t\t\t\t\t\t\t<input type=\"text\" class=\"form-control\" id=\"input-payment-fax\" placeholder=\"Tên tài khoản\"");
                BeginWriteAttribute("value", " value=\"", 2868, "\"", 2876, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""fax"">
							  </div>
							</fieldset>
						  </div>
				  </div>
				  <div class=""panel panel-default"">
					<div class=""panel-heading"">
					  <h4 class=""panel-title""><i class=""fa fa-book""></i> Địa chỉ giao hàng</h4>
					</div>
					  <div class=""panel-body"">
							<fieldset id=""address"" class=""required"">
							  <!-- <div class=""form-group"">
								<label for=""input-payment-company"" class=""control-label"">Company</label>
								<input type=""text"" class=""form-control"" id=""input-payment-company"" placeholder=""Company"" value="""" name=""company"">
							  </div> -->
							  <div class=""form-group"">
								<label for=""input-payment-address-1"" class=""control-label"">Số nhà / Tên đường</label>
								<input type=""text"" class=""form-control"" id=""input-payment-address-1"" placeholder=""Số nhà / Tên đường""");
                BeginWriteAttribute("value", " value=\"", 3715, "\"", 3723, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""address_1"">
							  </div>
							  <div class=""form-group required"">
								<label for=""input-payment-address-2"" class=""control-label"">Xã / Phường</label>
								<input type=""text"" class=""form-control"" id=""input-payment-address-2"" placeholder=""Xã / Phường""");
                BeginWriteAttribute("value", " value=\"", 3995, "\"", 4003, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""address_2"">
							  </div>
							  <div class=""form-group required"">
								<label for=""input-payment-city"" class=""control-label"">Quận / Huyện</label>
								<input type=""text"" class=""form-control"" id=""input-payment-city"" placeholder=""Quận / Huyện""");
                BeginWriteAttribute("value", " value=\"", 4267, "\"", 4275, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"city\">\r\n\t\t\t\t\t\t\t  </div>\t\r\n\t\t\t\t\t\t\t  <div class=\"form-group required\">\r\n\t\t\t\t\t\t\t\t<label for=\"input-payment-zone\" class=\"control-label\">Tỉnh</label>\r\n\t\t\t\t\t\t\t\t<select class=\"form-control\" id=\"input-payment-zone\" name=\"zone_id\">\r\n\t\t\t\t\t\t\t\t  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4220b19b9fdb559980ce3b2e42f872e01385116611121", async() => {
                    WriteLiteral(" --- Vui lòng chọn --- ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4220b19b9fdb559980ce3b2e42f872e01385116612380", async() => {
                    WriteLiteral("Vĩnh Long");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4220b19b9fdb559980ce3b2e42f872e01385116613625", async() => {
                    WriteLiteral("Bạc Liêu");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4220b19b9fdb559980ce3b2e42f872e01385116614869", async() => {
                    WriteLiteral("Quãng Ngãi");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4220b19b9fdb559980ce3b2e42f872e01385116616115", async() => {
                    WriteLiteral("TP. Hồ Chí Minh");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"							  
								</select>
							  </div>
							  <!-- <div class=""checkbox"">
								<label>
								  <input type=""checkbox"" checked=""checked"" value=""1"" name=""shipping_address"">
								  My delivery and billing addresses are the same.</label>
							  </div> -->
							</fieldset>
						  </div>
				  </div>
				</div>
				<div class=""col-right col-sm-9"">
				  <div class=""row"">
					<div class=""col-sm-12"">
						<div class=""panel panel-default no-padding"">
							<div class=""col-sm-6 checkout-shipping-methods"">
								<div class=""panel-heading"">
								  <h4 class=""panel-title""><i class=""fa fa-truck""></i> Phương thức vận chuyển</h4>
								</div>
								<div class=""panel-body "">
									<p>Vui lòng chọn phương thức vận chuyển mà bạn mong muốn.</p>
									<div class=""radio"">
									  <label>
										<input type=""radio"" checked=""checked"" name=""Free Shipping"">
										Vận chuyển tiết kiệm</label>
									</div>
									<div class=""radio"">
									  <label>
				");
                WriteLiteral(@"						<input type=""radio"" name=""Fast Shipping"">
										Vận chuyển trong 2h</label>
									</div>
									
								</div>
							</div>
							<div class=""col-sm-6  checkout-payment-methods"">
								<div class=""panel-heading"">
								  <h4 class=""panel-title""><i class=""fa fa-credit-card""></i> Phương thức thanh toán</h4>
								</div>
								<div class=""panel-body"">
									<p>Vui lòng chọn phương thức thanh toán mà bạn mong muốn.</p>
									<div class=""radio"">
									  <label>
										<input type=""radio"" checked=""checked"" name=""Cash On Delivery"">Tiền mặt</label>
									</div>
									
									<div class=""radio"">
									  <label>
										<input type=""radio"" name=""Paypal"">Thanh toán online</label>
									</div>
								</div>
							</div>
						</div>
						
					
					
					
					<div class=""col-sm-12"">
					  <div class=""panel panel-default"">
						<div class=""panel-heading"">
						  <h4 class=""panel-title""><i class=""fa fa-ticket""></i> Bạn có mã khuyến");
                WriteLiteral(" mãi?</h4>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t  <div class=\"panel-body row\">\r\n\t\t\t\t\t\t\t<div class=\"col-sm-6 \">\r\n\t\t\t\t\t\t\t<div class=\"input-group\">\r\n\t\t\t\t\t\t\t  <input type=\"text\" class=\"form-control\" id=\"input-coupon\" placeholder=\"Nhập mã khuyến mãi\"");
                BeginWriteAttribute("value", " value=\"", 7053, "\"", 7061, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""coupon"">
							  <span class=""input-group-btn"">
							  <input type=""button"" class=""btn btn-primary"" data-loading-text=""Loading..."" id=""button-coupon"" value=""Áp dụng"">
							  </span></div>
							</div>
							
							<div class=""col-sm-6"">
							<div class=""input-group"">
							  <input type=""text"" class=""form-control"" id=""input-voucher"" placeholder=""Nhập mã quà tặng""");
                BeginWriteAttribute("value", " value=\"", 7453, "\"", 7461, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""voucher"">
							  <span class=""input-group-btn"">
							  <input type=""submit"" class=""btn btn-primary"" data-loading-text=""Loading..."" id=""button-voucher"" value=""Áp dụng"">
							  </span> </div>
							</div>
						  </div>
					  </div>
					</div>
					
					<div class=""col-sm-12"">
					  <div class=""panel panel-default"">
						<div class=""panel-heading"">
						  <h4 class=""panel-title""><i class=""fa fa-shopping-cart""></i> Giỏ hàng</h4>
						</div>
						  <div class=""panel-body"">
							<div class=""table-responsive"">
							  <table class=""table table-bordered"">
								<thead>
								  <tr>
									<td class=""text-center"">Sản phẩm</td>
									<td class=""text-left"">Tên</td>
									<td class=""text-left"">Số lượng</td>
									<td class=""text-right"">Đơn giá</td>
									<td class=""text-right"">Tổng</td>
								  </tr>
								</thead>
								<tbody>
								  <tr>
									<td class=""text-center""><a href=""product.html""><img width=""60px"" src=""image/demo/shop/product");
                WriteLiteral(@"/E4.jpg"" alt=""sp1"" title=""sp1"" class=""img-thumbnail""></a></td>
									<td class=""text-left""><a href=""product.html"">Sản phẩm 1</a></td>
									<td class=""text-left""><div class=""input-group btn-block"" style=""min-width: 100px;"">
										<input type=""text"" name=""quantity"" value=""1"" size=""1"" class=""form-control"">
										<span class=""input-group-btn"">
										<button type=""submit"" data-toggle=""tooltip"" title=""Cập nhật"" class=""btn btn-primary""><i class=""fa fa-refresh""></i></button>
										<button type=""button"" data-toggle=""tooltip"" title=""Xóa"" class=""btn btn-danger""");
                BeginWriteAttribute("onClick", " onClick=\"", 9071, "\"", 9081, 0);
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fa fa-times-circle""></i></button>
										</span></div></td>
									<td class=""text-right"">100.000đ</td>
									<td class=""text-right"">100.000đ</td>
								  </tr>
								</tbody>
								<tfoot>
								  <tr>
									<td class=""text-right"" colspan=""4""><strong>Tổng sản phẩm:</strong></td>
									<td class=""text-right"">100.000đ</td>
								  </tr>
								  <tr>
									<td class=""text-right"" colspan=""4""><strong>Phí vận chuyển:</strong></td>
									<td class=""text-right"">30.000đ</td>
								  </tr>
								  <tr>
									<td class=""text-right"" colspan=""4""><strong>Tổng thanh toán:</strong></td>
									<td class=""text-right"">130.000đ</td>
								  </tr>
								</tfoot>
							  </table>
							</div>
						  </div>
					  </div>
					</div>
					<div class=""col-sm-12"">
					  <div class=""panel panel-default"">
						<div class=""panel-heading"">
						  <h4 class=""panel-title""><i class=""fa fa-pencil""></i> Thêm ghi chú cho đơn hàng</h4>
						</div>
				");
                WriteLiteral(@"		  <div class=""panel-body"">
							<textarea rows=""4"" class=""form-control"" id=""confirm_comment"" name=""comments""></textarea>
							<br>
							<label class=""control-label"" for=""confirm_agree"">
							  <input type=""checkbox"" checked=""checked"" value=""1""");
                BeginWriteAttribute("required", " required=\"", 10363, "\"", 10374, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""validate required"" id=""confirm_agree"" name=""confirm agree"">
							  <span>Tôi đã đọc và đồng ý với <a class=""agree"" href=""#""><b>Điều khoản & Chính sách</b></a></span> </label>
							<div class=""buttons"">
							  <div class=""pull-right"">
								<input type=""button"" class=""btn btn-primary"" id=""button-confirm"" value=""Xác nhận"">
							  </div>
							</div>
						  </div>
					  </div>
					</div>
				  </div>
				</div>
			  </div>
			</div>
			<!--Middle Part End -->
			
		</div>
	</div>
	<!-- //Main Container -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
