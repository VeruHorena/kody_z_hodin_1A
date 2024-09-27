namespace PrvniProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Ahoj uzivateli");
            int a;
            a = 18;
            Console.WriteLine("Prirazena hodnota a je "+a);
            */
            // Console.ReadKey(); //pomoci toho se mi nezavre konzole a ceka na stisknuti libovolneho znaku



            /*Console.WriteLine("Ahoj uzivateli, jsem papousek Lora");
            Console.Write("Zadej mi text k opakovani: ");
            string text;
            text = Console.ReadLine();
            Console.WriteLine(text + " " + text);
            Console.ReadKey();
        */

            Console.WriteLine("Zadej hodnotu k vynasobeni: ");
            int cislo; //deklarace
           
            cislo = int.Parse(Console.ReadLine());
            int vysledek = cislo * 2; //definice
            Console.WriteLine("Vysledek je: " + vysledek);
        }
    }
}
