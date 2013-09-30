using System.Web.Mvc;

namespace RichWeb.Mvc.Bootstrap
{
    public class BootstrapDialog : HtmlElement
    {
        private bool _disposed;

        public BootstrapDialog(string id, ViewContext viewContext)
            : base(id, viewContext)
        {
        }

        public override HtmlElement Render()
        {
            var content = new TagBuilder("div");
            content.AddCssClass("modal-content");

            var dialog = new TagBuilder("div");
            dialog.AddCssClass("modal-dialog");

            var wrapper = new TagBuilder("div");
            wrapper.MergeAttributes<string, object>(_htmlAttributes);
            wrapper.AddCssClass("modal");
            wrapper.AddCssClass("fade");
            if (_id != null && _id.Trim().Length > 0)
            {
                wrapper.MergeAttribute("id", _id);
            }
            wrapper.MergeAttribute("role", "dialog");

            _viewContext.Writer.Write(wrapper.ToString(TagRenderMode.StartTag));
            _viewContext.Writer.Write(dialog.ToString(TagRenderMode.StartTag));
            _viewContext.Writer.Write(content.ToString(TagRenderMode.StartTag));
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