int wartosc = 0;

Boolean isFactorial(int x)
{
    for (int i = 1; true; i++)
    {
        if (x % i == 0)
        {
            x /= i;
        }
        else
        {
            wartosc = i-1;
            break;
        }
    }

    if (x == 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}


Console.WriteLine("x = ");
int x = int.Parse(Console.ReadLine());
Boolean ans = isFactorial(x);

if (ans == true)
{
    Console.WriteLine($"Tak,  n = {wartosc}");
}
else
{
    Console.WriteLine("Nie");
}
