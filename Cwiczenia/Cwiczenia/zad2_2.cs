namespace Cwiczenia;

public class zad2_2
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
            if (delta < 0)
            {
                Console.WriteLine("Delta < 0");
                
            }
            else
            {
                double x1 = (Math.Sqrt(delta) - b) / 2 * a;
                double x2 = (-b - Math.Sqrt(delta)) / 2 * a;

                if (x1 == x2)
                {
                    Console.WriteLine("Trójmian ma jeden pierwiastek x= " + x1);
                }
                else
                {
                    Console.WriteLine("x1= {0:##.##}", x1);
                    Console.WriteLine("x2= {0:##.##}", x2);
                }
            }
        }
    }
}