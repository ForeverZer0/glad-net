using System.Xml;

namespace Glad
{
    public abstract class NamedEntryCollection<T> : EntryCollection<T>, INamed where T : Entry
    {
        public string Name { get; }

        protected NamedEntryCollection(XmlElement node) : base(node)
        {
            Name = node.GetAttribute("name");
            if (string.IsNullOrWhiteSpace(Name))
                throw new XmlException("Item must have name attribute.");
        }

        public override string ToString() => $"{Name} [{Count}]";
    }
}