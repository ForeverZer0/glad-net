using System;
using System.Collections.Generic;
using System.Xml;

namespace Glad
{
    public class Feature : NamedEntryCollection<FeatureItem>
    {
        public Api Api { get; }
        
        public Version Version { get; }

        public Feature(XmlElement node) : base(node)
        {
            var api = node.GetAttribute("api");
            if (string.IsNullOrWhiteSpace(api))
                throw new XmlException("Feature API cannot be null/empty.");
            Api = Enum.Parse<Api>(api, true);
            
            Version = Version.Parse(node.GetAttribute("number"));

            foreach (XmlNode child in node.ChildNodes)
            {
                if (child is XmlElement elem)
                {
                    var profile = GetProfile(elem);
                    var action = GetAction(elem);
                    foreach (var entry in child.ChildNodes)
                    {
                        if (entry is XmlElement item)
                            Add(new FeatureItem(item, profile, action));
                    }   
                }
                                 
             
            }
        }

        private static Profile GetProfile(XmlElement node)
        {
            var name = node.GetAttribute("profile");
            if (string.IsNullOrWhiteSpace(name))
                return Profile.All;
            if (name.Equals("core", StringComparison.Ordinal))
                return Profile.Core;
            if (name.Equals("compatibility", StringComparison.Ordinal))
                return Profile.Compatibility;
            if (name.Equals("common", StringComparison.Ordinal))
                return Profile.Common;
            throw new XmlException("Unknown OpenGL profile.");
        }

        private static FeatureAction GetAction(XmlElement node)
        {
            var name = node.Name;
            if (name.Equals("require", StringComparison.Ordinal))
                return FeatureAction.Require;
            if (name.Equals("remove", StringComparison.Ordinal))
                return FeatureAction.Remove;
            throw new XmlException("Unknown action.");
        }
    }
}