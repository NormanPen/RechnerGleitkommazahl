using System;
using System.Collections.Generic;
using System.Text;

namespace RechnerGleitkommazahl
{
    class ConsoleView
    {
        public string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            return Console.ReadLine();
        }
        public void GibResultatAus(double resultat, string operation)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine("Die Summe ist: {0}", resultat);
                    break;
                case "-":
                    Console.WriteLine("Die Summe ist: {0}", resultat);
                    break;
                case "/":
                    Console.WriteLine("Die Summe ist: {0}", resultat);
                    break;
                case "*":
                    Console.WriteLine("Die Summe ist: {0}", resultat);
                    break;
                default:
                    Console.WriteLine("Du hast eine ungültige Auswahl gestroffen.");
                    break;
            }
        }

    }
}
