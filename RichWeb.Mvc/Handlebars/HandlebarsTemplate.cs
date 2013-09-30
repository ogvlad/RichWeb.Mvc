using System.Web.Mvc;

namespace RichWeb.Mvc.Handlebars
{
    public class HandlebarsTemplate : HtmlElement
    {
        private bool _disposed;

        public HandlebarsTemplate(string id, ViewContext viewContext)
            : base(id, viewContext)
        {
        }

        public override HtmlElement Render()
        {
            var wrapper = new TagBuilder("script");
            wrapper.MergeAttributes<string, object>(_htmlAttributes);
            if (_id != null && _id.Trim().Length > 0)
            {
                wrapper.MergeAttribute("id", _id);
            }
            wrapper.MergeAttribute("type", "text/x-handlebars-template");

            _viewContext.Writer.Write(wrapper.ToString(TagRenderMode.StartTag));
            return this;
        }

        protected override void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                _disposed = true;
                _viewContext.Writer.Write("</script>");
            }
        }
    }
}