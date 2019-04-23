using System;
using System.Collections.Generic;

namespace Glad.NET
{
    internal class Program
    {
        public const string GL_XML = @"https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/master/xml/gl.xml";
        
       
        public static ISet<string> UNUSED = new HashSet<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var spec = new GlSpec("gl.xml");
            spec.Parse();
            
            Console.WriteLine(Api.GL.HasFlag(Api.Disabled));
            

//            Console.WriteLine(string.Join(',', UNUSED));
//            Console.ReadLine();
        }
    }
}
