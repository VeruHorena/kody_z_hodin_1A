using System.Security.Cryptography.X509Certificates;

namespace hledaniSousedu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matice = { { 1, 0, 1 }, { 0, 1, 1 }, { 1, 1, 0 } };
            int[,] mapasousedu = new int[matice.GetLength(0), matice.GetLength(1)];

            for (int i = 0; i < matice.GetLength(0); i++) {
                for (int j = 0; j < matice.GetLength(1); j++)
                {
                  mapasousedu[i,j] =  sousede(matice, i, j);
                }
            }

            foreach (int i in mapasousedu)
                Console.Write(i + " ");
        }

        public static int sousede (int[,] matice, int i, int j)
        {
            int sousedi = 0;

            if ((i - 1 >=0) && (j - 1>=0))
                if (matice[i - 1, j - 1] == 1)
                    sousedi++;

            if ((i - 1>=0) && j>=0)
                if (matice[i - 1, j] == 1)
                    sousedi++;

            if ((i - 1 >= 0) && (j + 1 <= matice.GetLength(1)-1))
                if(matice[i - 1, j + 1] == 1)
                sousedi++;

            if ((i >= 0) && (j - 1 >= 0))
                if(matice[i, j - 1] == 1)
                                sousedi++;
            if ((i >= 0) && (j + 1 <= matice.GetLength(1)-1))
                if(matice[i, j + 1] == 1)
                sousedi++;
            if ((i + 1 <= matice.GetLength(0)-1) && (j - 1 >= 0)) 
                if( matice[i + 1, j - 1] == 1)
                sousedi++;
            if ((i + 1 <= matice.GetLength(0)-1) && (j >= 0))
                if(matice[i + 1, j] == 1)
                sousedi++;
            if ((i + 1 <= matice.GetLength(0)-1) && (j + 1 <= matice.GetLength(1)-1))
                if( matice[i + 1, j + 1] == 1)
                sousedi++;

            return sousedi;
        }
    }
}
