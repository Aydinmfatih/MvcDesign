using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MvcDesign.TagHelpers
{
    public class TextTagHelper:TagHelper
    {
        public string Text { get; set; }
        public string Display { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.Add("class", Text);
            output.Content.Append(Display);
        }
    }
}
