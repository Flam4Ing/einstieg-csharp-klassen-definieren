using System;

namespace KlassenDefinieren
{
    public class Auto
    {
        public string marke;
        public int alterInJahren;

        public void BeschleunigeAuf100KmH()
        {
            if (IstSchnell())
            {
                Console.WriteLine("Habe schnell beschleunigt! Yeah!");
            }
            else
            {
                Console.WriteLine("Habe normal beschleunigt!");
            }
        }

        private bool IstSchnell()
        {
            if (marke == "Porsche")
            {
                return true;
            }

            return false;
        }
    }
}
