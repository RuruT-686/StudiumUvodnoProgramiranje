//Program treba ispisati tisuću 1000 prostih brojeva.
//Program treba ispisati 1000 prostih brojeva.Koristimo očito ugnjezdjivanje petlji.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TisućuProstihBrojeva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj = 1;
            int brojac = 1000;
            do 
            {
                bool prost = true;
                for (int i = 2; i < broj; i++)
                {                                      
                     if (broj % i == 0)
                     {
                        prost = false;
                        break;
                     }

                }
                if (prost)
                {
                   Console.WriteLine(broj);
                    brojac--;
                }
                broj++;
            } while(brojac > 0); 

        }   
    }
}
