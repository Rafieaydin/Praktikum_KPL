// See https://aka.ms/new-console-template for more information
using System;
using tpmodul2_1302220065;
using static tpmodul2_1302220065.Soal1;
using static tpmodul2_1302220065.Soal2;

namespace mainApp;
class mainApps
{

    static void Main(String[] args)
    {
        Soal1.soal(); // static version

        Soal2 s2 = new Soal2(); // unstatic version
        s2.soal();
    }

}
