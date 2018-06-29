using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_Parser
{
    public class Uri_Parser
    {
           
        public string scheme { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public string host { get; set; }
        public string port { get; set; }
        public string path { get; set; }
        public string query { get; set; }
        public string fragment { get; set; }

        public Uri_Parser(Uri uri)
        {

        }
    }
}
