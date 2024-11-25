namespace kresleni_tvary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kresleni obdelnik
            Console.Write("Zadejte vysku obdelniku: ");
            int vyska = int.Parse(Console.ReadLine());

            Console.Write("Zadejte sirku obdelniku:  ");
            int sirka = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // Vykresleni
            for (int i = 0; i < vyska; i++) // radky
            {
                for (int j = 0; j < sirka; j++) // sloupce
                {
                    Console.Write("*");
                }
                Console.WriteLine(); //novy radek
            }

            //rovnoramenny trojuhelnik
            Console.Write("Zadejte výšku trojúhelníku: ");
            int vyskatrojuhelnik = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // Vykreslení trojúhelníku
            for (int i = 0; i < vyska; i++) // Procházíme řádky
            {
                // Vykreslení mezer před hvězdičkami
                for (int j = 0; j < vyska - i - 1; j++)
                {
                    Console.Write(" ");
                }

                // Vykreslení hvězdiček
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); // Přechod na nový řádek
            }


            //trojuhelnik typu p
            Console.Write("Zadejte délku strany pro trojuhelnik: ");
            int delka = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = delka; i > 0; i--) // start na nejsirsim radku
            {
                for (int j = 0; j < i; j++) //vykreslime hvezdicky odpovidajici sirce radku
                {
                    Console.Write("*");
                }
                Console.WriteLine(); // novy radek
            }
        }
    }
}
