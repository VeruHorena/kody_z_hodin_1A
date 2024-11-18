namespace cyklus_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocet = 0;
            int pruchod = 0; //promenna pro pocitani aktualniho pruchodu cyklem
            bool ok = false;

            do {
                Console.WriteLine("Zadej hodnotu: ");
            //  ok =   int.TryParse(Console.ReadLine(), out pocet);
            } while (!int.TryParse(Console.ReadLine(), out pocet));

            while (pruchod < pocet)
            {
                pruchod++; // pruchod = pruchod +1; pruchod--; pruchod +=5
                Console.WriteLine("Aktualni pruchod je: " + pruchod);
               
            }

          
        }
    }
}
