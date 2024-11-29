using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] cisla = { -11, 0, 5, -12, 13, 24, 19, 13, -17 };
        //sem přijde váš kód
        int hledej;
        do
        {
            Console.Write("zadej hodnotu kterou chceš najít: ");

        } while (!int.TryParse(Console.ReadLine(), out hledej));
        
        for (int i = 0; i < cisla.Length; i++)
        {
            if (cisla[i] == hledej)
            {
                
                Console.WriteLine("hodnota se nachází na indexu " + i);
                break;
            }
            else if(i==cisla.Length-1)
            {
                Console.WriteLine("prvek nenalezen");
            }

        }
        

    }
}