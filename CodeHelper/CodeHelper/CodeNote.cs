using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace CodeHelper
{
    public class CodeNote
    {
        public string noteName { get; set; }
        public string noteDescr { get; set; }
        public IDictionary<string, string> noteOptions { get; set; }

        public Dictionary<string, string> GetOptions()
        {
            return (Dictionary<string, string>)noteOptions;
        }

        public void SetOptions(string key, string value)
        {
            noteOptions[key] = value;
        }
    }
}
