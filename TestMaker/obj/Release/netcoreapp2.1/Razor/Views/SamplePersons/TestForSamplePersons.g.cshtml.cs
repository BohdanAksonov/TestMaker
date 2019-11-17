#pragma checksum "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "764ac8cb877c3db0cb9342893bca91f95c4aff3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SamplePersons_TestForSamplePersons), @"mvc.1.0.view", @"/Views/SamplePersons/TestForSamplePersons.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SamplePersons/TestForSamplePersons.cshtml", typeof(AspNetCore.Views_SamplePersons_TestForSamplePersons))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"764ac8cb877c3db0cb9342893bca91f95c4aff3b", @"/Views/SamplePersons/TestForSamplePersons.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bc10e74c8a7c33899ebdcc776e44546a0ef5fb5", @"/Views/_ViewImports.cshtml")]
    public class Views_SamplePersons_TestForSamplePersons : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Question>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
  
    ViewData["Title"] = "Test";

#line default
#line hidden
            BeginContext(67, 23, false);
#line 6 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(90, 41, true);
            WriteLiteral("\r\n\r\n<div id=\"app\">\r\n    <v-app>\r\n        ");
            EndContext();
            BeginContext(132, 71, false);
#line 10 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
   Write(await Html.PartialAsync("~/Views/Shared/_RightSidePanelPartial.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(203, 536, true);
            WriteLiteral(@"
        <v-content>
            <v-container align-center justify-end row fill-height>
                <v-layout xs12 sm8 md6>
                    <v-flex>
                        <v-card class=""elevation-15"">
                            <v-toolbar color=""deep-orange darken-3"">
                                <v-toolbar-title>Test for complete</v-toolbar-title>
                                <v-spacer></v-spacer>
                            </v-toolbar>
                            <v-card-text class=""text-xs-center"">
");
            EndContext();
#line 21 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                 foreach (var question in Model)
                                {

#line default
#line hidden
            BeginContext(840, 412, true);
            WriteLiteral(@"                                    <v-container fluid grid-list-xl>
                                        <v-layout align-center justify-center row fill-height>
                                            <v-flex xs12 sm4 md4 lg4 class=""text-md-center text-"">
                                                <v-toolbar color=""primary"">
                                                    <v-toolbar-title>");
            EndContext();
            BeginContext(1253, 13, false);
#line 27 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                                Write(question.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1266, 556, true);
            WriteLiteral(@"</v-toolbar-title>
                                                    <v-spacer></v-spacer>
                                                </v-toolbar>
                                            </v-flex>
                                        </v-layout>
                                    </v-container>
                                    <v-container fluid grid-list-xl>
                                        <v-layout align-center justify-center row fill-height>
                                            <v-flex xs12 sm4 md4 lg4>

");
            EndContext();
#line 37 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                 if (question.Type == "Single")
                                                {

#line default
#line hidden
            BeginContext(1954, 69, true);
            WriteLiteral("                                                    <v-radio-group>\r\n");
            EndContext();
#line 40 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                         foreach (var answer in question.Answers)
                                                        {

#line default
#line hidden
            BeginContext(2181, 68, true);
            WriteLiteral("                                                            <v-radio");
            EndContext();
            BeginWriteAttribute("label", " label=\"", 2249, "\"", 2269, 1);
#line 42 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
WriteAttributeValue("", 2257, answer.Text, 2257, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 2270, "\"", 2297, 2);
            WriteAttributeValue("", 2277, "Answers_", 2277, 8, true);
#line 42 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
WriteAttributeValue("", 2285, question.Id, 2285, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2298, "\"", 2316, 1);
#line 42 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
WriteAttributeValue("", 2306, answer.Id, 2306, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2317, 13, true);
            WriteLiteral("></v-radio>\r\n");
            EndContext();
#line 43 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                        }

#line default
#line hidden
            BeginContext(2389, 70, true);
            WriteLiteral("                                                    </v-radio-group>\r\n");
            EndContext();
#line 45 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                }
                                                else if (question.Type == "Multiple")
                                                {
                                                    

#line default
#line hidden
#line 48 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                     foreach (var answer in question.Answers)
                                                    {

#line default
#line hidden
            BeginContext(2798, 82, true);
            WriteLiteral("                                                        <v-checkbox name=\"Answers\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2880, "\"", 2898, 1);
#line 50 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
WriteAttributeValue("", 2888, answer.Id, 2888, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("label", " label=\"", 2899, "\"", 2919, 1);
#line 50 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
WriteAttributeValue("", 2907, answer.Text, 2907, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2920, 16, true);
            WriteLiteral("></v-checkbox>\r\n");
            EndContext();
#line 51 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                    }

#line default
#line hidden
#line 51 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                     
                                                }
                                                else if (question.Type == "Short")
                                                {
                                                    

#line default
#line hidden
#line 55 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                     foreach (var answer in question.Answers)
                                                    {

#line default
#line hidden
            BeginContext(3327, 67, true);
            WriteLiteral("                                                        <v-textarea");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 3394, "\"", 3411, 1);
#line 57 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
WriteAttributeValue("", 3401, answer.Id, 3401, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3412, 406, true);
            WriteLiteral(@"
                                                                    box
                                                                    label=""Input text here""
                                                                    rows=""2""
                                                                    auto-grow
                                                                    counter=""200""");
            EndContext();
            BeginWriteAttribute("id", "\r\n                                                                    id=\"", 3818, "\"", 3902, 1);
#line 63 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
WriteAttributeValue("", 3892, answer.Id, 3892, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3903, 153, true);
            WriteLiteral("\r\n                                                                    clearable>\r\n                                                        </v-textarea>\r\n");
            EndContext();
#line 66 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                    }

#line default
#line hidden
#line 66 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                     

                                                }
                                                else if (question.Type == "Range")
                                                {
                                                    

#line default
#line hidden
#line 71 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                     foreach (var answer in question.Answers)
                                                    {

#line default
#line hidden
            BeginContext(4449, 131, true);
            WriteLiteral("                                                        <v-text-field type=\"number\" label=\"From 0 to 10\" min=\"0\" max=\"10\" value=\"0\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4580, "\"", 4595, 1);
#line 73 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
WriteAttributeValue("", 4585, answer.Id, 4585, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4596, 18, true);
            WriteLiteral("></v-text-field>\r\n");
            EndContext();
#line 74 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                    }

#line default
#line hidden
#line 74 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                     
                                                }

#line default
#line hidden
            BeginContext(4720, 221, true);
            WriteLiteral("                                            </v-flex>\r\n                                        </v-layout>\r\n                                    </v-container>\r\n                                    <v-divider></v-divider>\r\n");
            EndContext();
#line 80 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                }

#line default
#line hidden
            BeginContext(4976, 293, true);
            WriteLiteral(@"                                <v-btn id=""btn"" color=""success"">Save</v-btn>
                            </v-card-text>
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
                BeginContext(5286, 3970, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            var arr = [];
            $(""#btn"").click(function () {
                $(""input:checked[name=Answers]"").each(function () {
                    var id = $(this).val()
                    var type = ""Multiple"";
                    arr.push({ AnswerId: id, Type: type });
                });
                $(""input[type='radio']:checked"").each(function () {
                    var radioVal = $(this).val();
                    var type = ""Single"";
                    arr.push({ AnswerId: radioVal, Type: type });
                });
                $(""textarea"").each(function () {
                    var textareaVal = $(this).val();
                    var textareaId = $(this).attr(""id"");
                    var type = ""Short"";
                    arr.push({ Text: textareaVal, AnswerId: textareaId, Type: type });
                });
                $(""input[type='number']"").each(function () {
                    var numberVal ");
                WriteLiteral(@"= $(this).val();
                    var numberId = $(this).attr(""id"");
                    var type = ""Range"";
                    arr.push({ Text: numberVal, AnswerId: numberId, Type: type });
                })
                console.log(arr);
                $.ajax({
                    type: ""post"",
                    url: ""/SamplePersons/CompleteTest"",
                    beforeSend: function (request) {
                        request.setRequestHeader(""RequestVerificationToken"", $(""[name='__RequestVerificationToken']"").val());
                    },
                    contentType: ""application/json"",
                    data: JSON.stringify(arr),
                    dataType: ""json"",
                    success: function (response) {
                        if (response == true) {
                            alert(""Thank You for complete test!"");
                            window.location = ""/Account/Login"";
                        }
                    },
                    e");
                WriteLiteral(@"rror: function (err) {
                        console.log(err);
                    }
                });
            });
        });
                var app = new Vue({
            el: '#app',
                        data() {
                            return {
                                drawer: true,
                                itemsForMembers: [
                                    { title: ""Home"", link: ""/Home/Index/"", icon: ""home"", id: ""homeBtn"" },
                                    { title: ""Create test"", link: ""/Test/CreateTest/"", icon: ""ballot"" },
                                ],
                                itemsLoginPartial: [
                                    { title: ""Login"", link: ""/Account/Login/"" },
                                    { title: ""Register"", link: ""/Account/Register/"" }
                                ],
                                itemsForAdmins: [
                                    { title: ""Home"", link: ""/Home/Index/"", icon: ""home"" },
                WriteLiteral(@"
                                    { title: ""Manage user roles"", link: ""/Admin/ManageUserRoles/"", icon: ""dashboard"" },
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
                BeginContext(9257, 34, false);
#line 167 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                                                             Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(9291, 102, true);
                WriteLiteral("\" },\r\n                                    { title: \"Short answer\", link: \"/Question/CreateShortAnswer/");
                EndContext();
                BeginContext(9394, 34, false);
#line 168 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                                                           Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(9428, 108, true);
                WriteLiteral("\" },\r\n                                    { title: \"Multiple choice\", link: \"/Question/CreateMultipleChoice/");
                EndContext();
                BeginContext(9537, 34, false);
#line 169 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                                                                 Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(9571, 104, true);
                WriteLiteral("\" },\r\n                                    { title: \"Range answer\", link: \"/Question/CreateRangeQuestion/");
                EndContext();
                BeginContext(9676, 34, false);
#line 170 "E:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                                                             Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(9710, 127, true);
                WriteLiteral("\" }\r\n                                ]\r\n                            }\r\n                        }\r\n        })\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(9840, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Question>> Html { get; private set; }
    }
}
#pragma warning restore 1591