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
                Console.WriteLine("Bitte geben Sie ihren Jahresgewinn ein. Bitte geben Sie nur Zahlen ein.");
                Console.Write("Gewinn: ");
                text = Console.ReadLine();
                test = TestInt(text);
                if (test == false)
                {
                    Console.WriteLine("Was sie eingegebn haben war keine Zahl, bitte geben Sie eine Zahl ein.");
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
                Console.WriteLine("Bitte geben Sie ihr Aktienkapital ein. Bitte geben Sie nur Zahlen ein.");
                Console.Write("Aktien: ");
                text = Console.ReadLine();
                test = TestInt(text);
                if (test == false)
                {
                    Console.WriteLine("Was sie eingegebn haben war keine Zahl, bitte geben Sie eine Zahl ein.");
                    test = false;
                }
                else
                {
                    aktie = Convert.ToInt32(text);
                    test = true;
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
                Console.WriteLine("Bitte geben Sie ihr Partizipationskapital ein. Bitte geben Sie nur Zahlen ein.");
                Console.Write("Partizipationskapital: ");
                text = Console.ReadLine();
                test = TestInt(text);
                if (test == false)
                {
                    Console.WriteLine("Was sie eingegebn haben war keine Zahl, bitte geben Sie eine Zahl ein.");
                    test = false;
                }
                else
                {
                    kapital = Convert.ToInt32(text);
                    test = true;
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
                Console.WriteLine("Bitte geben Sie ihr gesetzliche Reserven ein. Bitte geben Sie nur Zahlen ein.");
                Console.Write("gesetzliche Reserven: ");
                text = Console.ReadLine();
                test = TestInt(text);
                if (test == false)
                {
                    Console.WriteLine("Was sie eingegebn haben war keine Zahl, bitte geben Sie eine Zahl ein.");
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
                Console.WriteLine("Bitte geben Sie ihre Gewinn- oder Verlustvortrag ein. Bei einem Gewinnvortrag können Sie die Zahl ganz normal eingeben. Bei einem Verlustvortrag setzen sie bitte Sie direkt vor die Zahl ein Minus (Bsp. -10). Bitte geben Sie nur Zahlen ein.");
                Console.Write("Vortrag: ");
                text = Console.ReadLine();
                test = TestInt(text);
                if (test == false)
                {
                    Console.WriteLine("Was sie eingegebn haben war keine Zahl, bitte geben Sie eine Zahl ein.");
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
            do
            {
                Console.WriteLine("Bitte geben Sie die gewünschte Dividene ein, die Sie gerne haben wollen. Bitte geben Sie nur Zahlen ein.");
                Console.Write("gesetzliche Reserven: ");
                text = Console.ReadLine();
                test = TestInt(text);
                if (test == false)
                {
                    Console.WriteLine("Was sie eingegebn haben war keine Zahl, bitte geben Sie eine Zahl ein.");
                    test = false;
                }
                else
                {
                    divide = Convert.ToInt32(text);
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

        public void Ausgabe(Berechnung berechnung)
        {
            _berechnung = berechnung;
            if(gewinn < 0)
            {
                Console.WriteLine("Es liegt ein Verlust vor. Somit ist kein Beitrag fällig. Es ist nur ein Beitrag bei einem Verlust fällig");
            }
            else
            {
                int beitrag = _berechnung.BeitragReserven();
                if (beitrag == -1)
                {
                    Console.WriteLine("Die gesetzlichen Reserven sind ausreichend. Kein Beitrag fällig. Die Reserven sind so hoch wie die hälfte des Aktienkapitals und muss so mit nach Art. 672 Abs. 1 OR nicht weiter erhöht werden.");
                }
                else if (beitrag == 0)
                {
                    Console.WriteLine("Man muss keinen Beitrag einzahlen. Es gibt keinen Gewinn und man muss somit auch nichts einzahlen.");
                }
                else 
                {
                    Console.WriteLine($"Der Beitrag für dieses Jahr in die gesetzlichen Reserven muss " + beitrag + "hoch sein.");
                    Console.WriteLine("Das sind nämlich 5% von dem Gewinn und so viel müssen in die gesetzlichen Reserven eingezahlt werden.");
                }
            }
        }
    }
}
