namespace RechnerGleitkommazahl
{
    class RechnerModel
    {
        public double Resultat { get; private set; }
        public string Operation { get; private set; }
        public RechnerModel()
        {
            Resultat = 0;
            Operation = "unbekannt";
        }
        public void Berechne(double ersteZahl, double zweiteZahl, string operation)
        {
            this.Operation = operation;

            switch (operation)
            {
                case "+":
                    Resultat = Addiere(ersteZahl, zweiteZahl);
                    break;
                case "-":
                    Resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    break;
                case "/":
                    Resultat = Dividieren(ersteZahl, zweiteZahl);
                    break;
                case "*":
                    Resultat = Multipizieren(ersteZahl, zweiteZahl);
                    break;
            }
        }


        private double Addiere(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;

            return summe;
        }

        private double Subtrahiere(double minuend, double subtrahent)
        {
            double differenz = minuend - subtrahent;

            return differenz;
        }
        private double Multipizieren(double multiplikator, double multiplikant)
        {
            double differenz = multiplikator * multiplikant;

            return differenz;
        }
        private double Dividieren(double divident, double divisor)
        {
            double differenz = divident / divisor;

            return differenz;
        }
    }
}
