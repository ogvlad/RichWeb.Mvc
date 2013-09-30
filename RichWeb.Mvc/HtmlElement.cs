using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace RichWeb.Mvc
{
    public abstract class HtmlElement : IDisposable
    {
        protected string _id;
        protected readonly ViewContext _viewContext;
        protected IDictionary<string, object> _htmlAttributes = new Dictionary<string, object>();

        protected HtmlElement(string id, ViewContext viewContext)
        {
            _id = id;
            if (viewContext == null)
            {
                throw new ArgumentNullException("viewContext");
            }
            this._viewContext = viewContext;
        }

        public HtmlElement Attr(string key, string val)
        {
            _htmlAttributes[key] = val;
            return this;
        }

        public abstract HtmlElement Render();
        protected abstract void Dispose(bool disposing);

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}