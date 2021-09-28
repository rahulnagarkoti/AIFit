#pragma checksum "C:\Users\nagar\source\repos\AIFit\Views\Home\HomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce0e13afb26167185bf4b7da703b995bb738ceab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HomePage), @"mvc.1.0.view", @"/Views/Home/HomePage.cshtml")]
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
#line 1 "C:\Users\nagar\source\repos\AIFit\Views\_ViewImports.cshtml"
using NutritionRecommender;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nagar\source\repos\AIFit\Views\_ViewImports.cshtml"
using NutritionRecommender.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce0e13afb26167185bf4b7da703b995bb738ceab", @"/Views/Home/HomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0fba130d175082994c7c1edfa7f4118b16eebf4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("homepage-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\nagar\source\repos\AIFit\Views\Home\HomePage.cshtml"
  
    ViewData["Title"] = "Home Page";
    float totalDuration = 0;
    float totalCalories = 0;
    int workoutId = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""panel panel-default homepage-panel mt-5"">
    <div class=""panel-body window homepage-panel-body"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col col-4 rounded p-4 form-col"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce0e13afb26167185bf4b7da703b995bb738ceab5798", async() => {
                WriteLiteral(@"
                        <div class=""form-group d-flex justify-content-between align-items-center"">
                            <label for=""weight"">Weight: </label>
                            <input type=""number"" name=""weight"" id=""weight"" placeholder=""in kg"" class=""homepage-input rounded"" required>
                        </div>
                        <div class=""form-group d-flex justify-content-between align-items-center"">
                            <label for=""height"">Height: </label>
                            <input type=""number"" name=""height"" id=""height"" placeholder=""in cm"" class=""homepage-input rounded"" required>
                        </div>
                        <div class=""form-group form-group-select d-flex justify-content-between align-items-center"">
                            <label for=""bodyType"">Body Goal: </label>
                            <select name=""bodyType"" id=""bodyType"" class=""homepage-select rounded"" required>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce0e13afb26167185bf4b7da703b995bb738ceab7093", async() => {
                    WriteLiteral("Gain Weight");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce0e13afb26167185bf4b7da703b995bb738ceab8353", async() => {
                    WriteLiteral("Keep Fit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce0e13afb26167185bf4b7da703b995bb738ceab9610", async() => {
                    WriteLiteral("Loose Weight");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                            <i class=""fas fa-chevron-down""></i>
                        </div>
                        <div class=""form-group form-group-submit d-flex justify-content-center align-items-center mt-5"">
");
                WriteLiteral("<button class=\"btn fw-bold\" id=\"getExercise\">Get Workout</button>");
                WriteLiteral("\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""col-1 space-col""></div>
                <div class=""col rounded pl-4 suggestion-col"" id=""suggestionWindow"">
                    <div class=""row mb-3"">
                        <h1 class=""h3 fw-bold"">Suggested Workout</h1>
                    </div>
                    <div class=""row suggestion-table-head p-3"">
                        <div class=""col fw-bold p-2 d-flex justify-content-center rounded"">Exercise</div>
                        <div class=""col fw-bold p-2 d-flex justify-content-center rounded mx-2"">Duration</div>
                        <div class=""col fw-bold p-2 d-flex justify-content-center rounded"">Burn</div>
                    </div>
");
#nullable restore
#line 47 "C:\Users\nagar\source\repos\AIFit\Views\Home\HomePage.cshtml"
                     if (ViewBag.Suggestions == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div id=""updateWindow"" class=""row suggestion-table-body rounded"">
                            <div class=""col"">
                                <div class=""row suggestion-table-col px-3"">
                                    <div class=""col p-2 d-flex justify-content-center"">Run</div>
                                    <div class=""col p-2 d-flex justify-content-center"">60mn</div>
                                    <div class=""col p-2 d-flex justify-content-center"">1000</div>
                                </div>
                                <div class=""row suggestion-table-col px-3"">
                                    <div class=""col p-2 d-flex justify-content-center"">Run</div>
                                    <div class=""col p-2 d-flex justify-content-center"">60mn</div>
                                    <div class=""col p-2 d-flex justify-content-center"">1000</div>
                                </div>
                                <div class=""row suggestion-t");
            WriteLiteral(@"able-col px-3"">
                                    <div class=""col p-2 d-flex justify-content-center"">Run</div>
                                    <div class=""col p-2 d-flex justify-content-center"">60mn</div>
                                    <div class=""col p-2 d-flex justify-content-center"">1000</div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 68 "C:\Users\nagar\source\repos\AIFit\Views\Home\HomePage.cshtml"

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div id=\"updateWindow\" class=\"row suggestion-table-body rounded\">\r\n                            <div class=\"col\">\r\n");
#nullable restore
#line 74 "C:\Users\nagar\source\repos\AIFit\Views\Home\HomePage.cshtml"
                                 foreach (var item in ViewBag.Suggestions)
                                {
                                    workoutId = item.WorkoutId;
                                    totalDuration += item.TotalTime;
                                    totalCalories += item.TotalBurn;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"row suggestion-table-col px-3\">\r\n                                        <div class=\"col p-2 d-flex justify-content-center\">");
#nullable restore
#line 80 "C:\Users\nagar\source\repos\AIFit\Views\Home\HomePage.cshtml"
                                                                                      Write(item.ExerciseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                        <div class=\"col p-2 d-flex justify-content-center\">");
#nullable restore
#line 81 "C:\Users\nagar\source\repos\AIFit\Views\Home\HomePage.cshtml"
                                                                                      Write(item.TotalTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                        <div class=\"col p-2 d-flex justify-content-center\">");
#nullable restore
#line 82 "C:\Users\nagar\source\repos\AIFit\Views\Home\HomePage.cshtml"
                                                                                      Write(item.TotalBurn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    </div>\r\n");
#nullable restore
#line 84 "C:\Users\nagar\source\repos\AIFit\Views\Home\HomePage.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""row suggestion-table-col px-3"">

                                    <div class=""col p-2 d-flex justify-content-center""><b>Total</b></div>
                                    <div class=""col p-2 d-flex justify-content-center""><b>");
#nullable restore
#line 88 "C:\Users\nagar\source\repos\AIFit\Views\Home\HomePage.cshtml"
                                                                                     Write(totalDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" minutes</b></div>\r\n                                    <div class=\"col p-2 d-flex justify-content-center\"><b>");
#nullable restore
#line 89 "C:\Users\nagar\source\repos\AIFit\Views\Home\HomePage.cshtml"
                                                                                     Write(totalCalories);

#line default
#line hidden
#nullable disable
            WriteLiteral(" calories</b></div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            WriteLiteral("                        <input type=\"hidden\" id=\"workoutId\"");
            BeginWriteAttribute("value", " value=\"", 5959, "\"", 5977, 1);
#nullable restore
#line 94 "C:\Users\nagar\source\repos\AIFit\Views\Home\HomePage.cshtml"
WriteAttributeValue("", 5967, workoutId, 5967, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"hidden\" />\r\n");
#nullable restore
#line 95 "C:\Users\nagar\source\repos\AIFit\Views\Home\HomePage.cshtml"


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""row suggestion-table-footer p-2"">
                        <div class=""col d-flex justify-content-between align-items-center""><a href=""#"" id=""alternativeSuggestion"">See Other Workout</a><button id=""saveSuggestions"" class=""btn fw-bold"">Accept</button></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script>
    $(function () {
        GlobalFunc.ShowLogout();
        $(document).find(""#logout"").on(""click"", function () { GlobalFunc.LogOut(); })

        $(""#getExercise"").on(""click"", function () {

            height = $(""#height"").val();
            weight = $(""#weight"").val();
            bodyType = $(""#bodyType option:selected"").val();
            $(""form#details"").validate({
                errorPlacement: function (error, element) { error.insertBefore(element) },
                rules: {
                    height: {
                        required: true,
                    },
               ");
            WriteLiteral(@"     weight: {
                        required: true,
                    }
                },
                // Specify validation error messages
                messages: {
                    height: ""Invalid input!"",
                    weight: ""Invalid input!"",
                },
                submitHandler: function (form) {
                    $.ajax(
                        {
                            url: ""/Suggestion/GetSuggestions"",
                            type: ""POST"",
                            data: { height: height, weight: weight, bodyType: bodyType },
                            success: function (response) {
                                //populate the data in the table
                                $(""#updateWindow"").html(response);

                            }
                        });
                }
            });

        });

        $(""#alternativeSuggestion"").on(""click"", function () {
            workoutId = $(""#workoutId"").val();
   ");
            WriteLiteral(@"         if (workoutId != 0  && workoutId != ""0"" && workoutId != """")
            {
                $.ajax(
                    {
                        url: ""/Suggestion/GetAlternativeSuggestions"",
                        method: ""POST"",
                        data: { workoutId: workoutId },
                        success: function (res) {
                            $(""#main-body"").html(res);
                        }
                    })


            }
        });
    });</script>
");
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
