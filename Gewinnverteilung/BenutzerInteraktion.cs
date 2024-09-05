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
        public BenutzerInteraktion() { }

        public int Gewinn()
        {
            int gewinn = 0;
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
            int aktie = 0;
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
            int kapital = 0;
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
            int reserve = -10;
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
            int vortrag = 0;
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
            int divide = 0;
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
    }
}
