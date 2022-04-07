string dzialanie = "1234";
//int[] liczby = new int[dzialanie.Length];
char[] znak = new char[dzialanie.Length];
//string[] splitDzialanie = new string[dzialanie.Length];

/*
 liczba[0] = Int32.Parse(str);
 liczba[0] = liczba[0] - 1000;
 Console.WriteLine(liczba[0]);
 */
#pragma warning disable CS8974 // Konwertowanie grupy metod na typ inny niż delegowany
Console.WriteLine(Cos.returnCos);
#pragma warning restore CS8974 // Konwertowanie grupy metod na typ inny niż delegowany


for (int i = 0; i < dzialanie.Length; i++)
{
    //zmienne pomocnicze

    bool czyZnak = !char.IsNumber(dzialanie[i]);
    int ktoryZnak = 0;
    
     if (czyZnak)
     {
         znak[ktoryZnak] = dzialanie[i];
         ktoryZnak++;
     }
    

}

class Cos
{
    public Cos(string txt)
    {
        Console.WriteLine(txt);
    }

    public static string returnCos()
    {
        string b = new string("sdadsadada");
        return b;
    }
}