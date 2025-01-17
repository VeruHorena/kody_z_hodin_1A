using System.Diagnostics;

namespace BubbleSortRazeni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] poleHodnot = new int[1000];
            int pom;
            Random generator = new Random();
            Stopwatch stopky = new Stopwatch(); //jeste nejsou spustene

            for (int i = 0; i < poleHodnot.Length; i++)
            {
                poleHodnot[i] = generator.Next(1,101);
               // Console.Write(poleHodnot[i] + ",");
            }

            stopky.Start(); //zacneme merit cas
            for(int i = 0; i < poleHodnot.Length - 1; i++)
            {
                for(int j = 0;j<poleHodnot.Length -1 - i; j++)
                {
                    if (poleHodnot[j] > poleHodnot[j + 1])
                    {
                        pom = poleHodnot[j];
                        poleHodnot[j] = poleHodnot[j + 1];
                        poleHodnot[j + 1] = pom;
                    }
                }
            }
            stopky.Stop();
            long casBubble = stopky.ElapsedMilliseconds;
            for (int i = 0;i<poleHodnot.Length;i++)
            {
                Console.Write(poleHodnot[i] + ",");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("BubbleSort " + casBubble + " ms");
            


        }
    }
}
