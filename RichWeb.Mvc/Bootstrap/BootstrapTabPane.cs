using System.Runtime.Versioning;
using System.Web.Mvc;
using RichWeb.Mvc.TemplateEngine;

namespace RichWeb.Mvc.Bootstrap
{
    public class BootstrapTabPane : HtmlElement
    {
        private bool _disposed;
        private string _state;

        public BootstrapTabPane(string id, string state, ViewContext viewContext)
            : base(id, viewContext)
        {
            _state = state;
        }

        public override HtmlElement Render()
        {
            var template = new Template(BootstrapRes.TabPane.GetStart());
            template.Set("Id", _id);
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