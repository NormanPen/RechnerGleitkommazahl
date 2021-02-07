using System;


namespace RechnerGleitkommazahl
{
    class ConsoleView
    {
        private RechnerModel model;

        public ConsoleView(RechnerModel model)
        {
            this.model = model;
        }

        public double HoleZahlVonBenutzer()
        {
            string zahl;
            Console.Write("Bitte gib eine Zahl für die Berechnung ein: ");
            zahl = Console.ReadLine();

            return Convert.ToDouble(zahl);
        }

        public string HoleOperatorVonBenutzer()
        {
            Console.Write("Bitte gib die auszuführende Operation ein (+, -, /, *):");
            return Console.ReadLine();
        }

        public void WarteAufEndeDurchBenutzer()
        {
            Console.Write("Zum beenden bitte Return drücken!");
            Console.ReadLine();
        }

        public void GibResultatAus()
        { 
            switch (model.Operation)
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
