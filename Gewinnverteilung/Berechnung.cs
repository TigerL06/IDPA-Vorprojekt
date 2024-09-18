using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Gewinnverteilung
{
    public class Berechnung
    {
        FinanzDaten datenObjekt;
        int gewinn;
        int aktie;
        int partizipal;
        int reserven;
        int vortrag;
        int dividenden;
        double beitragDividen;

        double aktienAnteil;
        double partizAnteil;
        double gesamtkapital;
        public Berechnung(FinanzDaten daten) 
        { 
            datenObjekt = daten;
            gewinn = datenObjekt.jahresgewinn;
            aktie = datenObjekt.aktien;
            partizipal = datenObjekt.partizipialkapital;
            reserven = datenObjekt.gesetzlicheReserven;
            vortrag = datenObjekt.vortrag;
            dividenden = datenObjekt.dividende;
            gesamtkapital = partizipal + aktie;
            aktienAnteil = Convert.ToDouble(aktie) / (gesamtkapital);
            partizAnteil = Convert.ToDouble(partizipal) / (gesamtkapital);
        }

        public int BeitragReserven() 
        {
            int beitrag = -1;
            if (reserven <= (gesamtkapital * 0.2))
            {
                if (gewinn > 0)
                {
                    beitrag = (int)(gewinn * 0.05);
                }else if (gewinn == 0)
                {
                    beitrag = 0;
                }
            }

            return beitrag; 
        }

        public double BeitragDividende()
        {
            double prozent = Convert.ToDouble(dividenden) / 100;
            beitragDividen = gewinn * prozent;
            return beitragDividen;
        }

        public double BeitragAktie()
        {
            double beitragAktie = beitragDividen * aktienAnteil;
            return beitragAktie;
        }

        public double BeitragPati()
        {
            double beitragPartizipal = beitragDividen * partizAnteil;
            return beitragPartizipal;
        }

        public int VortragPos()
        {
            int vortragPo = gewinn - Convert.ToInt32(beitragDividen) + vortrag;
            return vortragPo;
        }



    }
}
