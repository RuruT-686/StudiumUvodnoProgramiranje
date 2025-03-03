/* 
 * Program traži unos cijelih brojeva dokle gos su pozitivni.
 * Nakon toga ispisuje sumu znamenki unesenih brojeva.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaZnamenkiBrojeva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj;
            int sum = 0; //Uvijek na početku 0.
            do
            {
                Console.WriteLine("Unesite broj:");
                broj = int.Parse(Console.ReadLine());
                if (broj > 0)
                {
                    while (broj != 0)
                    {
                        int z = broj % 10;
                        sum += z;
                        broj /=10;
                    }
                }
            } while (broj >= 0);

            Console.WriteLine("Suma znamenki svih pozitivnih brojeva je " + sum); 
        }
    }
}
