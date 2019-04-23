using System.Xml;

namespace Glad
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