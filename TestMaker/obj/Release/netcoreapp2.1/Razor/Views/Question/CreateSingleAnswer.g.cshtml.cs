#pragma checksum "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Question\CreateSingleAnswer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1b238020c4b38396acbc1c5f49b0a8baaa4d289"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Question_CreateSingleAnswer), @"mvc.1.0.view", @"/Views/Question/CreateSingleAnswer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Question/CreateSingleAnswer.cshtml", typeof(AspNetCore.Views_Question_CreateSingleAnswer))]
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
#line 2 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\_ViewImports.cshtml"
using TestMaker.Models;

#line default
#line hidden
#line 3 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\_ViewImports.cshtml"
using TestMaker.ViewModels;

#line default
#line hidden
#line 4 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1b238020c4b38396acbc1c5f49b0a8baaa4d289", @"/Views/Question/CreateSingleAnswer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bc10e74c8a7c33899ebdcc776e44546a0ef5fb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Question_CreateSingleAnswer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuestionViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Question", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateSingleAnswer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Question\CreateSingleAnswer.cshtml"
   ViewData["Title"] = "Create New Question"; 

#line default
#line hidden
            BeginContext(77, 37, true);
            WriteLiteral("<div id=\"app\">\r\n    <v-app>\r\n        ");
            EndContext();
            BeginContext(115, 71, false);
#line 6 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Question\CreateSingleAnswer.cshtml"
   Write(await Html.PartialAsync("~/Views/Shared/_RightSidePanelPartial.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(186, 558, true);
            WriteLiteral(@"
        <v-content>
            <v-container align-center justify-end row fill-height>
                <v-layout xs12 sm8 md6>
                    <v-flex>
                        <v-card class=""elevation-15"">
                            <v-toolbar color=""deep-orange darken-3"">
                                <v-toolbar-title>Add new single answer question</v-toolbar-title>
                                <v-spacer></v-spacer>
                            </v-toolbar>
                            <v-card-text>
                                ");
            EndContext();
            BeginContext(744, 648, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "514fbbc0def94ca7a2db184d371eccb7", async() => {
                BeginContext(822, 95, true);
                WriteLiteral("\r\n                                    <v-text-field label=\"TestId\" model=\"TestId\" name=\"TestId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 917, "\"", 960, 1);
#line 18 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Question\CreateSingleAnswer.cshtml"
WriteAttributeValue("", 925, ViewContext.RouteData.Values["id"], 925, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(961, 309, true);
                WriteLiteral(@" readonly v-show=""false""></v-text-field>
                                    <v-text-field model=""Text"" name=""text"" label=""Input question"" clearable></v-text-field>
                                    <v-btn color=""blue darken-1"" type=""submit"">Add</v-btn>
                                    <v-btn tag=""a""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1270, "\"", 1325, 2);
                WriteAttributeValue("", 1277, "/Test/Result/", 1277, 13, true);
#line 21 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Question\CreateSingleAnswer.cshtml"
WriteAttributeValue("", 1290, ViewContext.RouteData.Values["id"], 1290, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1326, 59, true);
                WriteLiteral(" color=\"red\">Back</v-btn>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1392, 217, true);
            WriteLiteral("\r\n                            </v-card-text>\r\n                        </v-card>\r\n                    </v-flex>\r\n                </v-layout>\r\n            </v-container>\r\n\r\n        </v-content>\r\n    </v-app>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1626, 1890, true);
                WriteLiteral(@"
    <script>
        var app = new Vue({
            el: '#app',
                        data() {
                            return {
                                drawer: true,
                                itemsForMembers: [
                                    { title: ""Home"", link: ""/Home/Index/"", icon: ""home"", id: ""homeBtn"" },
                                    { title: ""Create test"", link: ""/Test/CreateTest/"", icon: ""ballot"" },
                                    { title: ""Graphs"", link: ""/Test/Graphs/"", icon: ""equalizer"" }

                                ],
                                itemsLoginPartial: [
                                    { title: ""Login"", link: ""/Account/Login/"" },
                                    { title: ""Register"", link: ""/Account/Register/"" }
                                ],
                                itemsForAdmins: [
                                    { title: ""Home"", link: ""/Home/Index/"", icon: ""home"" },
                               ");
                WriteLiteral(@"     { title: ""Manage user roles"", link: ""/Admin/ManageUserRoles/"", icon: ""dashboard"" },
                                    { title: ""Manage users"", link: ""/Admin/Members/"", icon: ""people"" }
                                ],
                                headers: [
                                    { text: ""Title"", align: ""center"", sortable: false, value: ""title"" },
                                    { text: ""Description"", value: ""description"" },
                                    { text: ""Create date"", value: ""createDate"" },
                                    { text: ""Last modified date"", value: ""lastMD"" },
                                ],
                                tests: [],
                                dropDownFromResult: [
                                    { title: ""Single answer"", link: ""/Question/CreateSingleAnswer/");
                EndContext();
                BeginContext(3517, 34, false);
#line 63 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Question\CreateSingleAnswer.cshtml"
                                                                                             Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(3551, 102, true);
                WriteLiteral("\" },\r\n                                    { title: \"Short answer\", link: \"/Question/CreateShortAnswer/");
                EndContext();
                BeginContext(3654, 34, false);
#line 64 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Question\CreateSingleAnswer.cshtml"
                                                                                           Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(3688, 108, true);
                WriteLiteral("\" },\r\n                                    { title: \"Multiple choice\", link: \"/Question/CreateMultipleChoice/");
                EndContext();
                BeginContext(3797, 34, false);
#line 65 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Question\CreateSingleAnswer.cshtml"
                                                                                                 Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(3831, 104, true);
                WriteLiteral("\" },\r\n                                    { title: \"Range answer\", link: \"/Question/CreateRangeQuestion/");
                EndContext();
                BeginContext(3936, 34, false);
#line 66 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Question\CreateSingleAnswer.cshtml"
                                                                                             Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(3970, 125, true);
                WriteLiteral("\" }\r\n                                ]\r\n                            }\r\n                        }\r\n        })\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(4098, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuestionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
