
namespace Program {

 using AljabarLibraries;
 class Program
    {
  static void Main(string[] args)
  {
     AljabarLibraries aljabar = new AljabarLibraries();
     double[] hasil = aljabar.AkarPersamaanKuadrat(new double[] { 1, 3, -10 });
     foreach (double item in hasil)
     {
          Console.Write(item + " ");
     }
     Console.WriteLine();
     double[] hasil2 = aljabar.HasilKuadrat(new double[] { 2,-3 });
     foreach (double item in hasil2)
     {
         Console.Write(item + " ");
     }

        }
 }
}