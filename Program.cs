namespace Keresztrejtveny
{
    internal class Program
    {
        static void Main(string[] args) { }


        class KeresztrejtvenyRacs
        {
            private List<string> Adatsorok;
            private char[,] Racs;
            private int[,] Sorszamok;

            public int SorokDb { get; private set; }
            public int OszlopokDb { get; private set; }

            public KeresztrejtvenyRacs(string fajlNev)
            {

                SorokDb = Adatsorok.Count;
                OszlopokDb = Adatsorok[0].Length;

                Racs = new char[SorokDb, OszlopokDb];

                //BeolvasAdatsorok(fajlNev);
                //FeltoltRacs();
            }
        }
    }
}
            