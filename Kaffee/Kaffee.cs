namespace Kaffee
{
    public class Kaffee
    {
        private static double maxWasser = 2.5;
        private static double maxBohnen = 2.5;

        public double wasser { get; private set; }
        public double bohnen { get; private set; }
        public double gesamtMengeKaffeeProduziert { get; private set; }

        public Kaffee()
        {
            wasser = 0;
            bohnen = 0;
            gesamtMengeKaffeeProduziert = 0;
        }

        public double wasserAuffuellen(double menge)
        {
            double retval = 0;
            retval = wasser + menge;

            if (retval > maxWasser)
                return 2.5;
            else
                return retval;
        }
        public double bohnenAuffuellen(double menge)
        {
            double retval = 0;
            retval = bohnen + menge;

            if ( retval > maxBohnen)
                return 2.5;
            else
                return retval;
        }
        public double machKaffee(double menge, double verhaeltnisWasserBohnen)
        {
            var multiplikator = (verhaeltnisWasserBohnen < 1) ? verhaeltnisWasserBohnen : 1 / verhaeltnisWasserBohnen;

            var mengeWasser = (menge / 2) * multiplikator;

            var mengeBohnen = menge / 2 * (2 - multiplikator);

            if (wasser < mengeWasser)
                return -1.0;
            if (bohnen < mengeBohnen)
                return -2.0;
            else

            wasser -= mengeWasser;
            bohnen -= mengeBohnen; 

            return menge;
        }



    }
}