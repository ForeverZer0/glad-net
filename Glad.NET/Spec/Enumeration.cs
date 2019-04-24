using System.Xml;

namespace Glad.Spec
{
    public class Enumeration : EntryCollection<EnumMember>
    {
        public string Namespace { get; }

        public string Group { get; }

        public string Type { get; }

        public string Vendor { get; }

        public Enumeration(XmlElement node) : base(node)
        {
            Namespace = node.GetAttribute("namespace");
            Group = node.HasAttribute("group") ? node.GetAttribute("group") : null;
            Type = node.HasAttribute("type") ? node.GetAttribute("type") : null;
            Vendor = node.HasAttribute("vendor") ? node.GetAttribute("vendor") : null;
            foreach (XmlElement member in node.GetElementsByTagName("enum"))
                Add(new EnumMember(member));
        }
    }
}