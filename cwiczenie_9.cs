string odwroc(string tekst)
{
    char[] tablicaZnakow = tekst.ToCharArray();
    string odwrocony = String.Empty;
    for (int i = tablicaZnakow.Length - 1; i > -1; i--)
    {
        odwrocony += tablicaZnakow[i];
    }
    return odwrocony;
}

// string -> char Array
// stwórz pustą tablice char <- wypełnij tekstem z tekst (na to jest metoda ToCharArray())
// odwro c 
// odwocony + c
// odwr o c
// odwrocony + o -> co
// odw r oc
// odwrocony + r -> cor

// Array.Reverse(tablicaZnakow); <- można też użyć tego i nie robić pętli for

Console.Write("Podaj liczbę którą chciałbyś obrócić: ");
string liczba = Console.ReadLine();

Console.WriteLine($"Proszę: {odwroc(liczba)}");








