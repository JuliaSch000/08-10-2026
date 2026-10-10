// Pobieranie

Console.WriteLine("Imię?");
string name = Console.ReadLine()!;

Console.WriteLine("Max HP?");
int HPMAX = int.Parse(Console.ReadLine()!);
Console.WriteLine("Obecne HP?");
int HP = int.Parse(Console.ReadLine()!);

Console.WriteLine("Siła?");
int ATK = int.Parse(Console.ReadLine()!);
Console.WriteLine("Siła broni?");
int weaponATK = int.Parse(Console.ReadLine()!);
Console.WriteLine("Mnożnik ataku specjalnego");
double specialMnoznik = double.Parse(Console.ReadLine()!);

Console.WriteLine("Ilość ataków?");
int ATKcount = int.Parse(Console.ReadLine()!);


// zmiany typu wartosci

double ATKdouble = (double)ATK;
double weaponATKdouble = (double)weaponATK;
double specialMnoznikdouble = (double)specialMnoznik;
decimal HPdec = (decimal)HP;
decimal HPMAXdec = (decimal)HPMAX;

// Obliczenia

int normalAttack = ATK + weaponATK;
double specialAttack = normalAttack * specialMnoznik;
int specialAttackInt = (int)specialAttack;
int combo = specialAttackInt + normalAttack * ATKcount;
bool zyje = HP > 0;
bool maPelneZdrowie = HP == HPMAX;
decimal procentHP = (HPdec / HPMAXdec) * 100;


Console.WriteLine($"========== RAPORT Z WALKI ==========");
Console.WriteLine($"Bohater:\t{name}");
Console.WriteLine($"Zdrowie:\t{HP}/{HPMAX}-({procentHP:f2}%)");
Console.WriteLine($"Zwykły atak:\t{normalAttack}");
Console.WriteLine($"Atak specjalny:\t{specialAttack}");
Console.WriteLine($"Łączne zadaane obrażenia:{combo}");
Console.WriteLine($"Żyje:\t{zyje}");
Console.WriteLine($"Pełne zdrowie:\t{maPelneZdrowie}");
Console.WriteLine($"====================================");