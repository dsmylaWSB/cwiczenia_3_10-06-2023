void wypiszPary(int n)
{
   
    int i = 1, j = n - 1;
    while (i < j)
    {
        if (i + j == n)
        {
            Console.WriteLine($"{i} + {j}");
        }

        // następna para
        i++;
        j--;
    }

    if (n % 2 == 0)
        Console.WriteLine($"{n / 2} + {n / 2}");
}




int n = int.Parse(Console.ReadLine());

wypiszPary(n);


//odpal i daj znać