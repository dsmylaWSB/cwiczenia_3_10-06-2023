Console.WriteLine("Podaj kwote początkową: ");
double kwotaPoczatkowa = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj oprocentowanie: ");
double p = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj liczbę miesięcy: ");
double k = double.Parse(Console.ReadLine());

double n = k / 12;

//Kn = K * ( 1 + p/(100*k ) )^(n*k)

// obliczenia
double nawias = (1 + (p / (100 * k)));

double potega = Math.Pow(nawias, (n * k));

double kwota = kwotaPoczatkowa * potega;


double kwotaKoncowa = kwotaPoczatkowa + ((kwota - kwotaPoczatkowa) * 0.81);
Console.WriteLine($"Zarobisz: {(kwota - kwotaPoczatkowa) * 0.81}");
Console.WriteLine($"Wypłacisz: {kwotaKoncowa}");