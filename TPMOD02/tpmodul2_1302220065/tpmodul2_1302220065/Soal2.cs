using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul2_1302220065
{
    internal class Soal2
    {
        public  void soal()
        {
            Console.WriteLine("\nSoal 2");
            int[] arrInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("array yang tersedia : ");

            foreach (int i in arrInt)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Bilangan genapnya :");
            foreach (int i in arrInt)
            {
                if (i % 2 == 0) { Console.Write(i + " "); }
            }
        }
    }
}
