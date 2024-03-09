// See https://aka.ms/new-console-template for more information

using TPMOD4.kodepos;
using System;

namespace TPMOD4
{
    class Program
    {
        static void Main(string[] args)
        {
            KodePos kodepos = new KodePos();
            kodepos.setKodePost();
            kodepos.getKodePos();
            Console.WriteLine("Hello, World!");
        }
    }
}
