bool kont = true;

static int zad3()
{
    int liczba;
    while (true)
    {
        string? input = Console.ReadLine();
        if (int.TryParse(input, out liczba))
        {
            return liczba;
        }
        else
        {
            Console.WriteLine("Wprowadź poprawną liczbę.");
        }
    }
}


while (kont)
{

    Console.WriteLine("Podaj pierwszą liczbę:");
    int a = zad3();

    Console.WriteLine("Podaj drugą liczbę:");
    int b = zad3();

    Console.WriteLine("Podaj trzecią liczbę:");
    int c = zad3();

    int[] num = { a, b, c };
    Array.Sort(num);

    if (num[0] * num[0] + num[1] * num[1] == num[2] * num[2])
    {
        Console.WriteLine("To jest trójkąt pitagoreski");
    }
    else
    {
        Console.WriteLine("To nie jest trójkąt pitagoreski");
    }

    Console.WriteLine("Czy chcesz kontynuować? (tak/nie)");
    string? odp = Console.ReadLine()?.ToLower();

    if (odp != "tak")
    {
        kont = false;
    }

};

