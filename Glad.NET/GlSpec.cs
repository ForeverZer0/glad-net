using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;

namespace Glad
{
    public sealed class GlSpec
    {
        private readonly XmlElement root;

        public List<Group> Groups { get; }

        public List<Enumeration> Enums { get; }

        public List<Command> Commands { get; }
        
        public List<Feature> Features { get; }
        
        public List<Extension> Extensions { get; }

        public GlSpec(string path)
        {
            var doc = new XmlDocument();
            doc.Load(path);
            root = doc.DocumentElement;

            Groups = new List<Group>();
            Enums = new List<Enumeration>();
            Commands = new List<Command>();
            Features = new List<Feature>();
            Extensions = new List<Extension>();
        }

        public void Parse()
        {
            ParseGroups();
            ParseEnums();
            ParseCommands();
            ParseFeatures();
            ParseExtensions();
        }

        private void ParseExtensions()
        {
            Extensions.Clear();
            foreach (XmlElement ext in root["extensions"].GetElementsByTagName("extension"))
            {
                Extensions.Add(new Extension(ext));
            }
        }

        private void ParseFeatures()
        {
            Features.Clear();
            foreach (var feature in root.GetElementsByTagName("feature"))
            {
                if (feature is XmlElement entry)
                    Features.Add(new Feature(entry));
            }
        }

        public async Task ParseAsync() => await new Task(Parse);

        private void ParseGroups()
        {
            Groups.Clear();
            foreach (XmlElement group in root["groups"].GetElementsByTagName("group"))
                Groups.Add(new Group(group));
        }

        private void ParseEnums()
        {
            Enums.Clear();
            foreach (XmlElement node in root.GetElementsByTagName("enums"))
                Enums.Add(new Enumeration(node));
        }

        private void ParseCommands()
        {
            Commands.Clear();
            foreach (XmlElement node in root["commands"].GetElementsByTagName("command"))
                Commands.Add(new Command(node));
        }

       
    }
}