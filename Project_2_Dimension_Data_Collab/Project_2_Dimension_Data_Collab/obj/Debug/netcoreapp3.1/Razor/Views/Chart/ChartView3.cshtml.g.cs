#pragma checksum "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Chart\ChartView3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50dc65f382d21536a0a6f4b82ab6943317cdf7f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chart_ChartView3), @"mvc.1.0.view", @"/Views/Chart/ChartView3.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50dc65f382d21536a0a6f4b82ab6943317cdf7f2", @"/Views/Chart/ChartView3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c93910e27b7d3cc13aa4d728e8f353a4383d2330", @"/Views/_ViewImports.cshtml")]
    public class Views_Chart_ChartView3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <h3 style=\"text-align:center\">Education Field</h3>\r\n    <hr>\r\n    <canvas id=\"EduField\"></canvas>\r\n</div>\r\n\r\n<script>\r\n\r\n    var can = document.getElementById(\"EduField\");\r\n\r\n    var HumanR = ");
#nullable restore
#line 11 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Chart\ChartView3.cshtml"
            Write(ViewBag.HumanR);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var LifeSci = ");
#nullable restore
#line 12 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Chart\ChartView3.cshtml"
             Write(ViewBag.LifeSci);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var Marketing = ");
#nullable restore
#line 13 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Chart\ChartView3.cshtml"
               Write(ViewBag.Marketing);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var Medical = ");
#nullable restore
#line 14 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Chart\ChartView3.cshtml"
             Write(ViewBag.Medical);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var Other = ");
#nullable restore
#line 15 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Chart\ChartView3.cshtml"
           Write(ViewBag.Other);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var TechDegree = ");
#nullable restore
#line 16 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Chart\ChartView3.cshtml"
                Write(ViewBag.TechDegree);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    var genderC = new Chart(can, {
        type: ""doughnut"",
        data: {
            labels: ['Human Resources', 'Life Sciences', 'Marketing', 'Medical', 'Other', 'Technical Degree'],
            datasets: [{
                data: [HumanR, LifeSci, Marketing, Medical, Other, TechDegree],
                backgroundColor: [""#CD84FF"", ""#B954FF"", ""#A92DFF"", ""#8500E1"", ""#6600AD"", ""#500088""],
                borderColor: [""#CD84FF"", ""#B954FF"", ""#A92DFF"", ""#8500E1"", ""#6600AD"", ""#500088""]

            }]
        },
        //options: {
            //title: {
                //text: ""Education Field"",
                //display: true
            //}
        //}
    });

</script>");
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
