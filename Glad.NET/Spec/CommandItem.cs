using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Glad.Spec
{
    public abstract class CommandItem : Entry, INamed
    {
        public string Name { get; }

        public List<string> Words { get; }

        public string Canonical => string.Join(' ', Words);

        public string Group { get; }

        protected CommandItem(XmlElement node) : base(node)
        {
            Name = node["name"].InnerText;
            if (string.IsNullOrWhiteSpace(Name))
                throw new XmlException("Prototype name cannot be null/empty.");

            Words = new List<string>();
            foreach (XmlNode child in node.ChildNodes)
                Words.Add(child.InnerText.Trim());

            Group = node.HasAttribute("group") ? node.GetAttribute("group") : null;
        }

        public override string ToString() => Name;

        /// <summary>
        /// Gets a value indicating if the underlying type type is a pointer.
        /// </summary>
        public bool IsPointer => Words.Any(w => w.Contains("*"));

        public bool IsConstPointer => Words.Any(w => w.Contains("const"));

        public bool IsConstConstPointer => Words.FindAll(w => w.Contains("const")).Count > 1;
    }
}