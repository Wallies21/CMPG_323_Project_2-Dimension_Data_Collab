#pragma checksum "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f364aa0fc5568789ae90a90a1ff10761e317370"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cmpg323Project2Dataset_Delete), @"mvc.1.0.view", @"/Views/Cmpg323Project2Dataset/Delete.cshtml")]
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
#line 1 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\_ViewImports.cshtml"
using Project_2_Dimension_Data_Collab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\_ViewImports.cshtml"
using Project_2_Dimension_Data_Collab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f364aa0fc5568789ae90a90a1ff10761e317370", @"/Views/Cmpg323Project2Dataset/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c93910e27b7d3cc13aa4d728e8f353a4383d2330", @"/Views/_ViewImports.cshtml")]
    public class Views_Cmpg323Project2Dataset_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project_2_Dimension_Data_Collab.Models.Cmpg323Project2Dataset>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Cmpg323Project2Dataset</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BusinessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BusinessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DistanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DistanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EducationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EducationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.JobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.JobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.JobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.JobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.JobSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.JobSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 123 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 126 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 129 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NumCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 132 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NumCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 135 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Over18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 138 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Over18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 141 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 144 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 147 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PercentSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 150 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PercentSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 153 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 156 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 159 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RelationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 162 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RelationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 165 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StandardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 168 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StandardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 171 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 174 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 177 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 180 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 183 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TrainingTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 186 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TrainingTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 189 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.WorkLifeBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 192 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.WorkLifeBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 195 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.YearsAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 198 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.YearsAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 201 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.YearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 204 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.YearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 207 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.YearsSinceLastPromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 210 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.YearsSinceLastPromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 213 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.YearsWithCurrManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 216 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.YearsWithCurrManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f364aa0fc5568789ae90a90a1ff10761e31737035062", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9f364aa0fc5568789ae90a90a1ff10761e31737035329", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 221 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.EmployeeNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f364aa0fc5568789ae90a90a1ff10761e31737037238", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project_2_Dimension_Data_Collab.Models.Cmpg323Project2Dataset> Html { get; private set; }
    }
}
#pragma warning restore 1591
