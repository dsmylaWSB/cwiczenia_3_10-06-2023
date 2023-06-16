//"wypisanie osobno KOLEJNYCH cyfr dowolnej liczby naturalnej" zinterpretowałem jako wypisanie ich od najmniejszej do największej cyfry
void wypiszMiTeCyfry(string liczba)
{
    List<int> listaIntow = new List<int> { };
    

    for (int i = 0; i < liczba.Length; i++)
    {
        listaIntow.Add(
                Convert.ToInt32(Char.GetNumericValue(liczba[i]))
            );
    }

    listaIntow.Sort();

    foreach (int l in listaIntow)
    {
        Console.WriteLine($"{l,3}");

    }
}

string liczba = Console.ReadLine();

wypiszMiTeCyfry(liczba);