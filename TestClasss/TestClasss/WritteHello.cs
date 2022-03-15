namespace TestClasss;

public class WritteHello
{
    void wypiszTak()
    {
        Console.WriteLine("Hello tak");
    }

    void wypiszNie()
    {
        Console.WriteLine("Hello nie");
    }

    public WritteHello(bool wypisz)
    {
        if (wypisz == true)
        {
            wypiszTak();
        }
        else
        {
            wypiszNie();
        }
    }
}