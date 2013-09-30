using System.Runtime.Versioning;
using System.Web.Mvc;
using RichWeb.Mvc.TemplateEngine;

namespace RichWeb.Mvc.Bootstrap
{
    public class BootstrapRightPanel : HtmlElement
    {
        private bool _disposed;
        private string _title;
        private string _state;

        public BootstrapRightPanel(string id, string title, string state, ViewContext viewContext)
            : base(id, viewContext)
        {
            _title = title;
            _state = state;
        }

        public override HtmlElement Render()
        {
            var template = new Template(BootstrapRes.RightPanel.GetStart());
            template.Set("Id", _id);
            template.Set("Title", _title ?? "");
            template.Set("State", _state ?? "");

            _viewContext.Writer.Write(template.Render());
            return this;
        }

        protected override void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                _disposed = true;
                _viewContext.Writer.Write("</div>");
                _viewContext.Writer.Write("</div>");
                _viewContext.Writer.Write("</div>");
            }
        }
    }
}