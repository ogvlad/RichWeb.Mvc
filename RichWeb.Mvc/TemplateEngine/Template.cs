using System.Text;

namespace RichWeb.Mvc.TemplateEngine
{
    public class Template
    {
        private readonly StringBuilder _inner;

        public Template(string template)
        {
            _inner = new StringBuilder(template);
        }

        public Template Set(string key, string value)
        {
            _inner.Replace("{{ " + key + " }}", value);
            return this;
        }

        public string Render()
        {
            return _inner.ToString();
        }
    }
}