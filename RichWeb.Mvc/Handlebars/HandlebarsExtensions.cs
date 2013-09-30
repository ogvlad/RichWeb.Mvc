using System.Web.Mvc;

namespace RichWeb.Mvc.Handlebars
{
    public static class HandlebarsExtensions
    {
        public static HtmlElement BeginTemplate(this HtmlHelper html, string id, bool renderImmediately = true)
        {
            var dlg = new HandlebarsTemplate(id, html.ViewContext);
            if (renderImmediately)
            {
                return dlg.Render();
            }
            return dlg;
        }
    }
}