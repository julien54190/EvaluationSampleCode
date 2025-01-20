using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode
{
    // Rappelez vous ce que je vous ai dit concernant les tests sur des chaînes de caractères
    public class HtmlFormatHelper
    {
        public string GetStrongFormat(string content)
        {
            return $"<strong>{content}</strong>";
        }

        public string GetItalicFormat(string content)
        {
            return $"<i>{content}</i>";
        }

        // Plus difficile
        public string GetFormattedListElements(List<string> contents)
        {
            var htmlList = new StringBuilder();
            htmlList.Append("<ul>");

            contents.ForEach(x => {
                htmlList.Append("<li>");
                htmlList.Append(x);
                htmlList.Append("</li>");
            });

            htmlList.Append("</ul>");
            return htmlList.ToString();
        }
    }
}
