using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Adapter
{
    class ClassAdapter : Adaptee, Target
    {
        public string CompatibleOperation()
        {
            return this.IncompatibleOperation();
        }
    }
}
