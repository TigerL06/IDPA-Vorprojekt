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
        public Berechnung(FinanzDaten daten) 
        { 
            datenObjekt = daten;
            gewinn = datenObjekt.jahresgewinn;
            aktie = datenObjekt.aktien;
            partizipal = datenObjekt.partizipialkapital;
            reserven = datenObjekt.gesetzlicheReserven;
            vortrag = datenObjekt.vortrag;
            dividenden = datenObjekt.dividende;
        }

        public int BeitragReserven() 
        {
            int beitrag = -1;
            if (reserven == (aktie/2)) 
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

    }
}
