namespace FiboPole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.WriteLine("Zadej pocet prvku rady:");
            } while (int.TryParse(Console.ReadLine(), out n)==false || n <= 0);

            int[] rada = new int[n];
            //pocatecni 1 Fibonacciho rady
            rada[0] = 1;
            rada[1] = 1;
            for (int i = 2; i < n; i++)
            {
                rada[i] = rada[i - 1] + rada[i - 2];
            }

            Console.WriteLine("Vypis Fibonacciho rady");
            foreach (int prvek in rada)
            {
                Console.Write($"{prvek} ");
            }
        }
    }
}
