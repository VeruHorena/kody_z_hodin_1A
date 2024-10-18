namespace nah_cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random generator = new Random(); //vytvoreni objektu pro generovani cisel
int nahodne_cislo = generator.Next(); //bez rozsahu nahodne cele cislo v rozsahu int
            Console.WriteLine("Bez rozsahu nahodne cislo: " + nahodne_cislo);
            int nahodne2 = generator.Next(1, 11); //generovani cisla v rozsahu 1-10
            Console.WriteLine("Rozsah 1-10 nahodne cislo: " + nahodne2);
            double nahodneDes = generator.NextDouble(); // generovani des. cisla v rozsahu <0.0,1.0)
            Console.WriteLine("Desetinne nahodne cislo: " + nahodneDes);
        }
    }
}
