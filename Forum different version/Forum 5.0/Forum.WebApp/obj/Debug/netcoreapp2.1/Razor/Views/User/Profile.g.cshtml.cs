#pragma checksum "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9456b24de9541f7d8171aff2616558149931aa1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Profile), @"mvc.1.0.view", @"/Views/User/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Profile.cshtml", typeof(AspNetCore.Views_User_Profile))]
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
#line 1 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\_ViewImports.cshtml"
using Forum.WebApp;

#line default
#line hidden
#line 2 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\_ViewImports.cshtml"
using Forum.WebApp.Models;

#line default
#line hidden
#line 1 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml"
using Forum.WebModels.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9456b24de9541f7d8171aff2616558149931aa1", @"/Views/User/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c18d74d35fde3ded2999f2bf1caf1ea506efeff", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadPhoto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group w-50 text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ReplyToMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right; margin:1% 0 1% 1%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Message", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml"
  
    ViewData["Title"] = "Profile";
    var messageCount = ViewData["CountOfMessages"];
    List<PrivateMessageViewModel> privateMessages = ViewBag.PrivateMessages;
    List<UserViewModel> users = ViewBag.Users;

#line default
#line hidden
            BeginContext(279, 965, true);
            WriteLiteral(@"<br />
<h2 class=""text-center"" style=""font-family:Verdana; margin-left:10%"">Profile page</h2>
<br />
<br />
<div class=""row"">
    <div class=""col-sm-3"">
        <a href=""#"" class=""nav-tabs-dropdown btn btn-block btn-primary"">Menu</a>
        <ul id=""nav-tabs-wrapper"" class=""nav nav-tabs nav-pills nav-stacked well"">
            <li class=""active""><a href=""#vtab1"" data-toggle=""tab"">Info</a></li>
            <li><a href=""#vtab2"" data-toggle=""tab"">Edit profile</a></li>
            <li><a href=""#vtab3"" data-toggle=""tab"">Private messages</a></li>
        </ul>
    </div>
    <div class=""col-sm-9"">
        <div class=""tab-content"">
            <div role=""tabpanel"" class=""tab-pane fade active in"" id=""vtab1"">
                <table style=""margin-left:15%;"">
                    <tbody>
                        <tr>
                            <th style=""background: none""></th>
                            <td>
                                ");
            EndContext();
            BeginContext(1244, 494, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f784438a1e83449a8c1573282409572f", async() => {
                BeginContext(1341, 99, true);
                WriteLiteral("\r\n                                    <img style=\"width:130px; height:130px;border:1px solid white\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1440, "\"", 1459, 1);
#line 31 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml"
WriteAttributeValue("", 1446, Model.Avatar, 1446, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1460, 271, true);
                WriteLiteral(@" />
                                    <br />
                                    <br />
                                    <input type=""file"" name=""photo"" accept=""image/*"">
                                    <input type=""submit"">
                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1738, 307, true);
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <th style=""background:none; color:#df691a; font-size:1.9rem; text-align:right"">Name:</th>
                            <td style=""font-family:Verdana; font-size:1.9rem"">&nbsp;&nbsp;");
            EndContext();
            BeginContext(2046, 14, false);
#line 41 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml"
                                                                                     Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(2060, 281, true);
            WriteLiteral(@"</td>
                        </tr>
                        <tr>
                            <th style=""background:none; color:#df691a; font-size:1.9rem; text-align:right"">Username:</th>
                            <td style=""font-family:Verdana; font-size:1.9rem"">&nbsp;&nbsp;");
            EndContext();
            BeginContext(2342, 14, false);
#line 45 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml"
                                                                                     Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(2356, 279, true);
            WriteLiteral(@"</td>
                        </tr>
                        <tr>
                            <th style=""background:none; color:#df691a; font-size:1.9rem; text-align:right"">E-mail:</th>
                            <td style=""font-family:Verdana; font-size:1.9rem"">&nbsp;&nbsp;");
            EndContext();
            BeginContext(2636, 11, false);
#line 49 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml"
                                                                                     Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2647, 279, true);
            WriteLiteral(@"</td>
                        </tr>
                        <tr>
                            <th style=""background:none; color:#df691a; font-size:1.9rem; text-align:right"">Joined:</th>
                            <td style=""font-family:Verdana; font-size:1.9rem"">&nbsp;&nbsp;");
            EndContext();
            BeginContext(2927, 32, false);
#line 53 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml"
                                                                                     Write(Model.Joined.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2959, 278, true);
            WriteLiteral(@"</td>
                        </tr>
                        <tr>
                            <th style=""background:none; color:#df691a; font-size:1.9rem; text-align:right"">Posts:</th>
                            <td style=""font-family:Verdana; font-size:1.9rem"">&nbsp;&nbsp;");
            EndContext();
            BeginContext(3238, 19, false);
#line 57 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml"
                                                                                     Write(Model.Posts.Count());

#line default
#line hidden
            EndContext();
            BeginContext(3257, 285, true);
            WriteLiteral(@"</td>
                        </tr>
                    </tbody>
                </table>
            </div>
            <div role=""tabpanel"" class=""tab-pane fade"" id=""vtab2"">
                <h3 style=""margin-left:33%"">Edit Profile</h3>
                <br />
                ");
            EndContext();
            BeginContext(3542, 2019, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21a05c38aa2c4a6e95d7c96551b1f9fe", async() => {
                BeginContext(3644, 1910, true);
                WriteLiteral(@"
                    <div class=""form-group col-xs-5"">
                        <label for=""name"">First name</label>
                        <input type=""text"" class=""form-control"" name=""name"" id=""name"" placeholder=""Your First Name..."">
                    </div>
                    <div class=""form-group col-xs-5"">
                        <label for=""oldPassword"">Old Password</label>
                        <input type=""password"" class=""form-control"" name=""oldPassword"" id=""oldPassword"" placeholder=""Your old password..."">
                    </div>
                    <div class=""form-group col-xs-5"">
                        <label for=""surname"">Last name</label>
                        <input type=""text"" class=""form-control"" name=""surname"" id=""surname"" placeholder=""Your Last Name"">
                    </div>
                    <div class=""form-group col-xs-5"">
                        <label for=""newPassword"">New Password</label>
                        <input type=""password"" class=""form-contro");
                WriteLiteral(@"l"" name=""newPassword"" id=""newPassword"" placeholder=""Your new password..."">
                    </div>
                    <div class=""form-group col-xs-5"">
                        <label for=""email"">Email address</label>
                        <input type=""email"" class=""form-control"" name=""email"" id=""email"" aria-describedby=""emailHelp"" placeholder=""Your email..."">
                    </div>
                    <div class=""form-group col-xs-5"">
                        <label for=""confirmNewPassword"">Confirm New Password</label>
                        <input type=""password"" class=""form-control"" name=""confirmNewPassword"" id=""confirmNewPassword"" placeholder=""Confirm your new password"">
                    </div>
                    <div class=""form-group col-xs-5"" style=""width:83%""><button type=""submit"" class=""btn btn-primary"">Submit</button></div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5561, 184, true);
            WriteLiteral("\r\n            </div>\r\n            <div role=\"tabpanel\" class=\"tab-pane fade in\" id=\"vtab3\">\r\n                <h3 style=\"margin-left:29%\">Private messages</h3>\r\n                <br />\r\n");
            EndContext();
#line 96 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml"
                 if (privateMessages.Count() > 0)
                {

#line default
#line hidden
            BeginContext(5815, 96, true);
            WriteLiteral("                    <table style=\"margin-left:5%; width:70%\">\r\n                        <tbody>\r\n");
            EndContext();
#line 100 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml"
                             foreach (var message in privateMessages)
                            {
                                UserViewModel userCheck = users.FirstOrDefault(u => u.Username == message.From);
                                ViewData["MessageId"] = message.Id;
                                ViewData["From"] = message.From;
                                string messageId = $"#messageId{ViewData["MessageId"]}";


#line default
#line hidden
            BeginContext(6354, 170, true);
            WriteLiteral("                                <tr>\r\n                                    <th style=\"padding: 3%; border-top:1px solid #808080; border-left:1px solid #808080\">From:&nbsp;");
            EndContext();
            BeginContext(6525, 12, false);
#line 108 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml"
                                                                                                                               Write(message.From);

#line default
#line hidden
            EndContext();
            BeginContext(6537, 162, true);
            WriteLiteral("</th>\r\n                                    <th class=\"text-right\" style=\"padding: 3%; border-top:1px solid #808080; border-right:1px solid #808080\">Sent on:&nbsp;");
            EndContext();
            BeginContext(6700, 15, false);
#line 109 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml"
                                                                                                                                                      Write(message.Created);

#line default
#line hidden
            EndContext();
            BeginContext(6715, 263, true);
            WriteLiteral(@"</th>
                                </tr>
                                <tr>
                                    <td colspan=""2"" style=""background-color:#4e5d6c; color:white; padding: 3%; border:1px solid #808080"">
                                        ");
            EndContext();
            BeginContext(6979, 15, false);
#line 113 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml"
                                   Write(message.Content);

#line default
#line hidden
            EndContext();
            BeginContext(6994, 176, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td colspan=\"2\">\r\n");
            EndContext();
#line 118 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml"
                                         if (userCheck != null)
                                        {
                                            ViewData["receiverId"] = users.FirstOrDefault(u => u.Username == message.From).Id;


#line default
#line hidden
            BeginContext(7408, 150, true);
            WriteLiteral("                                            <a style=\"float:right; margin:1% 0 1% 1%\" class=\"btn btn-primary btn-xs\" data-toggle=\"modal\" data-target=\"");
            EndContext();
            BeginContext(7559, 9, false);
#line 122 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml"
                                                                                                                                                 Write(messageId);

#line default
#line hidden
            EndContext();
            BeginContext(7568, 57, true);
            WriteLiteral("\">Reply</a>\r\n                                            ");
            EndContext();
            BeginContext(7625, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "56e87aa3ebf44ef78fdf0d13c5839a2c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 123 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7680, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 124 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml"
                                        }

#line default
#line hidden
            BeginContext(7725, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(7765, 161, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d2bae0b80dd4b67a57a67e659272e30", async() => {
                BeginContext(7916, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 125 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml"
                                                                                                                                                                      WriteLiteral(message.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7926, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 128 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml"
                            }

#line default
#line hidden
            BeginContext(8041, 64, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
            EndContext();
#line 131 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(8165, 87, true);
            WriteLiteral("                    <h3 style=\"margin-left:18%\">You don\'t have private messages.</h3>\r\n");
            EndContext();
#line 135 "C:\Users\Asus\Desktop\forum\Forum\Forum different version\Forum 5.0\Forum.WebApp\Views\User\Profile.cshtml"
                }

#line default
#line hidden
            BeginContext(8271, 62, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591