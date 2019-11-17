#pragma checksum "D:\MyGit\MyProject\TestMaker\TestMaker\Views\Question\CreateSingleAnswer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3798c0f6ae13d29b941490df39df7c3b41f00889"
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
#line 2 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\_ViewImports.cshtml"
using TestMaker.Models;

#line default
#line hidden
#line 3 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\_ViewImports.cshtml"
using TestMaker.ViewModels;

#line default
#line hidden
#line 4 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3798c0f6ae13d29b941490df39df7c3b41f00889", @"/Views/Question/CreateSingleAnswer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bc10e74c8a7c33899ebdcc776e44546a0ef5fb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Question_CreateSingleAnswer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuestionViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\Question\CreateSingleAnswer.cshtml"
   ViewData["Title"] = "Create New Question"; 

#line default
#line hidden
            BeginContext(77, 37, true);
            WriteLiteral("<div id=\"app\">\r\n    <v-app>\r\n        ");
            EndContext();
            BeginContext(115, 71, false);
#line 6 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\Question\CreateSingleAnswer.cshtml"
   Write(await Html.PartialAsync("~/Views/Shared/_RightSidePanelPartial.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(186, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(197, 23, false);
#line 7 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\Question\CreateSingleAnswer.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(220, 526, true);
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
            BeginContext(862, 1110, true);
            WriteLiteral(@"                                    <v-text-field 
                                                  label=""TestId""
                                                  v-model=""TestId"" 
                                                  name=""TestId"" 
                                                  readonly 
                                                  v-show=""false"">
                                    </v-text-field>
                                    <v-text-field 
                                                  v-model=""Text"" 
                                                  name=""text"" 
                                                  label=""Input question"" 
                                                  clearable
                                                  v-validate=""'required'""
                                                  :error-messages=""errors.collect('text')""
                                                  data-vv-name=""text"">
                                ");
            WriteLiteral("    </v-text-field>\r\n                                    <v-btn color=\"blue darken-1\" ");
            EndContext();
            BeginContext(1973, 79, true);
            WriteLiteral("@click=\"submit\">Add</v-btn>\r\n                                    <v-btn tag=\"a\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2052, "\"", 2107, 2);
            WriteAttributeValue("", 2059, "/Test/Result/", 2059, 13, true);
#line 36 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\Question\CreateSingleAnswer.cshtml"
WriteAttributeValue("", 2072, ViewContext.RouteData.Values["id"], 2072, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2108, 27, true);
            WriteLiteral(" color=\"red\">Back</v-btn>\r\n");
            EndContext();
            BeginContext(2180, 215, true);
            WriteLiteral("                            </v-card-text>\r\n                        </v-card>\r\n                    </v-flex>\r\n                </v-layout>\r\n            </v-container>\r\n\r\n        </v-content>\r\n    </v-app>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2412, 311, true);
                WriteLiteral(@"
    <script>
        var app = new Vue({
            el: '#app',
            $_veeValidate: {
                validator:""new""
            },

                        data() {
                            return {
                                drawer: true,
                                TestId: """);
                EndContext();
                BeginContext(2724, 34, false);
#line 59 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\Question\CreateSingleAnswer.cshtml"
                                    Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(2758, 1748, true);
                WriteLiteral(@""",
                                Text: """",
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
                                    { title: ""Manage user roles"", link: ""/Admin/ManageUserRoles/"", icon: ""dashboard"" },
                                    { title: ""Manage");
                WriteLiteral(@" users"", link: ""/Admin/Members/"", icon: ""people"" }
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
                BeginContext(4507, 34, false);
#line 84 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\Question\CreateSingleAnswer.cshtml"
                                                                                             Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(4541, 102, true);
                WriteLiteral("\" },\r\n                                    { title: \"Short answer\", link: \"/Question/CreateShortAnswer/");
                EndContext();
                BeginContext(4644, 34, false);
#line 85 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\Question\CreateSingleAnswer.cshtml"
                                                                                           Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(4678, 108, true);
                WriteLiteral("\" },\r\n                                    { title: \"Multiple choice\", link: \"/Question/CreateMultipleChoice/");
                EndContext();
                BeginContext(4787, 34, false);
#line 86 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\Question\CreateSingleAnswer.cshtml"
                                                                                                 Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(4821, 104, true);
                WriteLiteral("\" },\r\n                                    { title: \"Range answer\", link: \"/Question/CreateRangeQuestion/");
                EndContext();
                BeginContext(4926, 34, false);
#line 87 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\Question\CreateSingleAnswer.cshtml"
                                                                                             Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(4960, 817, true);
                WriteLiteral(@""" }
                                ],
                                dictionary: {
                                    attributes: {
                                        text: ""Question""
                                    }
                                }

                            }
            },
            mounted() {
                this.$validator.localize(""en"", this.dictionary)
            },
            methods: {
                submit() {
                    this.$validator.validateAll().then((result) => {
                        if (result) {
                            data2send = JSON.stringify({ Text: this.Text, TestId: this.TestId });
                            var testId = this.TestId;
                            $.ajax({
                                url: """);
                EndContext();
                BeginContext(5778, 44, false);
#line 107 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\Question\CreateSingleAnswer.cshtml"
                                 Write(Url.Action("CreateSingleAnswer", "Question"));

#line default
#line hidden
                EndContext();
                BeginContext(5822, 836, true);
                WriteLiteral(@""",
                                type: ""post"",
                                beforeSend: function (request) {
                                    request.setRequestHeader(""RequestVerificationToken"", $(""[name = '__RequestVerificationToken']"").val());
                                },
                                contentType: ""application/json; charset=utf-8"",
                                data: data2send,
                                success: function (data) {
                                    if (data != null) {
                                        window.location.replace(data);
                                    }
                                }
                            });
                        }
                    });
                }
            }

        })
    </script>
");
                EndContext();
            }
            );
            BeginContext(6661, 2, true);
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