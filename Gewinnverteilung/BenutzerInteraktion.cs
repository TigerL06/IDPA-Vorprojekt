using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Gewinnverteilung
{
    public class BenutzerInteraktion
    {
        int divide = 0;
        int gewinn = 0;
        int aktie = 0;
        int kapital = 0;
        int reserve = -10;
        int vortrag = 0;
        Berechnung _berechnung;
        public BenutzerInteraktion() { }

        public int Gewinn()
        {
            string text;
            bool test = true;
            do
            {
                Console.WriteLine("Bitte geben Sie ihren Jahresgewinn in Franken ein. Bitte geben Sie nur Zahlen ein.");
                Console.Write("Gewinn: ");
                text = Console.ReadLine();
                test = TestInt(text);
                if (test == false)
                {
                    Console.WriteLine("Was sie eingegeben haben, war keine Zahl, bitte geben Sie eine Zahl ein.");
                    test = false;

                }
                else if (Convert.ToInt32(text) < 0){
                    Console.WriteLine("Geben Sie eine positive Zahl ein.");
                    test = false;
                }
                else
                {
                    gewinn = Convert.ToInt32(text);
                    test = true;
                }
            } while (test == false);
            return gewinn;
        }

        public int Aktie()
        {
            string text;
            bool test = true;
            do
            {
                Console.WriteLine("Bitte geben Sie ihr Aktienkapital in Franken ein. Bitte geben Sie nur Zahlen ein.");
                Console.Write("Aktien: ");
                text = Console.ReadLine();
                test = TestInt(text);
                if (test == false)
                {
                    Console.WriteLine("Was sie eingegebn haben, war keine Zahl, bitte geben Sie eine Zahl ein.");
                    test = false;
                }
                else
                {
                    aktie = Convert.ToInt32(text);
                    test = true;
                }

                if (Convert.ToInt32(text) < 0)
                {
                    Console.WriteLine("Das Aktienkapital kann nicht im Minus sein. Geben Sie das Aktienkapital erneut ein.");
                    test = false;
                }
            } while (test == false);
            return aktie;
        }

        public int Partizipal()
        {
            string text;
            bool test = true;
            do
            {
                Console.WriteLine("Bitte geben Sie ihr Partizipationskapital in Franken ein. Bitte geben Sie nur Zahlen ein.");
                Console.Write("Partizipationskapital: ");
                text = Console.ReadLine();
                test = TestInt(text);

                if (test == false)
                {
                    Console.WriteLine("Was sie eingegebn haben, war keine Zahl, bitte geben Sie eine Zahl ein.");
                    test = false;
                }
                else
                {
                    kapital = Convert.ToInt32(text);
                    test = true;
                }


                if (Convert.ToInt32(text) < 0)
                {
                    Console.WriteLine("Das Partizipationskapital kann nicht im Minus sein. Geben Sie das Partizipationskapital erneut ein.");
                    test = false;
                }
            } while (test == false);
            return kapital;
        }

        public int Reserven()
        {
            string text;
            bool test = true;
            do
            {
                Console.WriteLine("Bitte geben Sie ihr gesetzliche Reserven in Franken ein. Bitte geben Sie nur Zahlen ein.");
                Console.Write("gesetzliche Reserven: ");
                text = Console.ReadLine();

                if(Convert.ToInt32(text) < 0)
                {
                    Console.WriteLine("Die Reserven können nicht im Minus sein. Geben Sie die Reserven erneut ein.");
                    test = false;
                }

                test = TestInt(text);
                if (test == false)
                {
                    Console.WriteLine("Was sie eingegeben haben, war keine Zahl, bitte geben Sie eine Zahl ein.");
                    test = false;
                }
                else
                {
                    reserve = Convert.ToInt32(text);
                    test = true;
                }
            } while (test == false);
            return reserve;
        }

        public int Vortrag()
        {
            string text;
            bool test = true;
            do
            {
                Console.WriteLine("Bitte geben Sie ihre Gewinn- oder Verlustvortrag in Franken ein. Bei einem Gewinnvortrag können Sie die Zahl ganz normal eingeben. Bei einem Verlustvortrag setzen sie bitte Sie direkt vor die Zahl ein Minus (Bsp. -10). Bitte geben Sie nur Zahlen ein.");
                Console.Write("Vortrag: ");
                text = Console.ReadLine();
                test = TestInt(text);
                if (test == false)
                {
                    Console.WriteLine("Was sie eingegebn haben, war keine Zahl, bitte geben Sie eine Zahl ein.");
                    Console.WriteLine();

                    test = false;
                }
                else
                {
                    vortrag = Convert.ToInt32(text);
                    test = true;
                }
            } while (test == false);
            return vortrag;
        }

        public int Dividende()
        { 
            string text;
            bool test = true;
            int zahl = 10;
            bool testF = true;
            do
            {

                testF = true;
                Console.WriteLine("Bitte geben Sie die gewünschte Ausschüttung vom Gewinn in Prozenten ein, die Sie ausschütten wollen. Bitte geben Sie nur Zahlen ein (kein Prozentzeichen).");
                Console.WriteLine();

                Console.Write("Dividende: ");
                text = Console.ReadLine();
                test = TestInt(text);
                if(test == true)
                {
                    zahl = Convert.ToInt32(text);
                }
                
                if (zahl > 95 && test == true)
                {
                    Console.WriteLine("Sie können nicht mehr 95% des Gewinnes ausschütten, da Sie noch die gesetzlichen Reserven bezahlen müssen");
                    Console.WriteLine();

                    test = false;
                    testF = false;

                }else if(zahl < 0 && test == true)
                {
                    Console.WriteLine("Sie können nicht einen Minus Prozentsatz eingeben, da Sie entweder Dividende auszahlen oder nicht.");
                    Console.WriteLine();

                    test = false;
                    testF = false;
                }

                if (test == false && testF == true)
                {
                    Console.WriteLine("Was sie eingegebn haben, war keine Zahl, bitte geben Sie eine Zahl ein.");
                    Console.WriteLine();

                    test = false;
                }
                else if(test == true)
                {
                    divide = zahl;
                    test = true;
                }
            } while (test == false);
            return divide;
        }

        public bool TestInt(string text)
        {
            bool result = false;
            if (int.TryParse(text, out int zahl))
            {
                result = true;
            }
            return result;
        }

        public void AusgabeReserven(Berechnung berechnung)
        {
            _berechnung = berechnung;
            if(gewinn < 0)
            {
                Console.WriteLine("Es liegt ein Verlust vor. Somit ist kein Beitrag fällig. Es ist nur ein Beitrag bei einem Verlust fällig");
                Console.WriteLine();

            }
            else
            {
                int beitrag = _berechnung.BeitragReserven();
                if (beitrag == -1)
                {
                    Console.WriteLine("Die gesetzlichen Reserven sind ausreichend. Kein Beitrag fällig. Die Reserven sind so hoch wie die hälfte des Aktienkapitals und muss so mit nach Art. 672 Abs. 1 OR nicht weiter erhöht werden.");
                    Console.WriteLine();

                }
                else if (beitrag == 0)
                {
                    Console.WriteLine("Man muss keinen Beitrag einzahlen. Es gibt keinen Gewinn und man muss somit auch nichts einzahlen.");
                    Console.WriteLine();

                }
                else 
                {
                    Console.WriteLine($"Der Beitrag für dieses Jahr in die gesetzlichen Reserven muss " + beitrag + "CHF hoch sein.");
                    Console.WriteLine();
                    Console.WriteLine("Das sind 5% von dem Gewinn und so viel müssen in die gesetzlichen Reserven eingezahlt werden, nach Art. 672 OR.");
                }
            }

        }

        public void AusgabeDividen(Berechnung berechnung) 
        {
            double dividen = berechnung.BeitragDividende();
            double divAk = berechnung.BeitragAktie();
            double divPa = berechnung.BeitragPati();

            Console.WriteLine($"Gesamte Dividende-Ausschüttung: " + dividen +"CHF");
            Console.WriteLine();
            Console.WriteLine("Dieser Beitrag zeigt der gesamte Ausschüttung von den Dividende, die das Unternehmen auszahlen will, dieses Jahr, auf in Franken.");
            Console.WriteLine();
            Console.WriteLine($"Dieser Betrag ist, wie angegeben " + divide +"%");
            Console.WriteLine();
            Console.WriteLine($"Dividende-Ausschüttung gegenüber Aktionären: " + divAk + "CHF"); 
            Console.WriteLine();
            Console.WriteLine("Dieser Beitrag zeigt die Ausschüttung der Dividende gegenüber den Aktionären, die das Unternehmen auszahlen will, dieses Jahr, auf in Franken.");
            Console.WriteLine();
            Console.WriteLine($"Dividende-Ausschüttung gegenüber Partizipationsinhabern: " + divPa + "CHF");
            Console.WriteLine();
            Console.WriteLine("Dieser Beitrag zeigt die Ausschüttung der Dividende gegenüber den Partizipationsinhaber, die das Unternehmen auszahlen will, dieses Jahr, auf in Franken.");
            Console.WriteLine();
        }

        public void AusgabeVortrag(Berechnung berechnung)
        {
            int _vortrag;
            _vortrag = berechnung.VortragPos();

            Console.WriteLine($"Das ist der Vortrag für das nächste Jahr: " +_vortrag + "CHF");
            Console.WriteLine();
            if(_vortrag < 0)
            {
                Console.WriteLine("Das ist der Verlust, der das Unternehmen mit ins nächste Geschäftsjahr, nach allen Abzügen, nehmen muss.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Das ist der Gewinn, der das Unternehmen nach allen Abzügen ins nächste Jahr mitnimmt.");
                Console.WriteLine();
            }

        }

        public bool Wiederholung()
        {
            bool boolAntwort;
            do 
            {
                Console.WriteLine("Wollen Sie eine neue Berechnung starten? Antworten sie mit Ja(j) oder Nein(n)");
                string antwort = Console.ReadLine();

                if (antwort == "j")
                {
                    boolAntwort = true;
                }
                else if (antwort == "n")
                {
                    boolAntwort = false;
                }
                else
                {
                    Console.WriteLine("Geben Sie j(ja) oder (n) nein ein. Bitte keine anderen Eingaben");
                    boolAntwort = false;
                }
            }while( boolAntwort == false );

            return boolAntwort;
        }

    }
}
