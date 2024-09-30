using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Zadej prvni cislo: ");
        int a = int.Parse(Console.ReadLine()); // nacteni prvni hodnoty
        /*viceradkovy komentar */
        Console.WriteLine("Zadej druhe cislo: ");
        int b = int.Parse(Console.ReadLine());
        int vysledek = a + b;
        Console.WriteLine("Soucet cisel je: " + vysledek);
        vysledek = a - b; //prepisu obsah promenne novou hodnotou
        Console.WriteLine("Rozdil cisel je: " + vysledek);
        vysledek = a * b;
        Console.WriteLine("Soucin cisel je: " + vysledek);
        float vysledek2;
        vysledek2 = (float)a / b;
        Console.WriteLine("Podil cisel je: " + vysledek2);
    }
}