using System.Web.Mvc;

namespace RichWeb.Mvc.Bootstrap
{
    public static class BootstrapExtensions
    {
        public static HtmlElement BeginDialog(this HtmlHelper html, string id, bool renderImmediately = true)
        {
            var dlg = new BootstrapDialog(id, html.ViewContext);
            if (renderImmediately)
            {
                return dlg.Render();
            }
            return dlg;
        }
        public static HtmlElement BeginRightPanel(this HtmlHelper html, string id, string title, string state)
        {
            var element = new BootstrapRightPanel(id, title, state, html.ViewContext);
            return element.Render();
        }
        public static HtmlElement BeginTabPane(this HtmlHelper html, string id, string state = "")
        {
            var element = new BootstrapTabPane(id, state, html.ViewContext);
            return element.Render();
        }
    }
}