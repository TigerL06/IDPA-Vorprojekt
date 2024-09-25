//Version: 1.0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gewinnverteilung
{
    public class FinanzDaten
    {
        public int jahresgewinn;
        public int aktien;
        public int partizipialkapital;
        public int gesetzlicheReserven;
        public int vortrag;
        public int dividende;
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
