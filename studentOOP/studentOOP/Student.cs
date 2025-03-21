using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentOOP
{
    class Student
    {
        private String jmeno;
        private int vek;
        private String adresa;
        private List<int> seznamZnamek;

        public void setJmeno (String jmeno)
        {
            this.jmeno = jmeno;
        }

        public String getJmeno()
        {
            return this.jmeno;
        }

        public void setVek (int vek)
        {
            this.vek = vek;
        }
        public int getVek()
        {
            return this.vek;
        }

        public void setAdresa (String adresa)
        {
            this.adresa = adresa;
        }

        public String getAdresa()
        {
            return this.adresa;
        }

        public void setZnamka(int znamka)
        {
            this.seznamZnamek.Add(znamka);  
        }

        public List<int> getZnamky()
        {
            return this.seznamZnamek;
        }
        public Student()
        {
            this.setJmeno("prazdne");
            this.setVek(0);
            this.setAdresa("prazdne");
            this.seznamZnamek = new List<int>();
        }

        public Student (string jmeno, int vek, string adresa)
        {
            this.setJmeno(jmeno);
            this.setVek(vek);
            this.setAdresa(adresa);
            this.seznamZnamek = new List<int>();
        }

        public void PredstavSe()
        {

            Console.WriteLine($"Ahoj jsem {this.getJmeno()}, " +
                $"je mi {this.getVek()} let a bydlim na {this.getAdresa()}");
        }
    }
}
