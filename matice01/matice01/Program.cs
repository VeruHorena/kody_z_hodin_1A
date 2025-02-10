namespace matice01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radek = 5;
            int sloupec = 5;
            int[,] matice = new int[radek, sloupec];
            Random generator = new Random();
            //naplneni matice hodnotami
            for(int i = 0; i < radek; i++)
            {
                for (int j=0;j< sloupec; j++)
                {
                    matice[i, j] = generator.Next(1, 10); //1-9
                }
            }

            //vypsani matice
            for(int i=0;i<radek; i++)
            {
                for(int j=0; j< sloupec; j++)
                {
                    Console.Write(matice[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Hlavni diagonala:");

            //hlavni diagonala
            for(int i=0; i<radek; i++)
            {
                Console.Write(matice[i, i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Vedlejsi diagonala:");
            //vedlejsi diagonala
            for (int i = 0; i < radek; i++)
            {
                Console.Write(matice[i, radek - i - 1] + " ");
            }

        }
    }
}
