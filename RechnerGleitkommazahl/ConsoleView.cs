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
            Console.Write("Bitte gib eine Zahl für die Berechnung ein: ");
            return Console.ReadLine();
        }

        public string HoleOperatorVonBenutzer()
        {
            Console.Write("Bitte gib die auszuführende Operation ein (+, -, /, *):");
            return Console.ReadLine();
        }
        public string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            return Console.ReadLine();
        }

        public void WarteAufEndeDurchBenutzer()
        {
            Console.Write("Zum beenden bitte Return drücken!");
            Console.ReadLine();
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
