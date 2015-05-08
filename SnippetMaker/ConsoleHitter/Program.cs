using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Utilities.Models;

namespace ConsoleHitter
{
    class Program
    {
        static void Main(string[] args)
        {
            var codeSnippets = new CodeSnippets();
            codeSnippets.CodeSnippet = new CodeSnippet
            {
                Header = new Header
                {
                    Title = "Title",
                    Author = "Me",
                    Shortcut = "testicle"
                },
                Snippet = new Snippet
                {
                    //References = new List<Reference>
                    //{
                    //    new Reference { Assembly = "REFERENCE" },
                    //    new Reference { Assembly = "REFERENCE" },
                    //    new Reference { Assembly = "REFERENCE" },
                    //},
                    Declarations = new Declarations
                    {
                        Object = new List<Utilities.Models.Object>
                        {
                            new Utilities.Models.Object { Default = "DEFAULT", ID = "DEC", Tooltip = "TOOLTIP", Type = "string" },
                            new Utilities.Models.Object { Default = "DEFAULT", ID = "DEC", Tooltip = "TOOLTIP", Type = "string" },
                            new Utilities.Models.Object { Default = "DEFAULT", ID = "DEC", Tooltip = "TOOLTIP", Type = "string" },
                        }.ToArray(),
                        Literal = new List<Literal>
                        {
                            new Literal { Default = "DEFAULT", ID = "DEC2", Tooltip = "TOOLTIP", Type = "string" },
                        }.ToArray(),
                    },
                    //Imports = new List<Import>
                    //{
                    //    new Import { Namespace = "Namespace" },
                    //    new Import { Namespace = "Namespace" },
                    //    new Import { Namespace = "Namespace" },
                    //},
                    Code = new Code
                    {
                        Language = "CSharp",
                        Content = "Console.WriteLine(\"12345\");"
                    }
                }
            };

            using (var stream = new StreamWriter(@"C:\temp\text.snippet"))
            {
                var serializer = new XmlSerializer(typeof(CodeSnippets), "http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet");
                serializer.Serialize(stream, codeSnippets);
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
