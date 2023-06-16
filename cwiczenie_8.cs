// wejście czyli przyjmujemy wartość
// jeżeli ujemna to mniejsza
// jeżeli dodatnia to większa
// zero return


int licznik = -1;
int[] kroki = new int[] { 5, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1};
int[] liczby = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

sprawdz(9); // 10 

void sprawdz(int id)
{
    int odpowiedz;
    while (id >= liczby.Length || id < 0)
    {
        Console.WriteLine($"Liczba o której myślisz nie może być większa niż 20 i mniejsza niż 0.\nZadecyduj ponownie, czy liczba jest większa czy mniejsza: ");
        odpowiedz = int.Parse(Console.ReadLine());
        if (odpowiedz > 0)
            if (id + kroki[licznik] >= liczby.Length)
                id = 19;
            else
                id = id + kroki[licznik];
        else
            if (id - kroki[licznik] < 0)
                id = 0;
            else    
                id = id - kroki[licznik];
    }

    Console.WriteLine($"Czy liczba {liczby[id]} to ta o której myślisz?");
    odpowiedz = int.Parse(Console.ReadLine());
    if (odpowiedz > 0)
    {
        licznik++;
        sprawdz(id + kroki[licznik]);
    }
    else if (odpowiedz < 0)
    {
        licznik++;
        sprawdz(id - kroki[licznik]);
    }
    else
    {
        Console.WriteLine($"liczba o której myślisz to: {liczby[id]}");
        return;
    }

}


// 5 -> 4 - 3 - 2 -1 

// 10 - 5 - 9 - 6 - 8 - 7

// 5 2 2 1 1 1 1 1 1
// 1 2 3 4 5 6 7 8 9 10


