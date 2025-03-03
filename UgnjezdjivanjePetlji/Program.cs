using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgnjezdjivanjePetlji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)     
            {
               for (int j = 1; j <= 10; j++)  //Nakon sto se isčita ova petlja U DEBUG,i++ se povaćava za jedan (idemo svaki broj onda množiti s dva)!
               {
                  Console.Write(i * j);
                  Console.Write("\t");  //Tabulator(kao tab na tipkovnici,ispiše uredno brojeve s istim razmakom međusobno i jedan ispod drugog).
               }
               Console.WriteLine();
            }
                                                                                                                     
        }                                      
    }
}         //Keep It Simple = KIS (Kratica u programiranju,više načina za isti rezultat/more then one way to skin a cat).