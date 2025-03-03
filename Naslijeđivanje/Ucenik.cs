using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naslijeđivanje
{
    public class Ucenik : Osoba 
    {
        private int matematika;

        public int Matematika
        {
            get { return matematika; }
            set {
                int nova = value;
                if (nova < 1 || nova > 5) nova = 1;
                matematika = nova;
            }

        }

        public Ucenik() { }

        public Ucenik(string prezime, string ime, DateTime datumRodjenja):
            base(prezime,ime,datumRodjenja)
        {
            Matematika = 1;
        }

        public string PunoIme()
        {
            return Prezime + " , " + Ime;  
        }

        public override string ToString()
        {
            return Ime + " " + Prezime + " je ocjenen s " + Matematika + "  iz matematike ";
        }
    }
}
