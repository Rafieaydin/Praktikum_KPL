using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloGeneric
{
    internal class HaloGeneric<t>
    {
        private t data;
        public HaloGeneric(t data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Halo " + data);
        }
    }
}
