using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloGeneric
{
    internal class HaloGeneric<T>
    {
        private T data;
        public HaloGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Halo " + data);
        }
    }
}
