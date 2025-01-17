namespace metodyPozdrav
{
    internal class Program
    {
        public static void Pozdrav(String jmenoUzivatele, int pocetPrihlaseni = 1)
        {
            int prihlaseni = Soucet(pocetPrihlaseni, 1);
            Console.WriteLine("Ahoj uzivateli " + jmenoUzivatele + "! jsi tu po: " + prihlaseni);

        }

        public static int Soucet (int a, int b)
        {
            Console.WriteLine("Jsem v metode soucet.");
            int soucet = a + b;
            return soucet;
        }

        public static int[] vratLiche(int[] poleCisel)
        {
            int[] vysledek = new int[poleCisel.Length];
            int pozice = 0;
            for (int i = 0; i < poleCisel.Length; i++)
            {
                if (poleCisel[i] % 2 != 0)
                {
                    vysledek[pozice] = poleCisel[i];
                    pozice++;
                }
            }
            return vysledek;
        }



        static void Main(string[] args)
        {
            string uzivatel = "PepaVyskoc";
            Pozdrav(uzivatel,6);
           int v =  Soucet(5, 3);
            Console.WriteLine("Vysledek souctu je: " + v);
            Console.WriteLine("Vysledek souctu 1 + 1 je: " + Soucet(1,1));

            int[] zadani = new int[10];
            Random generator = new Random();
            for(int i = 0;i < zadani.Length; i++)
            {
                zadani[i] = generator.Next(1,11);
            }

            int[] lichaCisla = vratLiche(zadani);
            foreach(int i in lichaCisla)
            {
                if(i != 0)
                Console.Write(i + ", ");
            }
        }
    }
}
