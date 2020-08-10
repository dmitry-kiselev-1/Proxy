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
            return "//" + string.Join("|", new List<string>(){
                "a",
                "header", "head", "title",
                "h1", "h2", "h3", "h4", "h5", "h6",
                "li", "p", "br",
                "article",
                "aside",
                "details",
                "hgroup",
                "footer",
                "nav",
                "p",
                "section",
                "span",
                "summary",
                "div"
            });
        }
    }
}
