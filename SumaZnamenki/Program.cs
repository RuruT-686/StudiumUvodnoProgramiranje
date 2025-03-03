/*
 * Program traži unos brojeva i ispisuje sumu njegvih znamenki.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaZnamenki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj, suma = 0;
            Console.WriteLine("Unesite broj: ");
            broj=int.Parse(Console.ReadLine());

            while (broj > 0 ) 
            {
                int znamenka = broj % 10;
                suma += znamenka;
                broj = broj / 10;


                
            }

            Console.WriteLine("Suma znamenki je "+suma );

            for (; broj > 0;)
            {
              int znamenka = broj % 10;     //For petlja isti zadatak. Napraviti debug kad budem mogla.
              suma += znamenka;
              broj = broj / 10;
            }
        }
    }
}
