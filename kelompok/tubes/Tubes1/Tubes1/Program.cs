// See https://aka.ms/new-console-template for more information
public class Kalender
{
    public enum Month
    {
        Januari, Februari, Maret, April, Mei, Juni, Juli, Agustus, September,
        Oktober, November, Desember
    }
    public static int GetDays(Month month)
    {
        int[] daysPerMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        return daysPerMonth[(int)month];
    }
}

class Program
{
    static void Main()
    {
        Kalender.Month month = Kalender.Month.Januari;
        Console.WriteLine((int)month);
        int days = Kalender.GetDays(month);
        Console.WriteLine($"{month} has {days} days.");
    }
}
