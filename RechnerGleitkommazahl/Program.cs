using System;

namespace RechnerGleitkommazahl
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.
            Console.WriteLine("Bitte gib den ersten Summanden ein: ");
            string ersterSummand = Console.ReadLine();
            Console.WriteLine("Bitte gib einen zweiten Summanden ein: ");
            string zweiterSummand = Console.ReadLine();

            // Wandel Text in Gleitkommazahl
            double ersterSummandAlsZahl = Convert.ToSingle(ersterSummand);
            double zweiterSummandAlsZahl = Convert.ToSingle(zweiterSummand);

            //Berechnung ausführen
            double summe = Addiere(ersterSummandAlsZahl, zweiterSummandAlsZahl);

            // Ausgabe
            Console.WriteLine("Die Summe ist: {0}", summe);
            WarteAufBenutzerEingabe();

          
        }

        static double Addiere(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;

            return summe;
        }

        static void WarteAufBenutzerEingabe()
        {
            Console.Write("Zum beenden bitte Return drücken!");
            Console.ReadLine();
        }
    }
}
