namespace Keresztrejtveny
{
    internal class Program
    {
        static void Main(string[] args) {

            KeresztrejtvenyRacs racs = new KeresztrejtvenyRacs("kr1.txt");

            
            Console.WriteLine("5. feladat");
            Console.WriteLine($"Sorok száma: {racs.SorokDb}");
            Console.WriteLine($"Oszlopok száma: {racs.OszlopokDb}");


            Console.WriteLine("6. feladat");
            racs.Megjelenit();

            Console.WriteLine("7. feladat");
            int hossz = racs.LeghosszabbFuggolegesSzo();
            Console.WriteLine($"A leghosszabb függőleges szó hossza: {hossz}");

        }



    }
}