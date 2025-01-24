using System.Security.Cryptography.X509Certificates;

namespace metodyKalkulacka
{
    internal class Program
    {
        public static string[] historie = new string[10];
        public static int pozice = 0;
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
                        Console.WriteLine($"Rozdil cisel {hodnoty[0]} a {hodnoty[1]} je {vysledek}"); 
                        break;
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
                    case 5:
                        hodnoty = nacteniHodnot(2);
                        long vysledek3 = mocnina(hodnoty[0], hodnoty[1]);
                        Console.WriteLine($"Mocnina cisla {hodnoty[0]} na {hodnoty[1]} je {vysledek3}");
                        break;
                    case 6:
                        hodnoty = nacteniHodnot(1);
                        long vysledek4 = faktorial(hodnoty[0]);
                        Console.WriteLine($"Faktorial cisla {hodnoty[0]} je {vysledek4}");
                        break;
                        case 7:
                        vypisHistorii();
                        break;

                }

            } while (volbaUzivatele != 8);
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
        //metody pocetnich operaci
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

        public static long mocnina(int a, int mocnitel)
        {
            long vysledek = 1;
            for (int i = 0; i < mocnitel; i++)
            {
                vysledek = vysledek * a;
            }

            return vysledek;
        }

        public static long faktorial (int a)
        {
            long vysledek = 1;
            for(int i = 1; i <= a; i++)
            {
                vysledek *= i;
            }
            return vysledek;
        }

        public static int Menu() {
            int volba;
            do {
                Console.WriteLine("1: Soucet");
                Console.WriteLine("2: Rozdil");
                Console.WriteLine("3: Soucin");
                Console.WriteLine("4: Podil");
                Console.WriteLine("5: Mocnina");
                Console.WriteLine("6: Faktorial");
                Console.WriteLine("7: Historie");
                Console.WriteLine("8: Konec");
            }while(!int.TryParse(Console.ReadLine(), out volba) || volba<1 || volba>8) ;
            //zapis do historie prikazu
            if (pozice < 10)
            {
                switch (volba)
                {
                    case 1:
                        historie[pozice] = "soucet";
                        break;
                    case 2:
                        historie[pozice] = "rozdil";
                        break;
                    case 3:
                        historie[pozice] = "soucin";
                        break;
                    case 4:
                        historie[pozice] = "podil";
                        break;
                    case 5:
                        historie[pozice] = "mocnina";
                        break;
                    case 6:
                        historie[pozice] = "faktorial";
                        break;
                    case 7:
                        historie[pozice] = "historie";
                        break;
                }
                pozice++;
            }
            return volba;
        }

        public static void vypisHistorii()
        {
            for(int i = 0; i < historie.Length; i++)
            {
                if (historie[i]!="")
                Console.WriteLine(historie[i]);
            }

        }
    }
}
