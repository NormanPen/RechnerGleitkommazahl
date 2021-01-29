using System;

namespace RechnerGleitkommazahl
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.
            string ersterSummand = HoleBenutzerEingabe("Bitte gib die erste Zahl ein: ");
            string zweiterSummand = HoleBenutzerEingabe("Bitte gib eine Zahl ein: ");
            string operation = HoleBenutzerEingabe("Bitte gib die asuzuführende Operation ein (+, -, /,oder *): ");

            // Wandel Text in Gleitkommazahl
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double ersteZahl = Convert.ToDouble(ersterSummand);
            double zweiteZahl = Convert.ToDouble(zweiterSummand);

            //Berechnung ausführen
            RechnerModel model = new RechnerModel();
            model.Berechne(ersteZahl, zweiteZahl, operation);


            // Ausgabe
            GibResultatAus(model.Resultat, operation);
            HoleBenutzerEingabe("Zum beenden bitte Return drücken!");


        }

        static void GibResultatAus(double resultat, string operation)
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
        static string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string summand = Console.ReadLine();

            return summand;
        }
        


    }
}
