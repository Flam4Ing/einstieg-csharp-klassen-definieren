using System;


namespace KlassenDefinieren
{
    class Program
    {
        // Übung:
        //  - aktuelle Geschwindigkeit soll ausgegeben vor und nach der Beschleunigung

        static void Main(string[] args)
        {
            Auto meinAuto = new Auto();
            Auto deinAuto = new Auto();

            meinAuto.alterInJahren = 13;
            meinAuto.marke = "Audi";

            deinAuto.alterInJahren = 1;
            deinAuto.marke = "Porsche";

            meinAuto.BeschleunigeAuf100KmH();
            deinAuto.BeschleunigeAuf100KmH();
        }
    }
}
