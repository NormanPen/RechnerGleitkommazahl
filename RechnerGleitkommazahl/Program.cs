﻿using System;

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
            float ersterSummandAlsZahl = Convert.ToSingle(ersterSummand);
            float zweiterSummandAlsZahl = Convert.ToSingle(zweiterSummand);

            //Berechnung ausführen
            float summe = ersterSummandAlsZahl + zweiterSummandAlsZahl;

            // Ausgabe
            Console.WriteLine("Die Summe ist: {0}", summe);
        }
    }
}