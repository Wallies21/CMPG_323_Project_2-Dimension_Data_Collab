#pragma checksum "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Chart\ChartView1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af9c975c699baf77e6852f5b6fa71bc3fd0a63f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chart_ChartView1), @"mvc.1.0.view", @"/Views/Chart/ChartView1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af9c975c699baf77e6852f5b6fa71bc3fd0a63f1", @"/Views/Chart/ChartView1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c93910e27b7d3cc13aa4d728e8f353a4383d2330", @"/Views/_ViewImports.cshtml")]
    public class Views_Chart_ChartView1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <h1>Gender balance</h1>\r\n    <canvas id=\"gender\"></canvas>\r\n</div>\r\n\r\n<script>\r\n\r\n    var can = document.getElementById(\"gender\");\r\n    var male = ");
#nullable restore
#line 9 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Chart\ChartView1.cshtml"
          Write(ViewBag.male);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var female = ");
#nullable restore
#line 10 "C:\Users\waldo\OneDrive\Documents\GitHub\CMPG_323_Project_2-Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Project_2_Dimension_Data_Collab\Views\Chart\ChartView1.cshtml"
            Write(ViewBag.female);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    var genderC = new Chart(can, {
        type: ""doughnut"",
        data: {
            labels: [""Male"", ""Female""],
            datasets: [{
                data: [male, female],
                backgroundColor: [""#33D1FF"", ""#FFB0D9""],
                borderColor: [""#0A1197"", ""#E20074""]
            }]
        },
        options: {
            title: {
                text: ""Gender"",
                display :true
            }
            
        }
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
