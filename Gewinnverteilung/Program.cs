using Gewinnverteilung;

BenutzerInteraktion interaktion = new BenutzerInteraktion();
FinanzDaten daten = new FinanzDaten();

int gewinn = interaktion.Gewinn();
int aktie = interaktion.Aktie();
int partizipal= interaktion.Partizipal();
int reserve = interaktion.Reserven();
int vortrag = interaktion.Vortrag();
int dividen = interaktion.Dividende();

daten.Daten(gewinn, aktie, partizipal, reserve, vortrag, dividen);

Berechnung verteilung = new Berechnung();
