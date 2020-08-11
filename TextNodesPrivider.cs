using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proxy
{
    internal static class TextNodesProvider
    {
        internal static string Xpath()
        {
            return "*//descendant-or-self::text()";
            /*
            return "//" + string.Join("|//", new List<string>(){
                "a",
                "header", "title",
                "h1", "h2", "h3", "h4", "h5", "h6",
                "li",
                "p",
                "div",
                "article",
                "aside",
                "details",
                "hgroup",
                "footer",
                "nav",
                "section",
                "span",
                "summary"
            }.Select(i => i + "/descendant-or-self::text()"));
            */
        }
    }
}
