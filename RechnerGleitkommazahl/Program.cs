using System;

namespace RechnerGleitkommazahl
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ConsoleView view = new ConsoleView();
            string ersterSummand = view.HoleBenutzerEingabe("Bitte gib die erste Zahl ein: ");
            string zweiterSummand = view.HoleBenutzerEingabe("Bitte gib eine Zahl ein: ");
            string operation = view.HoleBenutzerEingabe("Bitte gib die asuzuführende Operation ein (+, -, /,oder *): ");

            // Wandel Text in Gleitkommazahl
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double ersteZahl = Convert.ToDouble(ersterSummand);
            double zweiteZahl = Convert.ToDouble(zweiterSummand);

            //Berechnung ausführen
            RechnerModel model = new RechnerModel();
            model.Berechne(ersteZahl, zweiteZahl, operation);


            // Ausgabe
          
            view.GibResultatAus(model.Resultat, operation);
            view.HoleBenutzerEingabe("Zum beenden bitte Return drücken!");
            


        }


        


    }
}
