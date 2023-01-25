namespace Cwiczenia;

public class zad2_3
{
    public static void zad()
    {
        Console.WriteLine("Program oblicza pierwiastki równania ax^2+bx+c");
        Console.WriteLine("Podaj wartość a: ");
        double a= double.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("Błędna wartość");
        }
        else
        {
            Console.WriteLine("Podaj wartosc b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartosc c: ");
            double c = double.Parse(Console.ReadLine());

            double delta = Math.Pow(b, 2) - 4 * a * c;
            switch (delta)
            {
                case < 0.0:
                    Console.WriteLine("Delta < 0");
                    break;
                case 0.0:
                    double x = (- b) / 2 * a;
                    Console.WriteLine("Trójmian ma jeden pierwiastek x= {0.##.##}", x);
                    break;
                case > 0.0:
                    double x1 = (Math.Sqrt(delta) - b) / 2 * a;
                    double x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine("x1= {0:##.##}", x1);
                    Console.WriteLine("x2= {0:##.##}", x2);
                    break;
            }
        }
    }
}