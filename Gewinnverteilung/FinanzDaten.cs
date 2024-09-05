using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gewinnverteilung
{
    public class FinanzDaten
    {
        int jahresgewinn;
        int aktien;
        int partizipialkapital;
        int gesetzlicheReserven;
        int vortrag;
        int dividende;
        public FinanzDaten() { }

        public void Daten(int gewinn, int aktie, int parti, int gesetz, int vort, int div)
        {
            jahresgewinn = gewinn;
            aktien = aktie;
            partizipialkapital = parti;
            gesetzlicheReserven = gesetz;
            vortrag = vort;
            dividende = div;
        }

    }
}
