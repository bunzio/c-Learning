using System.ComponentModel.Design;
using System.Data;

namespace Cwiczenia;

public static class zad2_1
{
    public static void zad()
    {
        Console.WriteLine("Program sprawdza czy trzy liczby tworza trójkę pitagorejską");
        Console.WriteLine("Podal liczbę a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Podal liczbę a:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Podal liczbę a:");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Wynik:  " + Check(a,b,c));
    }
    
    private static bool Check(int a, int b, int c)
    {
        double count = Math.Pow(a,2) + Math.Pow(b,2);
        Console.WriteLine(count);
        bool resault = (count == Math.Pow(c,2));
        return resault;
    }
}