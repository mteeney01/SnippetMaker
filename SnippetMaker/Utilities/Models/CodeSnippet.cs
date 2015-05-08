using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Utilities.Models
{
    public class CodeSnippet
    {
        [XmlAttribute("Format")]
        public string Format { get { return "1.0.0"; } set { value = "1.0.0"; } }

        public Header Header { get; set; }
        public Snippet Snippet { get; set; }
    }
}
