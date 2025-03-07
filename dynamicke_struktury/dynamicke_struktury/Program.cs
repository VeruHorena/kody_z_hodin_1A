namespace dynamicke_struktury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> studenti = new List<String>(); // vytvoření nového seznamu pro řetězce
            while (true)
            {
                int volba = vypisMenu(); //nacte hodnotu od uzivatele z menu
                switch (volba)
                {
                    case 1:
                        Console.WriteLine("Zadej jmeno:");
                        string zadane = Console.ReadLine();
                        studenti.Add(zadane);
                        Console.WriteLine("Student pridan.");
                        break;
                    case 2:
                        Console.WriteLine("Zadej jmeno pro vyhledani:");
                        string hledane = Console.ReadLine();
                        if (vyhledej(hledane, studenti) != "")
                            Console.WriteLine("Nalezen student " + hledane);
                        else
                            Console.WriteLine("Student nenalezen.");
                        
                        break;
                    case 3:
                        Console.WriteLine("Zadej jmeno studenta pro odstraneni: ");
                        string jmeno = Console.ReadLine();
                        studenti.Remove(jmeno);
                        Console.WriteLine("Student odebran.");
                        break;
                    case 4:
                        Console.WriteLine("Aktualne zapsanych studentu: " + studenti.Count);
                        foreach (String s in studenti)
                            Console.WriteLine(s);

                        break;
                    default: break;
                }
                if (volba == 5)
                    break;
            }


        }

        public static int vypisMenu()
        {
            int volba;
            Console.WriteLine("1. Přidání studenta");
            Console.WriteLine("2. Vyhledání studenta");
            Console.WriteLine("3. Odebrání studenta");
            Console.WriteLine("4. Vypis studentu");
            Console.WriteLine("5. Konec programu");
            do
            {
                Console.WriteLine("Zadej svou volbu:");
            }
            while (!int.TryParse(Console.ReadLine(), out volba) || volba < 1 || volba > 5);
                              return volba;
     
        }

        public static string vyhledej (string jmeno, List<string> studenti)
        {//prozatim nemame co vracet, vratime si alespon jmeno
            string nalezeno = "";
            foreach (String s in studenti)
            {
                if (s == jmeno)
                    nalezeno = jmeno;
            }
            return nalezeno;
        }
    }
}
