#pragma checksum "D:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\Graphs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42ca428cde15b2ebce41e55e4b2dfcb99736fecd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Graphs), @"mvc.1.0.view", @"/Views/Test/Graphs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/Graphs.cshtml", typeof(AspNetCore.Views_Test_Graphs))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42ca428cde15b2ebce41e55e4b2dfcb99736fecd", @"/Views/Test/Graphs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bc10e74c8a7c33899ebdcc776e44546a0ef5fb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_Graphs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\Graphs.cshtml"
   ViewData["Title"] = "Graphs";

#line default
#line hidden
            BeginContext(35, 41, true);
            WriteLiteral("\r\n\r\n<div id=\"app\">\r\n    <v-app>\r\n        ");
            EndContext();
            BeginContext(77, 71, false);
#line 6 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\Graphs.cshtml"
   Write(await Html.PartialAsync("~/Views/Shared/_RightSidePanelPartial.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(148, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(159, 23, false);
#line 7 "D:\MyGit\MyProject\TestMaker\TestMaker\Views\Test\Graphs.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(182, 2576, true);
            WriteLiteral(@"
        <v-content>
            <v-container align-center justify-end row fill-height>
                <v-layout xs12 sm8 md6>
                    <v-flex>
                        <v-card class=""elevation-15"">
                            <v-toolbar color=""deep-orange darken-3"">
                                <v-toolbar-title>Graphs</v-toolbar-title>
                                <v-spacer></v-spacer>
                            </v-toolbar>
                            <v-card-text>
                                <v-container>
                                    <v-layout>
                                        <v-flex>
                                            <v-overflow-btn
                                                            :items=""tests""
                                                            label=""Choose test""
                                                            v-model=""selectedTest""
                                                            v-on:change=""on");
            WriteLiteral(@"Change"">
                                            </v-overflow-btn>
                                        </v-flex>
                                        <v-flex>
                                            <v-overflow-btn
                                                            :items=""questions""
                                                            label=""Choose question""
                                                            v-model=""selectedQuestion""
                                                            v-on:change=""onChangeQuestion"">
                                            </v-overflow-btn>
                                        </v-flex>
                                    </v-layout>
                                </v-container>
                                <v-container>
                                    <v-layout>
                                        <v-flex>
                                            <v-btn block color=""success"" v-on:click=""dr");
            WriteLiteral(@"aw"">Draw Chart</v-btn>
                                        </v-flex>
                                    </v-layout>
                                </v-container>
                                <v-container id=""chart"" style=""width:500px; height:500px;"">
                                </v-container>
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
                BeginContext(2775, 4961, true);
                WriteLiteral(@"
<script>
        var app = new Vue({
            el: '#app',
            data() {
                return {
                    selectedTest: """",
                    selectedQuestion: """",
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
                         { title: ""Manage user roles"", link: ""/Admin/ManageUserRoles/"", icon: ""dashboard"" },
     ");
                WriteLiteral(@"                    { title: ""Manage users"", link: ""/Admin/Members/"", icon: ""people"" }
                    ],
                    tests: [],
                    questions: [],
                    answerChoices: []
                }
            },
            methods: {
                getTest: function () {
                    let app = this;
                    $.ajax({
                        url: ""/Test/GetTestComboBox/"",
                        type: ""get"",
                        dataType: ""Json"",
                        success: function (res) {
                            $.each(res, function (index, value) {
                                app.tests.push(value );
                            })
                        }
                    });
                },
                onChange: function () {
                    let app = this;
                    var data2send = JSON.stringify(app.selectedTest);
                    //console.log(data2send);
                    $.ajax(");
                WriteLiteral(@"{
                        url: ""/Test/GetQuestionComboBox/"",
                        type: ""post"",
                        contentType: ""application/json"",
                        beforeSend: function (request) {
                            request.setRequestHeader(""RequestVerificationToken"", $(""[name = '__RequestVerificationToken']"").val());
                        },
                        data: data2send,
                        success: function (res) {
                            //console.log(res);
                            app.questions = [];
                            $.each(res, function (index, value) {
                                app.questions.push(value);
                            })
                        }
                    });
                },
                onChangeQuestion: function () {
                    let app = this;
                    var data2send = JSON.stringify(app.selectedQuestion);
                    $.ajax({
                        url: ""/T");
                WriteLiteral(@"est/GetAnswerChoices/"",
                        type: ""post"",
                        contentType: ""application/json"",
                        beforeSend: function (request) {
                            request.setRequestHeader(""RequestVerificationToken"", $(""[name = '__RequestVerificationToken']"").val());
                        },
                        data: data2send,
                        success: function (res) {
                            app.answerChoices = [];
                            $.each(res, function (index, value) {
                                app.answerChoices.push(value);
                            })
                        }
                    });
                },
                draw: function () {
                    let app = this;
                    google.charts.load('current', { 'packages': ['corechart'] });
                    google.charts.setOnLoadCallback(drawChart);

                    function drawChart() {
                        var data =");
                WriteLiteral(@" [[""Question"", ""Count""]];
                        $.each(app.answerChoices, function (i, item) {
                            data.push([item.value, item.count]);
                        });
                        //console.log(data);
                        var chartData = google.visualization.arrayToDataTable(data);
                        //console.log(chartData);
                        var options = {
                            title: app.selectedQuestion,
                            is3D: true,
                        };
                        var chart = new google.visualization.PieChart(document.getElementById(""chart""));
                        chart.draw(chartData, options);
                    }
                }
            },
            beforeMount() {
                this.getTest()
            }
        })
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591