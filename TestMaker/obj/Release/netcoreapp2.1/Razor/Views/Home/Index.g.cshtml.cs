#pragma checksum "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c69f4bc88ee5866a13ce086e0fddfa2781661a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c69f4bc88ee5866a13ce086e0fddfa2781661a2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bc10e74c8a7c33899ebdcc776e44546a0ef5fb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Test>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteTest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Test", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(65, 39, true);
            WriteLiteral("\r\n<div id=\"app\">\r\n    <v-app>\r\n        ");
            EndContext();
            BeginContext(105, 71, false);
#line 8 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Home\Index.cshtml"
   Write(await Html.PartialAsync("~/Views/Shared/_RightSidePanelPartial.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(176, 1442, true);
            WriteLiteral(@"
        <v-content>
            <v-container align-center justify-end row fill-height>
                <v-layout xs12 sm8 md6>
                    <v-flex>
                        <v-card class=""elevation-15"">
                            <v-toolbar color=""deep-orange darken-3"">
                                <v-toolbar-title>My tests</v-toolbar-title>
                                <v-spacer></v-spacer>
                            </v-toolbar>
                            <div class=""text-md-center"">
                                <v-card-text>
                                    <v-container fluid grid-list-xl>
                                        <v-layout align-center justify-center row fill-height>
                                            <v-flex xs3>
                                                <v-card-text>Title</v-card-text>
                                            </v-flex>
                                            <v-flex xs3>
                                       ");
            WriteLiteral(@"         <v-card-text>Description</v-card-text>
                                            </v-flex>
                                            <v-flex xs6>
                                                <v-card-text>Action</v-card-text>
                                            </v-flex>
                                        </v-layout>
                                        <v-divider></v-divider>
");
            EndContext();
#line 33 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Home\Index.cshtml"
                                         foreach (var test in Model)
                                        {

#line default
#line hidden
            BeginContext(1731, 274, true);
            WriteLiteral(@"                                            <v-layout align-content-center justify-center row fill-height>
                                                <v-flex xs3>
                                                    <v-btn outline tag=""a"" color=""deep-purple lighten-1""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2005, "\"", 2033, 2);
            WriteAttributeValue("", 2012, "/Test/Result/", 2012, 13, true);
#line 37 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Home\Index.cshtml"
WriteAttributeValue("", 2025, test.Id, 2025, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2034, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2036, 10, false);
#line 37 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Home\Index.cshtml"
                                                                                                                                 Write(test.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2046, 196, true);
            WriteLiteral("</v-btn>\r\n                                                </v-flex>\r\n                                                <v-flex xs3>\r\n                                                    <v-card-text>");
            EndContext();
            BeginContext(2243, 16, false);
#line 40 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Home\Index.cshtml"
                                                            Write(test.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2259, 260, true);
            WriteLiteral(@"</v-card-text>
                                                </v-flex>
                                                <v-flex xs6>
                                                    <v-card-text>
                                                        ");
            EndContext();
            BeginContext(2519, 1194, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "589eec1260074defb68d8c2e1efdb01b", async() => {
                BeginContext(2609, 84, true);
                WriteLiteral("\r\n\r\n                                                            <v-btn small tag=\"a\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2693, "\"", 2723, 2);
                WriteAttributeValue("", 2700, "/Test/EditTest/", 2700, 15, true);
#line 46 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Home\Index.cshtml"
WriteAttributeValue("", 2715, test.Id, 2715, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2724, 139, true);
                WriteLiteral(" color=\"success\"><v-icon>fas fa-edit</v-icon>Edit</v-btn>\r\n                                                            <v-btn small tag=\"a\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2863, "\"", 2898, 2);
                WriteAttributeValue("", 2870, "/Test/CompleteTests/", 2870, 20, true);
#line 47 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Home\Index.cshtml"
WriteAttributeValue("", 2890, test.Id, 2890, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2899, 160, true);
                WriteLiteral(" color=\"secondary\"><v-icon>assignment_turned_in</v-icon>Complete tests</v-btn>\r\n                                                            <v-btn small tag=\"a\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3059, "\"", 3091, 2);
                WriteAttributeValue("", 3066, "/Filtr/FiltrPage/", 3066, 17, true);
#line 48 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Home\Index.cshtml"
WriteAttributeValue("", 3083, test.Id, 3083, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3092, 135, true);
                WriteLiteral(" color=\"warning\"><v-icon>search</v-icon>Filtr</v-btn>\r\n                                                            <v-btn small tag=\"a\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3227, "\"", 3254, 2);
                WriteAttributeValue("", 3234, "/Email/Send/", 3234, 12, true);
#line 49 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Home\Index.cshtml"
WriteAttributeValue("", 3246, test.Id, 3246, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3255, 154, true);
                WriteLiteral(" color=\"deep-purple lighten-1\"><v-icon>mail_outline</v-icon>Send</v-btn>\r\n                                                            <v-btn small tag=\"a\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3409, "\"", 3437, 2);
                WriteAttributeValue("", 3416, "/Test/Export/", 3416, 13, true);
#line 50 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Home\Index.cshtml"
WriteAttributeValue("", 3429, test.Id, 3429, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3438, 268, true);
                WriteLiteral(@" color=""lime lighten-3""><v-icon>description</v-icon>Export to XLSX</v-btn>
                                                            <v-btn fab type=""submit"" small color=""red""><v-icon>delete</v-icon></v-btn>
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
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Home\Index.cshtml"
                                                                                                              WriteLiteral(test.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(3713, 257, true);
            WriteLiteral(@"
                                                    </v-card-text>
                                                </v-flex>

                                            </v-layout>
                                            <v-divider></v-divider>
");
            EndContext();
#line 58 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4013, 311, true);
            WriteLiteral(@"                                    </v-container>
                                </v-card-text>
                            </div>

                        </v-card>

                    </v-flex>
                </v-layout>
            </v-container>

        </v-content>
    </v-app>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4341, 1889, true);
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
                WriteLiteral(@"    { title: ""Manage user roles"", link: ""/Admin/ManageUserRoles/"", icon: ""dashboard"" },
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
                BeginContext(6231, 34, false);
#line 102 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Home\Index.cshtml"
                                                                                             Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(6265, 102, true);
                WriteLiteral("\" },\r\n                                    { title: \"Short answer\", link: \"/Question/CreateShortAnswer/");
                EndContext();
                BeginContext(6368, 34, false);
#line 103 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Home\Index.cshtml"
                                                                                           Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(6402, 108, true);
                WriteLiteral("\" },\r\n                                    { title: \"Multiple choice\", link: \"/Question/CreateMultipleChoice/");
                EndContext();
                BeginContext(6511, 34, false);
#line 104 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Home\Index.cshtml"
                                                                                                 Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(6545, 104, true);
                WriteLiteral("\" },\r\n                                    { title: \"Range answer\", link: \"/Question/CreateRangeQuestion/");
                EndContext();
                BeginContext(6650, 34, false);
#line 105 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Home\Index.cshtml"
                                                                                             Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(6684, 125, true);
                WriteLiteral("\" }\r\n                                ]\r\n                            }\r\n                        }\r\n        })\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(6812, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Test>> Html { get; private set; }
    }
}
#pragma warning restore 1591