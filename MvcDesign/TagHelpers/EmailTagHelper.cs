﻿using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MvcDesign.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string Mail { get; set; }
        public string Display { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.Add("href", $"mailto:{Mail}");
            output.Content.Append(Display); output.TagName = "a";
            output.Attributes.Add("href", $"mailto:{Mail}");
            output.Content.Append(Display);
        }
    }
}
