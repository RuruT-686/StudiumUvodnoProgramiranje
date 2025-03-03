using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcije
{
    internal class Program
    {

        static void Pozdrav()
        {
            Console.WriteLine("Pozdrav iz funkcije! :)"); //Editiranjem funkcije momentalno se mijenja kod.
        }

        static int Zbroj(int a, int b)
        {
            return a + b;               //Kod podatkovnog tipa po automatizmu moramo vratiti vrijednost!

        }

        static int Umnožak(int a, int b)
        {
            int c = a * b;
            return c;
        }


        /// <summary>
        /// Funkcija za ispitivanje da li je prosljeđen broj prost.
        /// </summary>
        /// <param name="n"></param>Cijeli bro koi ispituemo da li je prost.
        /// <returns></returns>Vraća bool je ili nije /<returns>
        static bool Prost(int n)
        {
            //DONE: Implementirati!!!      Juniori riješili TOODO-WOOHOO! :D
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        

        static void Main(string[] args) //Samo po sebi funkcija.
        {
            Pozdrav();
            Console.WriteLine(Zbroj(4,7)); 

            int a = 4,  b = 1;
            Console.WriteLine(Umnožak( a,b));

            if(Prost(31)) Console.WriteLine("31 je prost :)");
            else Console.WriteLine("Broj nije prost...");

            if (Prost(14)) Console.WriteLine("14 je prost :)");
            else Console.WriteLine("Broj nije prost...");

            if (Prost(65)) Console.WriteLine("65 je prost :)");
            else Console.WriteLine("Broj nie prost...");
        }
    }
}
