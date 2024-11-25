namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //vypsani cisel 1-10
          /* for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }*/

            //vypsani cisel 10-1
            /*for(int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }*/

            //vypsani sudych cisel
            for(int i = 2; i <= 10; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
