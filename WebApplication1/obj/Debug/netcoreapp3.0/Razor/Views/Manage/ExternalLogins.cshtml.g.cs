#pragma checksum "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\ExternalLogins.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f741f209485ffb6dbb50aff17bbdf18fdf71791"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_ExternalLogins), @"mvc.1.0.view", @"/Views/Manage/ExternalLogins.cshtml")]
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
#line 1 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models.AccountViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models.ManagerViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\_ViewImports.cshtml"
using WebApplication1.Views.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f741f209485ffb6dbb50aff17bbdf18fdf71791", @"/Views/Manage/ExternalLogins.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f46e02bdc9e4c7612a7f277db91e1e02df45c29", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02bc5b606b5b42ccf216fca6fe41f058eeb162e4", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage_ExternalLogins : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExternalLoginsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "LoginProvider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ProviderKey", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LinkLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\ExternalLogins.cshtml"
  
    ViewData["Title"] = "Manage your external logins";
    ViewData.AddActivePage(ManageNavPages.ExternalLogins);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\ExternalLogins.cshtml"
Write(Html.Partial("_StatusMessage", Model.StatusMessage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\ExternalLogins.cshtml"
 if (Model.CurrentLogins?.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Registered Logins</h4>\r\n    <table class=\"table\">\r\n        <tbody>\r\n");
#nullable restore
#line 13 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\ExternalLogins.cshtml"
         foreach (var login in Model.CurrentLogins)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 16 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\ExternalLogins.cshtml"
               Write(login.LoginProvider);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 18 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\ExternalLogins.cshtml"
                     if (Model.ShowRemoveButton)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f741f209485ffb6dbb50aff17bbdf18fdf717918406", async() => {
                WriteLiteral("\r\n                            <div>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0f741f209485ffb6dbb50aff17bbdf18fdf717918733", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 22 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.LoginProvider);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0f741f209485ffb6dbb50aff17bbdf18fdf7179110693", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 23 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.ProviderKey);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <button type=\"submit\" class=\"btn btn-default\"");
                BeginWriteAttribute("title", " title=\"", 949, "\"", 1013, 7);
                WriteAttributeValue("", 957, "Remove", 957, 6, true);
                WriteAttributeValue(" ", 963, "this", 964, 5, true);
#nullable restore
#line 24 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\ExternalLogins.cshtml"
WriteAttributeValue(" ", 968, login.LoginProvider, 969, 20, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 989, "login", 990, 6, true);
                WriteAttributeValue(" ", 995, "from", 996, 5, true);
                WriteAttributeValue(" ", 1000, "your", 1001, 5, true);
                WriteAttributeValue(" ", 1005, "account", 1006, 8, true);
                EndWriteAttribute();
                WriteLiteral(">Remove</button>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\ExternalLogins.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral(" &nbsp;\r\n");
#nullable restore
#line 31 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\ExternalLogins.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\ExternalLogins.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 37 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\ExternalLogins.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\ExternalLogins.cshtml"
 if (Model.OtherLogins?.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Add another service to log in.</h4>\r\n    <hr />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f741f209485ffb6dbb50aff17bbdf18fdf7179116348", async() => {
                WriteLiteral("\r\n        <div id=\"socialLoginList\">\r\n            <p>\r\n");
#nullable restore
#line 45 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\ExternalLogins.cshtml"
                 foreach (var provider in Model.OtherLogins)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <button type=\"submit\" class=\"btn btn-default\" name=\"provider\"");
                BeginWriteAttribute("value", " value=\"", 1703, "\"", 1725, 1);
#nullable restore
#line 47 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\ExternalLogins.cshtml"
WriteAttributeValue("", 1711, provider.Name, 1711, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 1726, "\"", 1781, 6);
                WriteAttributeValue("", 1734, "Log", 1734, 3, true);
                WriteAttributeValue(" ", 1737, "in", 1738, 3, true);
                WriteAttributeValue(" ", 1740, "using", 1741, 6, true);
                WriteAttributeValue(" ", 1746, "your", 1747, 5, true);
#nullable restore
#line 47 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\ExternalLogins.cshtml"
WriteAttributeValue(" ", 1751, provider.DisplayName, 1752, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1773, "account", 1774, 8, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 47 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\ExternalLogins.cshtml"
                                                                                                                                                            Write(provider.DisplayName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n");
#nullable restore
#line 48 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\ExternalLogins.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </p>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 52 "C:\Users\Adria\source\repos\WebApplication1\WebApplication1\Views\Manage\ExternalLogins.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExternalLoginsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
