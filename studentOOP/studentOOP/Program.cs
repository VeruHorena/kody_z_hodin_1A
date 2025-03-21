namespace studentOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.PredstavSe();
            Student st2 = new Student("Pepa", 5, "Slunickova 3");
            Console.WriteLine();
            st2.setZnamka(2);
            st2.setZnamka(1);
            foreach (int znamka in st2.getZnamky())
            {
                Console.Write(znamka + ", ");
            }
            Console.WriteLine();
            st2.PredstavSe();
            st1.setJmeno("Johana");
            st1.setVek(6);
            st1.setAdresa("S dlouhyma nohama");
            st1.PredstavSe();
        }
    }
}
