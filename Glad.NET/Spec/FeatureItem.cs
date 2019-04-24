using System;
using System.Xml;

namespace Glad.Spec
{
    public class FeatureItem : NamedEntry
    {
        public Profile Profile { get; }
        
        public FeatureType Type { get; }
        
        public FeatureAction Action { get; }
        
        public FeatureItem(XmlElement node, Profile profile, FeatureAction action) : base(node)
        {
            Profile = profile;
            Action = action;
            Type = GetFeatureType(node);
        }

        private static FeatureType GetFeatureType(XmlElement node)
        {
            var type = node.Name;
            if (type.Equals("command", StringComparison.Ordinal))
                return FeatureType.Command;
            if (type.Equals("enum", StringComparison.Ordinal))
                return FeatureType.Enum;
            if (type.Equals("type", StringComparison.Ordinal))
                return FeatureType.Type;
            throw new XmlException($"Unknown feature type: {type}");
        }
    }
}