using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int polomer = 10;

        // Velikost kreslici plochy - ctverec
        int velikost = polomer * 2 + 1;

        for (int y = 0; y < velikost; y++)
        {
            for (int x = 0; x < velikost; x++)
            {
                // Přepočet souřadnic do středu
                double dx = x - polomer;
                double dy = y - polomer;

                // Kontrola, zda bod leží blízko kružnice
                double vzdalenost = Math.Sqrt(Math.Pow(dx,2) + dy * dy);
                if ((vzdalenost - polomer) < 0.5)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(" ");
                }       
            }
            Console.WriteLine();
        }
    }
}
