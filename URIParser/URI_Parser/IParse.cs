using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_Parser
{
    public interface IParse
    {

        string Scheme();
        string User();
        string Password();
        string Host();
        int? Port();
        string Path();
        string Query();
        string Fragment();

    }
}
