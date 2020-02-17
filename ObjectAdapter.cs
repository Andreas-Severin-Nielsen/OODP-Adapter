using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Adapter
{
    class ObjectAdapter : ITarget
    {
        private Adaptee adaptee;

        public ObjectAdapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public string CompatibleOperation()
        {
            return adaptee.IncompatibleOperation();
        }
    }
}
