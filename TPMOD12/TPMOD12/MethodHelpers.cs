internal static class MethodHelpers
{
    public static string CariTandaBilangan(int a)
    {
        if (a == 0)
        {
            return "Bilangan Nol";
        }
        else if (a > 0)
        {
            return "Bilangan Positif";
        }
        else
        {
            return "Bilangan Negatif";
        }
    }
}