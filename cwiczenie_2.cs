Console.Write("Ile wyrazów ciągu: ");
long n = long.Parse(Console.ReadLine());

long a = 0, b = 1, c;

for (int i = 0; i < n; i++)
{
    if (i <= 1)
        c = i;
    else
    {
        c = a + b;
        a = b;
        b = c;
    }
    Console.WriteLine(c);
}
