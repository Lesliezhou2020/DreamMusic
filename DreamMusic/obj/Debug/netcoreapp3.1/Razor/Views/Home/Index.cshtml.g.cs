#pragma checksum "/Users/leslie/Desktop/C#/DreamMusic/DreamMusic/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6eed716670eff4df56ce2628015b903f988fb71a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace MyApp.Namespace.Home
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
#line 2 "/Users/leslie/Desktop/C#/DreamMusic/DreamMusic/Views/_ViewImports.cshtml"
using DreamMusic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eed716670eff4df56ce2628015b903f988fb71a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dee33a698772d5380f5cc5b38c51abba09f7ef8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/script.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Beats", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6eed716670eff4df56ce2628015b903f988fb71a4653", async() => {
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <title>Welcome</title>\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css\">\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6eed716670eff4df56ce2628015b903f988fb71a5159", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <script src=\"https://code.jquery.com/jquery-3.5.1.min.js\" \n        integrity=\"sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0=\" \n        crossorigin=\"anonymous\"></script>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6eed716670eff4df56ce2628015b903f988fb71a6507", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6eed716670eff4df56ce2628015b903f988fb71a8280", async() => {
                WriteLiteral("\n    <div class=\"jumbotron\" id=\"meta_info\"");
                BeginWriteAttribute("user_id", " user_id=", 603, "", 632, 1);
#nullable restore
#line 15 "/Users/leslie/Desktop/C#/DreamMusic/DreamMusic/Views/Home/Index.cshtml"
WriteAttributeValue("", 612, ViewBag.user.UserId, 612, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n");
#nullable restore
#line 16 "/Users/leslie/Desktop/C#/DreamMusic/DreamMusic/Views/Home/Index.cshtml"
         if(ViewBag.user.UserId == -1)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p><a href=\"/sign\">Register/Login</a></p>\n");
#nullable restore
#line 19 "/Users/leslie/Desktop/C#/DreamMusic/DreamMusic/Views/Home/Index.cshtml"
        } else {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p>Welcome ");
#nullable restore
#line 20 "/Users/leslie/Desktop/C#/DreamMusic/DreamMusic/Views/Home/Index.cshtml"
                  Write(ViewBag.user.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("! <a href=\"/logout\">Logout</a></p>\n");
#nullable restore
#line 21 "/Users/leslie/Desktop/C#/DreamMusic/DreamMusic/Views/Home/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <h1>Dream Music</h1>
    </div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-4"">
                <h3 class=""text-center"">Top 10 Beats</h3>
                <p class=""text-center""><a href=""all"">View All</a></p>
                <table class=""table-dark table-striped"">
                    <tbody>
");
#nullable restore
#line 31 "/Users/leslie/Desktop/C#/DreamMusic/DreamMusic/Views/Home/Index.cshtml"
                         foreach (var item in ViewBag.toplist)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\n                                <td class=\"col-sm-8\"><a");
                BeginWriteAttribute("href", " href=\"", 1359, "\"", 1387, 2);
                WriteAttributeValue("", 1366, "/detail/", 1366, 8, true);
#nullable restore
#line 34 "/Users/leslie/Desktop/C#/DreamMusic/DreamMusic/Views/Home/Index.cshtml"
WriteAttributeValue("", 1374, item.SheetId, 1374, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 34 "/Users/leslie/Desktop/C#/DreamMusic/DreamMusic/Views/Home/Index.cshtml"
                                                                                Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\n                                <td class=\"col-sm-4\"><span class=\"badge badge-light\">");
#nullable restore
#line 35 "/Users/leslie/Desktop/C#/DreamMusic/DreamMusic/Views/Home/Index.cshtml"
                                                                                Write(item.Likes.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></td>\n                            </tr>\n");
#nullable restore
#line 37 "/Users/leslie/Desktop/C#/DreamMusic/DreamMusic/Views/Home/Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </tbody>
                </table>
            </div>
            <div class=""col-sm-8"">
                <h2>Compose your own Clap</h2>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">Crash</span>
                    </div>
                    <input type=""text"" class=""form-control"" aria-describedby=""basic-addon1""");
                BeginWriteAttribute("value", " value=", 2022, "", 2049, 1);
#nullable restore
#line 47 "/Users/leslie/Desktop/C#/DreamMusic/DreamMusic/Views/Home/Index.cshtml"
WriteAttributeValue("", 2029, ViewBag.sheet.Crash, 2029, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">Ride</span>
                    </div>
                    <input type=""text"" class=""form-control"" aria-describedby=""basic-addon1""");
                BeginWriteAttribute("value", " value=", 2355, "", 2381, 1);
#nullable restore
#line 53 "/Users/leslie/Desktop/C#/DreamMusic/DreamMusic/Views/Home/Index.cshtml"
WriteAttributeValue("", 2362, ViewBag.sheet.Ride, 2362, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">Floor Tom</span>
                    </div>
                    <input type=""text"" class=""form-control"" aria-describedby=""basic-addon1""");
                BeginWriteAttribute("value", " value=", 2692, "", 2722, 1);
#nullable restore
#line 59 "/Users/leslie/Desktop/C#/DreamMusic/DreamMusic/Views/Home/Index.cshtml"
WriteAttributeValue("", 2699, ViewBag.sheet.FloorTom, 2699, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">Mid Tom</span>
                    </div>
                    <input type=""text"" class=""form-control"" aria-describedby=""basic-addon1""");
                BeginWriteAttribute("value", " value=", 3031, "", 3059, 1);
#nullable restore
#line 65 "/Users/leslie/Desktop/C#/DreamMusic/DreamMusic/Views/Home/Index.cshtml"
WriteAttributeValue("", 3038, ViewBag.sheet.MidTom, 3038, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">High Tom</span>
                    </div>
                    <input type=""text"" class=""form-control"" aria-describedby=""basic-addon1""");
                BeginWriteAttribute("value", " value=", 3369, "", 3398, 1);
#nullable restore
#line 71 "/Users/leslie/Desktop/C#/DreamMusic/DreamMusic/Views/Home/Index.cshtml"
WriteAttributeValue("", 3376, ViewBag.sheet.HighTom, 3376, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">Kick</span>
                    </div>
                    <input type=""text"" class=""form-control"" aria-describedby=""basic-addon1""");
                BeginWriteAttribute("value", " value=", 3704, "", 3730, 1);
#nullable restore
#line 77 "/Users/leslie/Desktop/C#/DreamMusic/DreamMusic/Views/Home/Index.cshtml"
WriteAttributeValue("", 3711, ViewBag.sheet.Kick, 3711, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">Snare</span>
                    </div>
                    <input type=""text"" class=""form-control"" aria-describedby=""basic-addon1""");
                BeginWriteAttribute("value", " value=", 4037, "", 4064, 1);
#nullable restore
#line 83 "/Users/leslie/Desktop/C#/DreamMusic/DreamMusic/Views/Home/Index.cshtml"
WriteAttributeValue("", 4044, ViewBag.sheet.Snare, 4044, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">Hi-Hat Open</span>
                    </div>
                    <input type=""text"" class=""form-control"" aria-describedby=""basic-addon1""");
                BeginWriteAttribute("value", " value=", 4377, "", 4408, 1);
#nullable restore
#line 89 "/Users/leslie/Desktop/C#/DreamMusic/DreamMusic/Views/Home/Index.cshtml"
WriteAttributeValue("", 4384, ViewBag.sheet.HiHatOpen, 4384, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">Hi-Hat Close</span>
                    </div>
                    <input type=""text"" class=""form-control"" aria-describedby=""basic-addon1""");
                BeginWriteAttribute("value", " value=", 4722, "", 4754, 1);
#nullable restore
#line 95 "/Users/leslie/Desktop/C#/DreamMusic/DreamMusic/Views/Home/Index.cshtml"
WriteAttributeValue("", 4729, ViewBag.sheet.HiHatClose, 4729, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
                <br>
                <ul class=""nav nav-pills nav-fill col-sm-12"">
                    <li class=""nav-item col-sm-2"">
                        <button class=""btn btn-primary"" id=""play"">Play</button>
                    </li>
                    <li class=""nav-item col-sm-4"">
                        <label for=""interval"">Clap Interval (ms)</label>
                        <input type=""range"" class=""custom-range"" min=100 max=500 value=200 id=""interval""/>
                    </li>
                    <li class=""nav-item col-sm-4"">
                        <button class=""btn btn-info"" id=""save"">Save</button>
                    </li>
                </ul>
            </div>
        </div>
        <div class=""row"" id=""beats"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6eed716670eff4df56ce2628015b903f988fb71a19083", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        </div>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
