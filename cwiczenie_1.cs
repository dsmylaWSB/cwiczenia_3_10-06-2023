Console.WriteLine("Podaj podstawę: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj wykładnik: ");
int b = int.Parse(Console.ReadLine());


int wynik = 1;
for(int i = 0; i < b; i++)
{
    wynik = wynik * a;
}

Console.WriteLine(wynik);