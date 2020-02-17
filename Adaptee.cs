using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Adapter
{
    class Adaptee
    {
        private string txt = "This is text from adaptee";

        public string IncompatibleOperation()
        {
            return txt;
        }
    }
}
