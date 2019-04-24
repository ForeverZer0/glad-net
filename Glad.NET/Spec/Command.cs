using System.Xml;

namespace Glad.Spec
{
    public class Command : EntryCollection<Parameter>, INamed
    {
        public Prototype Proto { get; }

        public string Name => Proto.Name;

        public string Alias { get; }

        public Command(XmlElement node) : base(node)
        {
            Proto = new Prototype(node["proto"]);

            foreach (XmlElement param in node.GetElementsByTagName("param"))
                Add(new Parameter(param));

            Alias = node["alias"]?.GetAttribute("name") ?? null;
        }

        public override string ToString() => Name;
    }
}