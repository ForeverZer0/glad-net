using System.Xml;

namespace Glad
{
    public class Parameter : CommandItem
    {
        public string LengthParam { get; }

        public string Type { get; }

        public Parameter(XmlElement node) : base(node)
        {
            LengthParam = node.HasAttribute("len") ? node.GetAttribute("len") : null;
            Type = node["ptype"]?.InnerText;
      

        }
    }
}