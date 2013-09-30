using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RichWeb.Mvc
{
    public static class TemplateExtensions
    {
        public const string StartTag = "{{ #Start }}";
        public const string EndTag = "{{ /Start }}";
        public const int StartTagLen = 12;
        public const int EndTagLen = 12;
        
        public static string GetStart(this string template)
        {
            var start = template.IndexOf(StartTag, StringComparison.InvariantCultureIgnoreCase) + StartTagLen;
            var end = template.IndexOf(EndTag, StringComparison.InvariantCultureIgnoreCase);
            return template.Substring(start, end - start);
        }
    }
}