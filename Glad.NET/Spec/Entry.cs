using System.Xml;

namespace Glad.Spec
{
    public abstract class Entry
    {
        protected Entry(XmlElement node)
        {
            Comment = node.HasAttribute("comment") ? node.GetAttribute("comment") : null;
        }

        public string Comment { get; }
    }
}