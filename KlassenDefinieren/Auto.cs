using System;

namespace KlassenDefinieren
{
    public class Auto                        // eigene Klasse, Zugriffsmodifizierer: public, Klasse beginnt mit Großbuschstaben
    {
        private int aktuelleGeschwindigkeit;     

        public Auto(string autoMarke)
        {
            Marke = autoMarke;
            AlterInJahren = 0;
            aktuelleGeschwindigkeit = 0;
        }

        private string marke;   //Attribut

        public string Marke      //Eigenschaft = Property
        {
            get { return marke; }
            set
            {
                if (value == "Porsche")
                {
                    marke = value;
                }
                else
                {
                    marke = "Nicht unterstützt!";
                }
            }
        }
            
        public int AlterInJahren { get; set; }

        public void BeschleunigeAuf100KmH()       // Methoden
        {
            aktuelleGeschwindigkeit = 100;

            if (IstSchnell())
            {
                Console.WriteLine("Der {0} hat schnell beschleunigt! Yeah!", Marke);
            }
            else
            {
                Console.WriteLine("Der {0} hat normal beschleunigt!", Marke);
            }
        }

        public int SagAktuelleGeschwindigkeit()
        {
            return aktuelleGeschwindigkeit;
        }

        private bool IstSchnell()
        {
            if (Marke == "Porsche")
            {
                return true;
            }

            return false;
        }
    }

    public class AUTO
    {

        public void Bremsen()
        {
            throw new System.NotImplementedException();
        }
    }
}
