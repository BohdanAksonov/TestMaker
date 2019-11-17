#pragma checksum "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da287509acc4e6236f2ca3e879819f60e8bb9d7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_CompleteTests), @"mvc.1.0.view", @"/Views/Test/CompleteTests.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/CompleteTests.cshtml", typeof(AspNetCore.Views_Test_CompleteTests))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da287509acc4e6236f2ca3e879819f60e8bb9d7a", @"/Views/Test/CompleteTests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bc10e74c8a7c33899ebdcc776e44546a0ef5fb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_CompleteTests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResultViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
  
    ViewData["Title"] = "Complete Tests";
    var samplePersonId = Model.AnswerChoices.Select(p => p.SamplePersonId).Distinct();

#line default
#line hidden
            BeginContext(162, 39, true);
            WriteLiteral("\r\n<div id=\"app\">\r\n    <v-app>\r\n        ");
            EndContext();
            BeginContext(202, 71, false);
#line 9 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
   Write(await Html.PartialAsync("~/Views/Shared/_RightSidePanelPartial.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(273, 510, true);
            WriteLiteral(@"
        <v-content>
            <v-container align-center justify-end row fill-height>
                <v-layout xs12 sm8 md6>
                    <v-flex>
                        <v-card class=""elevation-15"">
                            <v-toolbar color=""deep-orange darken-3"">
                                <v-toolbar-title>Complete tests</v-toolbar-title>
                                <v-spacer></v-spacer>
                            </v-toolbar>
                            <v-card-text>
");
            EndContext();
#line 20 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                 foreach (var person in samplePersonId)
                                {

#line default
#line hidden
            BeginContext(891, 296, true);
            WriteLiteral(@"                                    <v-expansion-panel>
                                        <v-expansion-panel-content>
                                            <template v-slot:header>
                                                <div>Sapmple person ID:<strong class=""text-success"">");
            EndContext();
            BeginContext(1188, 6, false);
#line 25 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                                                                               Write(person);

#line default
#line hidden
            EndContext();
            BeginContext(1194, 393, true);
            WriteLiteral(@"</strong> </div>
                                            </template>
                                            <v-card>
                                                    <v-container>
                                                        <v-layout align-center justify-center row fill-height>
                                                            <v-flex xs12 sm8 md4>

");
            EndContext();
#line 32 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                                                 foreach (var question in Model.Questions)
                                                                {

#line default
#line hidden
            BeginContext(1762, 110, true);
            WriteLiteral("                                                                    <v-card-text><strong class=\"text-success\">");
            EndContext();
            BeginContext(1873, 13, false);
#line 34 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                                                                                         Write(question.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1886, 25, true);
            WriteLiteral("</strong></v-card-text>\r\n");
            EndContext();
#line 36 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                                                     if (question.Type == "Single")
                                                                    {

#line default
#line hidden
            BeginContext(2085, 89, true);
            WriteLiteral("                                                                        <v-radio-group>\r\n");
            EndContext();
#line 39 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                                                             foreach (var answer in question.AnswerChoices)
                                                                            {
                                                                                if (answer.SamplePersonId == person)
                                                                                {

#line default
#line hidden
            BeginContext(2579, 92, true);
            WriteLiteral("                                                                                    <v-radio");
            EndContext();
            BeginWriteAttribute("label", " label=\"", 2671, "\"", 2691, 1);
#line 43 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
WriteAttributeValue("", 2679, answer.Text, 2679, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 2692, "\"", 2719, 2);
            WriteAttributeValue("", 2699, "Answers_", 2699, 8, true);
#line 43 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
WriteAttributeValue("", 2707, question.Id, 2707, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2720, 22, true);
            WriteLiteral(" readonly></v-radio>\r\n");
            EndContext();
#line 44 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                                                                }
                                                                            }

#line default
#line hidden
            BeginContext(2904, 90, true);
            WriteLiteral("                                                                        </v-radio-group>\r\n");
            EndContext();
#line 47 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                                                    }
                                                                    else if (question.Type == "Multiple")
                                                                    {
                                                                        

#line default
#line hidden
#line 50 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                                                         foreach (var answer in question.AnswerChoices)
                                                                        {
                                                                            if (answer.SamplePersonId == person)
                                                                            {

#line default
#line hidden
            BeginContext(3632, 127, true);
            WriteLiteral("                                                                                <v-checkbox checked name=\"Answers\" value=\"true\"");
            EndContext();
            BeginWriteAttribute("label", " label=\"", 3759, "\"", 3779, 1);
#line 54 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
WriteAttributeValue("", 3767, answer.Text, 3767, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3780, 25, true);
            WriteLiteral(" readonly></v-checkbox>\r\n");
            EndContext();
#line 55 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                                                            }
                                                                        }

#line default
#line hidden
#line 56 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                                                         
                                                                    }
                                                                    else if (question.Type == "Short")
                                                                    {
                                                                        

#line default
#line hidden
#line 60 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                                                         foreach (var answer in question.AnswerChoices)
                                                                        {
                                                                            if (answer.SamplePersonId == person)
                                                                            {

#line default
#line hidden
            BeginContext(4594, 91, true);
            WriteLiteral("                                                                                <v-textarea");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 4685, "\"", 4702, 1);
#line 64 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
WriteAttributeValue("", 4692, answer.Id, 4692, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4703, 526, true);
            WriteLiteral(@"
                                                                                            box
                                                                                            label=""Input text here""
                                                                                            rows=""2""
                                                                                            auto-grow
                                                                                            counter=""200""");
            EndContext();
            BeginWriteAttribute("id", "\r\n                                                                                            id=\"", 5229, "\"", 5337, 1);
#line 70 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
WriteAttributeValue("", 5327, answer.Id, 5327, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n                                                                                            value=\"", 5338, "\"", 5452, 1);
#line 71 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
WriteAttributeValue(" ", 5439, answer.Text, 5440, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5453, 200, true);
            WriteLiteral("\r\n                                                                                            readonly>\r\n                                                                                </v-textarea>\r\n");
            EndContext();
#line 74 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"

                                                                            }
                                                                        }

#line default
#line hidden
#line 76 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                                                         

                                                                    }
                                                                    else if (question.Type == "Range")
                                                                    {
                                                                        

#line default
#line hidden
#line 81 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                                                         foreach (var answer in question.AnswerChoices)
                                                                        {
                                                                            if (answer.SamplePersonId == person)
                                                                            {

#line default
#line hidden
            BeginContext(6446, 145, true);
            WriteLiteral("                                                                                <v-text-field type=\"number\" label=\"From 0 to 10\" min=\"0\" max=\"10\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 6591, "\"", 6611, 1);
#line 85 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
WriteAttributeValue("", 6599, answer.Text, 6599, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 6612, "\"", 6627, 1);
#line 85 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
WriteAttributeValue("", 6617, answer.Id, 6617, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6628, 27, true);
            WriteLiteral(" readonly></v-text-field>\r\n");
            EndContext();
#line 86 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                                                            }
                                                                        }

#line default
#line hidden
#line 87 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                                                         
                                                                    }

#line default
#line hidden
#line 88 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                                                     

                                                                }

#line default
#line hidden
            BeginContext(6949, 393, true);
            WriteLiteral(@"                                                            </v-flex>
                                                        </v-layout>
                                                    </v-container>

                                            </v-card>
                                        </v-expansion-panel-content>
                                    </v-expansion-panel>
");
            EndContext();
#line 98 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                }

#line default
#line hidden
            BeginContext(7377, 215, true);
            WriteLiteral("                            </v-card-text>\r\n                        </v-card>\r\n                    </v-flex>\r\n                </v-layout>\r\n            </v-container>\r\n\r\n        </v-content>\r\n    </v-app>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7609, 1890, true);
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
                BeginContext(9500, 34, false);
#line 139 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                                                                             Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(9534, 102, true);
                WriteLiteral("\" },\r\n                                    { title: \"Short answer\", link: \"/Question/CreateShortAnswer/");
                EndContext();
                BeginContext(9637, 34, false);
#line 140 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                                                                           Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(9671, 108, true);
                WriteLiteral("\" },\r\n                                    { title: \"Multiple choice\", link: \"/Question/CreateMultipleChoice/");
                EndContext();
                BeginContext(9780, 34, false);
#line 141 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                                                                                 Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(9814, 104, true);
                WriteLiteral("\" },\r\n                                    { title: \"Range answer\", link: \"/Question/CreateRangeQuestion/");
                EndContext();
                BeginContext(9919, 34, false);
#line 142 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\CompleteTests.cshtml"
                                                                                             Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(9953, 125, true);
                WriteLiteral("\" }\r\n                                ]\r\n                            }\r\n                        }\r\n        })\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResultViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
