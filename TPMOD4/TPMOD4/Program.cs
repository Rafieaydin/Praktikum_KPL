// See https://aka.ms/new-console-template for more information

using TPMOD4.kodepos;
using TPMOD4.kodepos1;
using TPMOD4.door;
using System;

namespace TPMOD4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contoh pertama :");
            KodePos kodepos = new KodePos();
            kodepos.setKodePost();
            kodepos.getKodePos();

            Console.WriteLine("\nContoh kedua :");
            KodePos1 kodepos1 = new kodepos1.KodePos1();
            kodepos1.getKodePos();

            Console.WriteLine("\nSoal ketiga :");
            DoorMachine door = new DoorMachine();
            door.run();
        }
    }
}
