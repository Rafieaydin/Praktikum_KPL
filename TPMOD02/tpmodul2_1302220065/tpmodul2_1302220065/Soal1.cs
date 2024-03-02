using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul2_1302220065
{
    internal class Soal1
    {
        public static void soal()
        {
            Console.WriteLine("Soal 1");
            Console.WriteLine("Masukan satu huruf :");
            String huruf = Console.ReadLine();

            if (huruf.ToUpper() == "A" || huruf.ToUpper() == "I" || huruf.ToUpper() == "U" || huruf.ToUpper() == "E" || huruf.ToUpper() == "O")
            {
                Console.WriteLine("Huruf " + huruf + "Merupakan huruf vokal");
            }
            else
            {
                Console.WriteLine("Huruf " + huruf + "Merupakan huruf Konsonan");
            }
        }
    }

    


}
