using System;


namespace RechnerGleitkommazahl
{
    class AnwendungsController
    {
        private ConsoleView view;
        private RechnerModel model;

        public AnwendungsController(ConsoleView view, RechnerModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void Ausführen()
        {
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
