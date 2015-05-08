using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Utilities.Models
{
    public class Snippet
    {
        public List<Reference> References { get; set; }
        public List<Import> Imports { get; set; }
        public Declarations Declarations { get; set; }
        public Code Code { get; set; }
    }
}
