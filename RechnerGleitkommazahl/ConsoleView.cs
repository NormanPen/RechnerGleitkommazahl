using System;
using System.Collections.Generic;
using System.Text;

namespace RechnerGleitkommazahl
{
    class ConsoleView
    {
        private RechnerModel model;

        public ConsoleView(RechnerModel model)
        {
            this.model = model;
        }
        public string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            return Console.ReadLine();
        }
        public void GibResultatAus(string operation)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine("Die Summe ist: {0}", model.Resultat);
                    break;
                case "-":
                    Console.WriteLine("Die Summe ist: {0}", model.Resultat);
                    break;
                case "/":
                    Console.WriteLine("Die Summe ist: {0}", model.Resultat);
                    break;
                case "*":
                    Console.WriteLine("Die Summe ist: {0}", model.Resultat);
                    break;
                default:
                    Console.WriteLine("Du hast eine ungültige Auswahl gestroffen.");
                    break;
            }
        }

    }
}
