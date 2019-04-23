using System.Xml;

namespace Glad
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