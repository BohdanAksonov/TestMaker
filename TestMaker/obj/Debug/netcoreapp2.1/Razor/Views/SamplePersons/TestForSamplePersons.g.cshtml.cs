#pragma checksum "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a7433f66b3ad4e929f140d98ac7083cb04228e5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a7433f66b3ad4e929f140d98ac7083cb04228e5", @"/Views/SamplePersons/TestForSamplePersons.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bc10e74c8a7c33899ebdcc776e44546a0ef5fb5", @"/Views/_ViewImports.cshtml")]
    public class Views_SamplePersons_TestForSamplePersons : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Question>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
  
    ViewData["Title"] = "Test";
    var firstQuestion = Model.First();
    int testId = firstQuestion.TestId;

#line default
#line hidden
            BeginContext(147, 23, false);
#line 8 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(170, 41, true);
            WriteLiteral("\r\n\r\n<div id=\"app\">\r\n    <v-app>\r\n        ");
            EndContext();
            BeginContext(212, 71, false);
#line 12 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
   Write(await Html.PartialAsync("~/Views/Shared/_RightSidePanelPartial.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(283, 546, true);
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
#line 24 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                 foreach (var question in Model)
                                {

#line default
#line hidden
            BeginContext(930, 412, true);
            WriteLiteral(@"                                    <v-container fluid grid-list-xl>
                                        <v-layout align-center justify-center row fill-height>
                                            <v-flex xs12 sm4 md4 lg4 class=""text-md-center text-"">
                                                <v-toolbar color=""primary"">
                                                    <v-toolbar-title>");
            EndContext();
            BeginContext(1343, 13, false);
#line 30 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                                Write(question.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1356, 556, true);
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
#line 40 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                 if (question.Type == "Single")
                                                {

#line default
#line hidden
            BeginContext(2044, 69, true);
            WriteLiteral("                                                    <v-radio-group>\r\n");
            EndContext();
#line 43 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                         foreach (var answer in question.Answers)
                                                        {

#line default
#line hidden
            BeginContext(2271, 68, true);
            WriteLiteral("                                                            <v-radio");
            EndContext();
            BeginWriteAttribute("label", " label=\"", 2339, "\"", 2359, 1);
#line 45 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
WriteAttributeValue("", 2347, answer.Text, 2347, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", "\r\n                                                                     name=\"", 2360, "\"", 2457, 2);
            WriteAttributeValue("", 2437, "Answers_", 2437, 8, true);
#line 46 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
WriteAttributeValue("", 2445, question.Id, 2445, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n                                                                     value=\"", 2458, "\"", 2546, 1);
#line 47 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
WriteAttributeValue("", 2536, answer.Id, 2536, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2547, 146, true);
            WriteLiteral("\r\n                                                                     >\r\n                                                            </v-radio>\r\n");
            EndContext();
#line 50 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                        }

#line default
#line hidden
            BeginContext(2752, 70, true);
            WriteLiteral("                                                    </v-radio-group>\r\n");
            EndContext();
#line 52 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                }
                                                else if (question.Type == "Multiple")
                                                {
                                                    

#line default
#line hidden
#line 55 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                     foreach (var answer in question.Answers)
                                                    {

#line default
#line hidden
            BeginContext(3161, 82, true);
            WriteLiteral("                                                        <v-checkbox name=\"Answers\"");
            EndContext();
            BeginWriteAttribute(":value", "\r\n                                                                    :value=\"", 3243, "\"", 3331, 1);
#line 58 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
WriteAttributeValue("", 3321, answer.Id, 3321, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("label", "\r\n                                                                    label=\"", 3332, "\"", 3421, 1);
#line 59 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
WriteAttributeValue("", 3409, answer.Text, 3409, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3422, 144, true);
            WriteLiteral("\r\n                                                                    >\r\n                                                        </v-checkbox>\r\n");
            EndContext();
#line 62 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                    }

#line default
#line hidden
#line 62 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                     
                                                }
                                                else if (question.Type == "Short")
                                                {
                                                    

#line default
#line hidden
#line 66 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                     foreach (var answer in question.Answers)
                                                    {

#line default
#line hidden
            BeginContext(3957, 67, true);
            WriteLiteral("                                                        <v-textarea");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 4024, "\"", 4041, 1);
#line 68 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
WriteAttributeValue("", 4031, answer.Id, 4031, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4042, 406, true);
            WriteLiteral(@"
                                                                    box
                                                                    label=""Input text here""
                                                                    rows=""2""
                                                                    auto-grow
                                                                    counter=""200""");
            EndContext();
            BeginWriteAttribute("id", "\r\n                                                                    id=\"", 4448, "\"", 4532, 1);
#line 74 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
WriteAttributeValue("", 4522, answer.Id, 4522, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4533, 153, true);
            WriteLiteral("\r\n                                                                    clearable>\r\n                                                        </v-textarea>\r\n");
            EndContext();
#line 77 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                    }

#line default
#line hidden
#line 77 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                     
                                                }
                                                else if (question.Type == "Range")
                                                {
                                                    

#line default
#line hidden
#line 81 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                     foreach (var answer in question.Answers)
                                                    {

#line default
#line hidden
            BeginContext(5077, 419, true);
            WriteLiteral(@"                                                        <v-text-field 
                                                                      type=""number"" 
                                                                      label=""From 0 to 10"" 
                                                                      min=""0"" max=""10"" 
                                                                      value=""0""");
            EndContext();
            BeginWriteAttribute("id", " \r\n                                                                      id=\"", 5496, "\"", 5583, 1);
#line 88 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
WriteAttributeValue("", 5573, answer.Id, 5573, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5584, 76, true);
            WriteLiteral(">\r\n                                                        </v-text-field>\r\n");
            EndContext();
#line 90 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                    }

#line default
#line hidden
#line 90 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                     
                                                }

#line default
#line hidden
            BeginContext(5766, 221, true);
            WriteLiteral("                                            </v-flex>\r\n                                        </v-layout>\r\n                                    </v-container>\r\n                                    <v-divider></v-divider>\r\n");
            EndContext();
#line 96 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                }

#line default
#line hidden
            BeginContext(6022, 39, true);
            WriteLiteral("                                <v-btn ");
            EndContext();
            BeginContext(6062, 270, true);
            WriteLiteral(@"@click=""submit"" id=""btn"" color=""success"">Save</v-btn>
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
                BeginContext(6349, 2100, true);
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
                                            itemsForMembers: [
                                                { title: ""Home"", link: ""/Home/Index/"", icon: ""home"", id: ""homeBtn"" },
                                                { title: ""Create test"", link: ""/Test/CreateTest/"", icon: ""ballot"" },
                                            ],
                                            itemsLoginPartial: [
                                                { title: ""Login"", link: ""/Account/Login/"" },
                                                { title: ""Register"", link: ""/Account/Register/"" }
                                            ],
                                            itemsForAdmins: [
             ");
                WriteLiteral(@"                                   { title: ""Home"", link: ""/Home/Index/"", icon: ""home"" },
                                                { title: ""Manage user roles"", link: ""/Admin/ManageUserRoles/"", icon: ""dashboard"" },
                                                { title: ""Manage users"", link: ""/Admin/Members/"", icon: ""people"" }
                                            ],
                                            headers: [
                                                { text: ""Title"", align: ""center"", sortable: false, value: ""title"" },
                                                { text: ""Description"", value: ""description"" },
                                                { text: ""Create date"", value: ""createDate"" },
                                                { text: ""Last modified date"", value: ""lastMD"" },
                                            ],
                                            dropDownFromResult: [
                                                { title: """);
                WriteLiteral("Single answer\", link: \"/Question/CreateSingleAnswer/");
                EndContext();
                BeginContext(8450, 34, false);
#line 138 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                                                                         Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(8484, 114, true);
                WriteLiteral("\" },\r\n                                                { title: \"Short answer\", link: \"/Question/CreateShortAnswer/");
                EndContext();
                BeginContext(8599, 34, false);
#line 139 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                                                                       Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(8633, 120, true);
                WriteLiteral("\" },\r\n                                                { title: \"Multiple choice\", link: \"/Question/CreateMultipleChoice/");
                EndContext();
                BeginContext(8754, 34, false);
#line 140 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                                                                             Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(8788, 116, true);
                WriteLiteral("\" },\r\n                                                { title: \"Range answer\", link: \"/Question/CreateRangeQuestion/");
                EndContext();
                BeginContext(8905, 34, false);
#line 141 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                                                                                         Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(8939, 474, true);
                WriteLiteral(@""" }
                                            ],
                                            dictionary: {
                                                attributes: {
                                                    checkbox: ""checkbox"",
                                                    password: ""Password""
                                                }
                                            },
                                            testId:");
                EndContext();
                BeginContext(9414, 6, false);
#line 149 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\SamplePersons\TestForSamplePersons.cshtml"
                                              Write(testId);

#line default
#line hidden
                EndContext();
                BeginContext(9420, 3430, true);
                WriteLiteral(@",
                                        }
                        },
            methods: {
                submit(e) {
                                var arr = [];
                                arr.push({ TestId: this.testId });
                    console.log(arr);

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
                                    $(""textarea"").ea");
                WriteLiteral(@"ch(function () {
                                        var textareaVal = $(this).val();
                                        var textareaId = $(this).attr(""id"");
                                        var type = ""Short"";
                                        arr.push({ Text: textareaVal, AnswerId: textareaId, Type: type });
                                    });
                                    $(""input[type='number']"").each(function () {
                                        var numberVal = $(this).val();
                                        var numberId = $(this).attr(""id"");
                                        var type = ""Range"";
                                        arr.push({ Text: numberVal, AnswerId: numberId, Type: type });
                                    })

                                    console.log(arr);
                                    $.ajax({
                                        type: ""post"",
                                        url: ""/Samp");
                WriteLiteral(@"lePersons/CompleteTest"",
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
                                            else {
                                                alert(""You must answer on all questions!"")
                           ");
                WriteLiteral(@"                 }
                                        },
                                        error: function (err) {
                                            console.log(err);
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
            BeginContext(12853, 6, true);
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