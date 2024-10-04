namespace hodina4_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("Zadej hodnotu:");
              int hodnota = int.Parse(Console.ReadLine());

              if (hodnota >= 10)
              {
                  //vetev true
                  Console.WriteLine("Hodnota je vetsi nez 10.");
              }
              else
              {
                  //vetev false
                  Console.WriteLine("Hodnota neni vetsi nez 10.");
              }
            */
            Console.WriteLine("Zadej text:");
            string text = Console.ReadLine();
            
            if (text == "Ahoj" || text=="ahoj")
            {
                Console.WriteLine("Text byl ahoj");
            }
            else
            {
                Console.WriteLine("Text byl cau");
            }
        }
    }
}
