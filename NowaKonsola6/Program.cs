// dane

const char symbol = '#';

Console.WriteLine("Imię?");
string name = Console.ReadLine()!;
Console.WriteLine("Siła bohatera?");
int ATK = int.Parse(Console.ReadLine()!);
Console.WriteLine("Maksymalne HP?");
int HPMAX = int.Parse(Console.ReadLine()!);
Console.WriteLine("Obecne HP?");
int HP = int.Parse(Console.ReadLine()!);
Console.WriteLine("Siła broni?");
int weaponATK = int.Parse(Console.ReadLine()!);
Console.WriteLine("Mnożnik ataku specjalnego?");
double specialMnoznik = double.Parse(Console.ReadLine()!);
Console.WriteLine("Złoto?");
int G = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ile jest miejsc w drużynie?");
int teamRoom = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ile jest pozostałych członków drużyny?");
int team = int.Parse(Console.ReadLine()!);
team += 1;
Console.WriteLine("Masz klucz?");
bool maKlucz = bool.Parse(Console.ReadLine()!);
Console.WriteLine("Masz mapę?");
bool maMape = bool.Parse(Console.ReadLine()!);





// obliczenia

int silaAtaku = ATK + weaponATK;
double SAdouble = (double)silaAtaku;
//
double specjalnyAtak = SAdouble * specialMnoznik;
//
bool maMiejsce = !maKlucz || !maMape;
//
int pozMiejsca = teamRoom - team;
//
int Gperperson = G / team;
int reszta = G % team;
//
decimal HPMAXdec = (decimal)HPMAX;
decimal HPdec = (decimal)HP;
decimal procentZycia = (HPdec / HPMAXdec) * 100;
//
bool maPelneHP = HP == HPMAX;
bool zyje = HP > 0;
bool gotowyDoWyprawy = HP >= 50 && !maMiejsce;
 


// karta


Console.WriteLine("+==========================================+");
Console.WriteLine("\t\tKARTA BOHATERA\t\t\t");
Console.WriteLine("+==========================================+");
Console.WriteLine($"{symbol}\t\t\t\t{name}");
Console.WriteLine($"HP:\t\t\t\t{HP}/{HPMAX} - {procentZycia:f2}%");
Console.WriteLine($"Siła:\t\t\t\t{silaAtaku}");
Console.WriteLine($"Atak specjalny:\t\t\t{specjalnyAtak}");
Console.WriteLine("+------------------------------------------+");
Console.WriteLine($"Ilość członków drużyny:\t\t{team}");
Console.WriteLine($"Wolne miejsca w drużynie:\t{pozMiejsca}");
Console.WriteLine($"Złoto:\t\t\t\t{G}");
Console.WriteLine($"Złoto dla jednej osoby:\t\t{Gperperson}");
Console.WriteLine($"Złoto pozostające w skarbcu:\t{reszta}");
Console.WriteLine("+------------------------------------------+");
Console.WriteLine($"Żyje:\t\t\t\t{zyje}");
Console.WriteLine($"Ma pełne HP:\t\t\t{maPelneHP}");
Console.WriteLine($"Ma klucz:\t\t\t{maKlucz}");
Console.WriteLine($"Ma mapę:\t\t\t{maMape}");
Console.WriteLine($"Ma miejsce w plecaku:\t\t{maMiejsce}");
Console.WriteLine($"Gotowy do wyprawy:\t\t{gotowyDoWyprawy}");
Console.WriteLine("+==========================================+");





