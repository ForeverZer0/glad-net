using System.Xml;

namespace Glad.Spec
{
    public class Group : NamedEntryCollection<NamedEntry>
    {
        public Group(XmlElement node) : base(node)
        {
            foreach (XmlElement child in node.GetElementsByTagName("enum"))
                Add(new NamedEntry(child));
        }
    }
}