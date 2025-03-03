using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DogađajUvod
{

    internal class Program
    {

        static void Main (string[] args)
        {
            Osoba o = new Osoba();

            o.PromjenaPrezimena += O_PromjenaPrezimena;
            o.Prezime = "Jelačić";
            o.Prezime = "Telsa;";
            o.Prezime = "Škokčević";

            o.PromjenaPrezimena-= O_PromjenaPrezimena;
            o.Prezime = "Horvat";

            o.PromjenaPrezimena += O_PromjenaPrezimena;
            o.PromjenaPrezimena += O_PromjenaPrezimena1;
            o.PromjenaPrezimena += Promjena;
            o.Prezime = "Knežević";
        }

        public static void Promjena(object sender, EventArgs e)
        {

        }

        private static void O_PromjenaPrezimena1(object sender, EventArgs e)
        {
            Console.WriteLine("Druga metoda promjene!");
        }

        private static void O_PromjenaPrezimena(object sender, EventArgs e)
        {
            Console.WriteLine("Prezime promjenjeno!");
            Console.WriteLine("Novo prezime je "+((Osoba)sender).Prezime);
        }
    }
}
