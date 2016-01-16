using System;

namespace KlassenDefinieren
{
    public class Auto
    {
        public string marke;
        public int alterInJahren;
        private int aktuelleGeschwindigkeit;

        public void BeschleunigeAuf100KmH()
        {
            aktuelleGeschwindigkeit = 100;

            if (IstSchnell())
            {
                Console.WriteLine("Habe schnell beschleunigt! Yeah!");
            }
            else
            {
                Console.WriteLine("Habe normal beschleunigt!");
            }
        }

        public int SagAktuelleGeschwindigkeit()
        {
            return aktuelleGeschwindigkeit;
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
