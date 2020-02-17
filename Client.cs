using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Adapter
{
    class Client
    {
        public void RunTask()
        {
            // ObjectAdapter: creating and configuring the object adapter...
            Target objectAdapter = new ObjectAdapter(new Adaptee());
            // ObjectAdapter: performing the incompatible operation...
            Console.WriteLine("Using ObjectAdapter: " + objectAdapter.CompatibleOperation());

            // ClassAdapter: creating the class adapter...
            Target classAdapter = new ClassAdapter();
            // ClassAdapter: performing the incompatible operation...
            Console.WriteLine("Using ClassAdapter: " + classAdapter.CompatibleOperation());
        }


    }
}
