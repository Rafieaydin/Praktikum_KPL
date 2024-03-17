// See https://aka.ms/new-console-template for more information
using DataGeneric;
class Program {
    public static void Main(string[] args)
    {
        DataGeneric<String> data = new DataGeneric<String>("1302220065");
        data.PrintData();
    }
}
