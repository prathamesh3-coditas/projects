using Microsoft.AspNetCore.Razor.TagHelpers;
using Coditas_MVCApps1_DataAccess.models;
using System.Reflection;

namespace MVCApps1.Custom_Tag_Helpers
{
    public class ListGenerator : TagHelper
    {
        //cats get value from @Model of IndexTagHelper.cshtml
        public IEnumerable<Object> obj { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "List";

            output.TagMode = TagMode.StartTagAndEndTag;

            var table = "<table class='table table-dark'>";

            foreach(var item in obj)
            {
                var t = item.GetType();

                PropertyInfo[] p = t.GetProperties();

                string op = "<tr>";

                foreach (var item1 in p)
                {
                    op += $"<td>{item1.GetValue(item)}</td>";
                }

                op += "</tr>";
                table += op;
            }

            table += "</table>";

            output.PreContent.SetHtmlContent(table);
        }
    }
}
