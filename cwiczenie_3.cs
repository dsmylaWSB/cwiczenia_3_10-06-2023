int n, k;

while(true)
{
    Console.Write("Podaj wartość n nie mniejszą niż 5: ");
    n = int.Parse(Console.ReadLine()); 

    Console.Write("Podaj wartość k nie mniejszą niż 5: ");
    k = int.Parse(Console.ReadLine()); 


    if (n >= 5 && k >= 5)
        break;
    else
        Console.WriteLine("Wartość n i/lub k jest mniejsza niż 5. \n");
}


// wynik = (n! - k!) / k!
double ksilnia = silnia(k);
double nsilnia = silnia(n);

double wynik = (nsilnia - ksilnia) / ksilnia;

Console.WriteLine($"Wynik to: {wynik}");

int silnia(int liczba)
{
    if (liczba == 0)
        return 1;
    else
        return liczba * silnia(liczba - 1);
}
