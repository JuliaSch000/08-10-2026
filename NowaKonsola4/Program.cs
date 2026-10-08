Console.WriteLine("Podaj punkty życia (max: 100):");
int HP = int.Parse(Console.ReadLine()!);
Console.WriteLine("Podaj liczbę mikstur:");
int mixInt = int.Parse(Console.ReadLine()!);
Console.WriteLine("Czy masz klucz?");
bool kluczBool = bool.Parse(Console.ReadLine()!);
Console.WriteLine("Czy masz mapę?");
bool mapaBool = bool.Parse(Console.ReadLine()!);

bool zyje = HP > 0;
bool maPelneZdrowie = HP == 100;
bool leczenie = HP < 100;
bool maZaopatrzenie = mixInt > 0;
bool maNawigacje = kluczBool || mapaBool;
bool gotowyDoWyprawy = zyje && maZaopatrzenie && maNawigacje;

Console.WriteLine($"Żyje:\t{zyje}");
Console.WriteLine($"Ma pełne zdrowie:\t{maPelneZdrowie}");
Console.WriteLine($"Wymaga leczenia:\t{leczenie}");
Console.WriteLine($"Ma zaopatrzenie:\t{maZaopatrzenie}");
Console.WriteLine($"Ma klucz lub mapę:\t{maNawigacje}");
Console.WriteLine($"Gotowy do wyprawy:\t{gotowyDoWyprawy}");



