#pragma checksum "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b43ea66b4acd541d9354da08aa8713541845ed5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ExperienceComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ExperienceComponent/Default.cshtml")]
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
#line 3 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\_ViewImports.cshtml"
using DapperCv.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\_ViewImports.cshtml"
using DapperCv.DTO.DTOs.AppUserDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\_ViewImports.cshtml"
using DapperCv.DTO.DTOs.CertificationDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\_ViewImports.cshtml"
using DapperCv.DTO.DTOs.EducationDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\_ViewImports.cshtml"
using DapperCv.DTO.DTOs.ExperienceDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\_ViewImports.cshtml"
using DapperCv.DTO.DTOs.InterestDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\_ViewImports.cshtml"
using DapperCv.DTO.DTOs.SkillsDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\_ViewImports.cshtml"
using DapperCv.DTO.DTOs.SocialMediaIconDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b43ea66b4acd541d9354da08aa8713541845ed5", @"/Views/Shared/Components/ExperienceComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ede84c4f465dfd00e9282e352809a3d8a22e159", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ExperienceComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ExperienceListDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section class=\"resume-section\" id=\"experience\">\r\n    <div class=\"resume-section-content\">\r\n        <h2 class=\"mb-5\">Yer Aldığım Projeler ve İşler</h2>\r\n");
#nullable restore
#line 6 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"d-flex flex-column flex-md-row justify-content-between mb-5\">\r\n                <div class=\"flex-grow-1\">\r\n                    <h3 class=\"mb-0\">");
#nullable restore
#line 10 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml"
                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <div class=\"subheading mb-3\">");
#nullable restore
#line 11 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml"
                                            Write(item.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <p>");
#nullable restore
#line 12 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml"
                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"flex-shrink-0\"><span class=\"text-primary\">\r\n    ");
#nullable restore
#line 15 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml"
Write(item.StartDate.ToString("Y"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" -\r\n");
#nullable restore
#line 16 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml"
                  
                    if (item.EndDate == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Present</span>\r\n");
#nullable restore
#line 20 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml"
                   Write(item.EndDate?.ToString("Y"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml"
                                                    
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </span></div>\r\n            </div>\r\n");
#nullable restore
#line 28 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\Shared\Components\ExperienceComponent\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ExperienceListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591