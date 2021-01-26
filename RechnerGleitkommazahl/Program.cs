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
            string operation = HoleBenutzerEingabe("Bitte gib die asuzuführende Operation ein (+ oder -): ");

            // Wandel Text in Gleitkommazahl
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double ersteZahl = Convert.ToDouble(ersterSummand);
            double zweiteZahl = Convert.ToDouble(zweiterSummand);

            //Berechnung ausführen
            double resultat = 0;
            switch (operation)
            {
                case "+":
                    resultat = Addiere(ersteZahl, zweiteZahl);
                    Console.WriteLine("Die Summe ist: {0}", resultat);
                    break;
                case "-":
                    resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    Console.WriteLine("Die Differenz ist: {0}", resultat);
                    break;
                case "/":
                    resultat = Dividieren(ersteZahl, zweiteZahl);
                    Console.WriteLine("Die Summe ist: {0}", resultat);
                    break;
                case "*":
                    resultat = Multipizieren(ersteZahl, zweiteZahl);
                    Console.WriteLine("Die Summe ist: {0}", resultat);
                    break;
                default:
                    Console.WriteLine("Du hast eine ungültige Auswahl getroffen");
                    break;
            }


            // Ausgabe
            HoleBenutzerEingabe("Zum beenden bitte Return drücken!");

          
        }
        static string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string summand = Console.ReadLine();

            return summand;
        }

        static double Addiere(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;

            return summe;
        }

        static double Subtrahiere(double minuend, double subtrahent)
        {
            double differenz = minuend - subtrahent;

            return differenz;
        }
        static double Multipizieren(double minuend, double subtrahent)
        {
            double differenz = minuend * subtrahent;

            return differenz;
        }
        static double Dividieren(double minuend, double subtrahent)
        {
            double differenz = minuend / subtrahent;

            return differenz;
        }


    }
}
