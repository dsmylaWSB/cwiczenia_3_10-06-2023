Console.WriteLine("Podaj numer przybliżenia: ");
int numerPrzyblizenia = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj numer x: ");
double x = double.Parse(Console.ReadLine());

double wartoscPrzyblizenia = 0;
int i = 0;

if(x == 0)
{
    Console.WriteLine("1");
}
else if(x == 1)
{
    Console.WriteLine("2.71828");
}
else
{
    for (i = 0; i < numerPrzyblizenia; i++)
    {

        double silniaZI = (double)(silnia(i));

        wartoscPrzyblizenia = wartoscPrzyblizenia + (Math.Pow(x, i) / silniaZI);

    }

    Console.WriteLine(wartoscPrzyblizenia);
}


int silnia(int liczba)
{
    if (liczba == 0)
        return 1;
    else
        return liczba * silnia(liczba - 1);
}