#pragma checksum "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b4e7da443fbfe9d301a008fab2739dc05e81964"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exam_Test), @"mvc.1.0.view", @"/Views/Exam/Test.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Exam/Test.cshtml", typeof(AspNetCore.Views_Exam_Test))]
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
#line 1 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\_ViewImports.cshtml"
using EyeQuiz.Managment;

#line default
#line hidden
#line 2 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\_ViewImports.cshtml"
using EyeQuiz.Managment.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b4e7da443fbfe9d301a008fab2739dc05e81964", @"/Views/Exam/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6c8e2f28df5734c6a71311c46244f0b7aa8c72c", @"/Views/_ViewImports.cshtml")]
    public class Views_Exam_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EyeQuiz.Managment.Entites.Question>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SetAnswer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Exam", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mineForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"
  
    ViewData["Title"] = "Test";

#line default
#line hidden
            BeginContext(96, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(98, 1956, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b4e7da443fbfe9d301a008fab2739dc05e819644796", async() => {
                BeginContext(177, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 7 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"
      
        int i = 0;
        int count = 1;
    

#line default
#line hidden
                BeginContext(238, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 11 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"
     foreach (var question in Model)
    {


#line default
#line hidden
                BeginContext(285, 93, true);
                WriteLiteral("        <div>\r\n            <div class=\"alert alert-dark mt-5\" role=\"alert\">\r\n                ");
                EndContext();
                BeginContext(379, 5, false);
#line 16 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"
           Write(count);

#line default
#line hidden
                EndContext();
                BeginContext(384, 3, true);
                WriteLiteral(" . ");
                EndContext();
                BeginContext(388, 21, false);
#line 16 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"
                    Write(question.QuestionName);

#line default
#line hidden
                EndContext();
                BeginContext(409, 126, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-check\">\r\n                <input class=\"form-check-input\" group type=\"radio\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 535, "\"", 552, 3);
                WriteAttributeValue("", 542, "answer[", 542, 7, true);
#line 19 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"
WriteAttributeValue("", 549, i, 549, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 551, "]", 551, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", "  value=\"", 553, "\"", 613, 1);
#line 19 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"
WriteAttributeValue("", 562, question.AnswerA!=null ? question.AnswerA : null, 562, 51, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(614, 88, true);
                WriteLiteral(">\r\n                <label class=\"form-check-label\" for=\"answer\">\r\n                      ");
                EndContext();
                BeginContext(703, 16, false);
#line 21 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"
                 Write(question.AnswerA);

#line default
#line hidden
                EndContext();
                BeginContext(719, 148, true);
                WriteLiteral("\r\n                </label>\r\n            </div>\r\n\r\n            <div class=\"form-check\">\r\n                <input class=\"form-check-input\" type=\"radio\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 867, "\"", 884, 3);
                WriteAttributeValue("", 874, "answer[", 874, 7, true);
#line 26 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"
WriteAttributeValue("", 881, i, 881, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 883, "]", 883, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", "  value=\"", 885, "\"", 945, 1);
#line 26 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"
WriteAttributeValue("", 894, question.AnswerB!=null ? question.AnswerB : null, 894, 51, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(946, 87, true);
                WriteLiteral(">\r\n                <label class=\"form-check-label\" for=\"answer\">\r\n                     ");
                EndContext();
                BeginContext(1034, 16, false);
#line 28 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"
                Write(question.AnswerB);

#line default
#line hidden
                EndContext();
                BeginContext(1050, 150, true);
                WriteLiteral("\r\n                </label>\r\n            </div>\r\n\r\n\r\n            <div class=\"form-check\">\r\n                <input class=\"form-check-input\" type=\"radio\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1200, "\"", 1217, 3);
                WriteAttributeValue("", 1207, "answer[", 1207, 7, true);
#line 34 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"
WriteAttributeValue("", 1214, i, 1214, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 1216, "]", 1216, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1218, "\"", 1277, 1);
#line 34 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"
WriteAttributeValue("", 1226, question.AsnwerC!=null ? question.AsnwerC : null, 1226, 51, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1278, 87, true);
                WriteLiteral(">\r\n                <label class=\"form-check-label\" for=\"answer\">\r\n                     ");
                EndContext();
                BeginContext(1366, 16, false);
#line 36 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"
                Write(question.AsnwerC);

#line default
#line hidden
                EndContext();
                BeginContext(1382, 148, true);
                WriteLiteral("\r\n                </label>\r\n            </div>\r\n\r\n            <div class=\"form-check\">\r\n                <input class=\"form-check-input\" type=\"radio\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1530, "\"", 1547, 3);
                WriteAttributeValue("", 1537, "answer[", 1537, 7, true);
#line 41 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"
WriteAttributeValue("", 1544, i, 1544, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 1546, "]", 1546, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1548, "\"", 1607, 1);
#line 41 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"
WriteAttributeValue("", 1556, question.AnswerD!=null ? question.AnswerD : null, 1556, 51, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1608, 87, true);
                WriteLiteral(">\r\n                <label class=\"form-check-label\" for=\"answer\">\r\n                     ");
                EndContext();
                BeginContext(1696, 16, false);
#line 43 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"
                Write(question.AnswerD);

#line default
#line hidden
                EndContext();
                BeginContext(1712, 80, true);
                WriteLiteral("\r\n                </label>\r\n            </div>\r\n            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1792, "\"", 1809, 3);
                WriteAttributeValue("", 1799, "answer[", 1799, 7, true);
#line 46 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"
WriteAttributeValue("", 1806, i, 1806, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 1808, "]", 1808, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1810, "\"", 1823, 1);
#line 46 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"
WriteAttributeValue("", 1818, null, 1818, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1824, 21, true);
                WriteLiteral(" />\r\n        </div>\r\n");
                EndContext();
#line 48 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"



        i++;
        count++;

        
    }

#line default
#line hidden
                BeginContext(1902, 94, true);
                WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary\">Calculate Result!!!</button>\r\n    <h1>Score:");
                EndContext();
                BeginContext(1997, 14, false);
#line 57 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"
         Write(ViewBag.Result);

#line default
#line hidden
                EndContext();
                BeginContext(2011, 11, true);
                WriteLiteral("  Message: ");
                EndContext();
                BeginContext(2023, 17, false);
#line 57 "C:\Users\Murad\Downloads\EyeQuiz.Managment\EyeQuiz.Managment\Views\Exam\Test.cshtml"
                                   Write(TempData["Valid"]);

#line default
#line hidden
                EndContext();
                BeginContext(2040, 7, true);
                WriteLiteral("</h1>\r\n");
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2054, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EyeQuiz.Managment.Entites.Question>> Html { get; private set; }
    }
}
#pragma warning restore 1591
