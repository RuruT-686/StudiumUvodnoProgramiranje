using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varijable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijeli broj: ");
            string unos = Console.ReadLine();
            int broj = int.Parse(unos);

            Console.WriteLine("Unesite decimalni broj: ");
            float decimalni=float.Parse(Console.ReadLine());

            Console.WriteLine(broj + " " + decimalni);
            
            broj=(int)decimalni;
            decimalni=broj            


        }
    }
}
