using System;

namespace KlassenDefinieren
{
    // Übung:
    //  - aktuelle Geschwindigkeit speichern - DATEN!
    //  - BeschleunigeAuf100KmH erhöht die Geschwindigkeit -> VERHALTEN!
    //  - aktuelle Geschwindigkeit kann ausgegeben werden -> VERHALTEN!

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
