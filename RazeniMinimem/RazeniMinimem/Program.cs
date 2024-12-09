namespace RazeniMinimem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pole = { -3, 5, 1, -2, 4, 4, 10 };
            foreach(int cislo in pole)
            {
                Console.Write(cislo + " ");
            }
            int min, pozice, pom;
            for (int i = 0; i < pole.Length; i++) { 
            min = pole[i];
            pozice = i;
                for (int j = i + 1; j < pole.Length; j++) {
                    if (pole[j] < min)
                    {
                        min = pole[j];
                        pozice = j;
                    }
                }
                pom = pole[i];
                pole[i] = min;
                pole[pozice] = pom;
                Console.WriteLine("Aktualni krok " + i);
                foreach (int cislo in pole)
                {
                    Console.Write(cislo + " ");
                }

            }
            Console.WriteLine();
            Console.WriteLine("Serazene pole:");
            foreach (int cislo in pole)
            {
                Console.Write(cislo + " ");
            }
        }
    }
}
