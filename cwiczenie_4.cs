// Podejście pierwsze - podstawienie do wzoru matematycznego, błąd około 1-2%

Console.WriteLine("Podaj kwote początkową: ");
double kwotaPoczatkowa = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj oprocentowanie: ");
double p = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj liczbę miesięcy: ");
double k = double.Parse(Console.ReadLine());

double n = k / 12;

//Kn = K * ( 1 + p/(100*k ) )^(n*k)  <- wzór ze szkoły średniej

// obliczenia
double nawias = (1 + (p / (100 * k)));

double potega = Math.Pow(nawias, (n * k));

double kwota = kwotaPoczatkowa * potega;


double kwotaKoncowa = kwotaPoczatkowa + ((kwota - kwotaPoczatkowa) * 0.81);
Console.WriteLine($"Zarobisz: {(kwota - kwotaPoczatkowa) * 0.81}");
Console.WriteLine($"Wypłacisz: {kwotaKoncowa}");


// Podejście drugie - nieudana próba rozwiązania tego w pętli, zależnie od wielkości liczb błąd 10-20%

//Console.WriteLine("Podaj kwote początkową: ");
//double kwota = double.Parse(Console.ReadLine());
//Console.WriteLine("Podaj oprocentowanie: ");
//double p = double.Parse(Console.ReadLine());
//Console.WriteLine("Podaj liczbę miesięcy: ");
//double k = double.Parse(Console.ReadLine());

//double holder = kwota;

////obliczenia
//for(int i = 0; i < k; i++)
//{
//    double odsetkiZaJedenMiesiac =
//                (kwota * ((p / 12) / 100));
//    kwota += odsetkiZaJedenMiesiac;
//    Console.WriteLine($"{i, -3}{kwota, -3}");
//}

//double podatekBelki = 0.81d;


//Console.WriteLine($"\n\nOdsetki bez opodatkowania: {kwota-holder, -10}\n" +
//                  $"Odsetki po opodatkowaniu: {(kwota - holder) * podatekBelki, -10}\n" +
//                  $"Kwota końcowa po opodatkowaniu: {kwota + ((kwota - holder) * podatekBelki), -10}\n");