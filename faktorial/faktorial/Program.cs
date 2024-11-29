namespace faktorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo;
            do {
                Console.WriteLine("Zadej hodnotu pro vypocet:  ");
            }
            while (int.TryParse(Console.ReadLine(), out cislo) == false || cislo <=0);

            ulong faktorial = 1;

            for (int i = 1; i <= cislo; i++)
            {
                faktorial = faktorial * (ulong)i;
            }
            if (faktorial > 0)
                Console.WriteLine("Vysledek je: " + faktorial);
            else
                Console.WriteLine("Pretekla kapacita");
        }
    }
}
