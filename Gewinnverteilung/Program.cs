// Version: 1.0
using Gewinnverteilung;

bool wiederholung;
do
{
    BenutzerInteraktion interaktion = new BenutzerInteraktion();
    FinanzDaten daten = new FinanzDaten();

    int gewinn = interaktion.Gewinn();
    int aktie = interaktion.Aktie();
    int partizipal = interaktion.Partizipal();
    int reserve = interaktion.Reserven();
    int vortrag = interaktion.Vortrag();
    int dividen = interaktion.Dividende();

    daten.Daten(gewinn, aktie, partizipal, reserve, vortrag, dividen);

    Berechnung verteilung = new Berechnung(daten);

    interaktion.AusgabeReserven(verteilung);
    interaktion.AusgabeDividen(verteilung);
    interaktion.AusgabeVortrag(verteilung);
    wiederholung = interaktion.Wiederholung();

} while (wiederholung == true);
