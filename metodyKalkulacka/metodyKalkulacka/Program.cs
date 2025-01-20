namespace metodyKalkulacka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vitejte v programu kalkulacka!");
            int volbaUzivatele;
            int[] hodnoty;
            int vysledek;
            do
            {
                volbaUzivatele = Menu();
                switch (volbaUzivatele) {
                    case 1:
                       hodnoty = nacteniHodnot(2);
                         vysledek = soucet(hodnoty[0], hodnoty[1]);
                        Console.WriteLine($"Soucet cisel {hodnoty[0]} a {hodnoty[1]} je {vysledek}");
                        break;
                    case 2:
                        hodnoty = nacteniHodnot(2);
                        vysledek = rozdil(hodnoty[0], hodnoty[1]);
                        Console.WriteLine($"Rozdil cisel {hodnoty[0]} a {hodnoty[1]} je {vysledek}"); break;
                    case 3:
                        hodnoty = nacteniHodnot(2);
                        vysledek = soucin(hodnoty[0], hodnoty[1]);
                        Console.WriteLine($"Soucin cisel {hodnoty[0]} a {hodnoty[1]} je {vysledek}");
                        break;
                    case 4:
                        hodnoty = nacteniHodnot(2);
                        double vysledek2 = podil(hodnoty[0], hodnoty[1]);
                        Console.WriteLine($"Podil cisel {hodnoty[0]} a {hodnoty[1]} je {vysledek2}");
                        break;
                }

            } while (volbaUzivatele != 5);
            Console.WriteLine("Dekujeme za pouziti kalkulacky!");
        }

        public static int[] nacteniHodnot(int pocetHodnot)
        {
            int[] hodnoty = new int[pocetHodnot];
            for (int i = 0; i < hodnoty.Length; i++)
            {
                do {
                    Console.WriteLine($"Zadej {i + 1}. hodnotu");
                } while(!int.TryParse(Console.ReadLine(), out hodnoty[i]));
            }
            return hodnoty;
        } 
        public static int soucet(int a, int b)
        {
            return a + b;
        }
        public static int rozdil(int a, int b)
        {
            return a - b;
        }
        public static int soucin(int a, int b)
        {
            return a * b;
        }
        public static double podil(int a, int b)
        {
            if (b != 0)
                return (double)a / b;
            else
                return 0;
        }
        public static int Menu() {
            int volba;
            do {
                Console.WriteLine("1: Soucet");
                Console.WriteLine("2: Rozdil");
                Console.WriteLine("3: Soucin");
                Console.WriteLine("4: Podil");
                Console.WriteLine("5: Konec");
            }while(!int.TryParse(Console.ReadLine(), out volba) || volba<1 || volba>5) ;
            return volba;
        }
    }
}
