int racjeZyw = 395;
int czlonDruz = 7;
int dniWyprawy = 8;


int racjeReszta = racjeZyw % dniWyprawy;

double racjeZywD = (double)racjeZyw;
double czlonDruzD = (double)czlonDruz;
double dniWyprawyD = (double)dniWyprawy;

double racjeDzienAll = racjeZywD / dniWyprawyD;
double racjeDzienOsobno = racjeDzienAll / czlonDruzD;
double racjeSredniaDzien = racjeDzienOsobno / dniWyprawyD;

Console.WriteLine($"Drużyna otrzymała {racjeDzienAll} racji dziennie.");
Console.WriteLine($"Zostało {racjeReszta} racji po równym rozdaniu.");
Console.WriteLine($"Każdy dostanie po {racjeDzienOsobno:F2} racji.");
Console.WriteLine($"Średnio każdy dostaje {racjeSredniaDzien:F2} racji na 1 dzień.");
