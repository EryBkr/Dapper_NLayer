#pragma checksum "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\Shared\Components\AboutComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "448633b03e84ddd079db010f25b748f46ffee037"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutComponent/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"448633b03e84ddd079db010f25b748f46ffee037", @"/Views/Shared/Components/AboutComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ede84c4f465dfd00e9282e352809a3d8a22e159", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AboutComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUserListDto>
    {
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
        private global::DapperCv.WebUI.TagHelpers.SocialMediaIconTagHelper __DapperCv_WebUI_TagHelpers_SocialMediaIconTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section class=\"resume-section\" id=\"about\">\r\n    <div class=\"resume-section-content\">\r\n        <h1 class=\"mb-0\">\r\n            ");
#nullable restore
#line 6 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\Shared\Components\AboutComponent\Default.cshtml"
       Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span class=\"text-primary\">");
#nullable restore
#line 7 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\Shared\Components\AboutComponent\Default.cshtml"
                                  Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </h1>\r\n        <div class=\"subheading mb-5\">\r\n            ");
#nullable restore
#line 10 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\Shared\Components\AboutComponent\Default.cshtml"
       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ·\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 330, "\"", 356, 2);
            WriteAttributeValue("", 337, "mailto:", 337, 7, true);
#nullable restore
#line 11 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\Shared\Components\AboutComponent\Default.cshtml"
WriteAttributeValue("", 344, Model.Email, 344, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\Shared\Components\AboutComponent\Default.cshtml"
                                     Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("<a>\r\n        </div>\r\n        <p class=\"lead mb-5\">");
#nullable restore
#line 13 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\Shared\Components\AboutComponent\Default.cshtml"
                        Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" .</p>\r\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getIcons", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "448633b03e84ddd079db010f25b748f46ffee0376763", async() => {
            }
            );
            __DapperCv_WebUI_TagHelpers_SocialMediaIconTagHelper = CreateTagHelper<global::DapperCv.WebUI.TagHelpers.SocialMediaIconTagHelper>();
            __tagHelperExecutionContext.Add(__DapperCv_WebUI_TagHelpers_SocialMediaIconTagHelper);
#nullable restore
#line 15 "C:\Users\Blackerback\OneDrive\Masaüstü\DapperCv\DapperCv.WebUI\Views\Shared\Components\AboutComponent\Default.cshtml"
__DapperCv_WebUI_TagHelpers_SocialMediaIconTagHelper.UserId = 1;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("user-id", __DapperCv_WebUI_TagHelpers_SocialMediaIconTagHelper.UserId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUserListDto> Html { get; private set; }
    }
}
#pragma warning restore 1591