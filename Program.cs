bool kont = true;

while (kont)
{

Console.WriteLine("Podaj pierwszą liczbę:");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Podaj drugą liczbę:");
int b = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Podaj trzecią liczbę:");
int c = int.Parse(Console.ReadLine() ?? "0");

if (a * a + b * b == c * c)
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

}