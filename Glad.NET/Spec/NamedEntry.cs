using System.Xml;

namespace Glad.Spec
{
    public class NamedEntry : Entry, INamed
    {
        public NamedEntry(XmlElement node) : base(node)
        {
            Name = node.GetAttribute("name");
            if (string.IsNullOrWhiteSpace(Name))
                throw new XmlException("Item must have name attribute.");
        }

        public string Name { get; }

        public override string ToString() => Name;
    }
}