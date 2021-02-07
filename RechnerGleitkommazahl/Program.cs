using System;

namespace RechnerGleitkommazahl
{
    class Program
    {
        
        static void Main(string[] args)
        {
            RechnerModel model = new RechnerModel();
            ConsoleView view = new ConsoleView(model);
            string ersterSummand = view.HoleZahlVonBenutzer();
            string operation = view.HoleOperatorVonBenutzer();
            string zweiterSummand = view.HoleZahlVonBenutzer();
            // Wandel Text in Gleitkommazahl
            double ersteZahl = Convert.ToDouble(ersterSummand);
            double zweiteZahl = Convert.ToDouble(zweiterSummand);

            //Berechnung ausführen

            model.Berechne(ersteZahl, zweiteZahl, operation);


            // Ausgabe
          
            view.GibResultatAus(operation);
            view.WarteAufEndeDurchBenutzer();



        }


        


    }
}
