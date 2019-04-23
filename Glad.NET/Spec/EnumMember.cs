using System.Xml;

namespace Glad
{
    public class EnumMember : NamedEntry
    {
        public string Value { get; }

        public string Alias { get; }

        public string Vendor { get; }

        public EnumMember(XmlElement node) : base(node)
        {
            Value = node.GetAttribute("value");
            if (string.IsNullOrWhiteSpace(Value))
                throw new XmlException("Value cannot be null/empty.");
            Alias = node.HasAttribute("alias") ? node.GetAttribute("alias") : null;
            Vendor = node.HasAttribute("vendor") ? node.GetAttribute("vendor") : null;
        }
    }
}