using AutoMapper;
using DapperCv.Business.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCv.WebUI.TagHelpers
{
    //<getIcons user-id=3></getIcons>
    [HtmlTargetElement("GetIcons")]
    public class SocialMediaIconTagHelper : TagHelper
    {

        private readonly IAppUserService _userService;
        private readonly ISocialMediaService _socialMedia;
        private readonly IMapper mapper;

        public SocialMediaIconTagHelper(IAppUserService appUserService, IMapper mapper,ISocialMediaService socialMediaService)
        {
            _userService = appUserService;
            this.mapper = mapper;
            _socialMedia = socialMediaService;
        }

        public int UserId { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var icons=_socialMedia.GetByUserId(UserId);
            string data = $"<div class='social-icons'>";

            foreach (var item in icons)
            {
                data += $"<a class='social-icon' href='https://www.{item.Link}'><i class='{item.Icon}'></i></a>";
            }
            data += "</div>";

            output.Content.SetHtmlContent(data);
        }
    }
}
