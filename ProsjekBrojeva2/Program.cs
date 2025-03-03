/*
*Program traži unos brojeva dokle god se ne unese 0.
 Nakon toga ispisuje prosjek svih unesenih brojeva. 
*/ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsjekBrojeva2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, brojac = 0;
            int broj;
            do
            {
                Console.WriteLine("Unesite broj: ");
                broj=int.Parse(Console.ReadLine());
                if (broj != 0 ) 
                {
                    sum += broj;
                    brojac++;          //Do while petlja će se bar minimalno jednom izvršiti,
                                       //while petlja se ne mora ni jednom izvršiti!

                }

            } while (broj != 0);

              Console.WriteLine("Prosjek svih brojeva je" + ((float)sum / brojac).ToString("0.00"));

        }
    }
}
