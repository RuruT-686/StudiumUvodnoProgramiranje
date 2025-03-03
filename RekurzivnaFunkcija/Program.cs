/*
 * Program za izračun faktorijela s rekruzivnom i ne rekruzivnom funkcijom.
 * 1!=1
 * 2!=1*2
 * 3!=1*2*3
 * 4!=1*2*3*4
 * ...
 * n!=1*2...*(n-1)*
 * 
 * n!=(n-1)!n
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RekurzivnaFunkcija
{
    internal class Program
    {
        static long fakt (long n)
        {
            long f = 1;
            for (long  i = 2; i <=n; i++)
            {
                f = f * i;
            }
            return f;

        }   

        static long faktrek (long n)
        {
            if (n < 2) return 1;
            return faktrek(n - 1) * n;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj: ");
            long broj;
            if(long.TryParse(Console.ReadLine(), out broj))
            {
                Console.WriteLine(broj + "!="+ fakt(broj));
                Console.WriteLine(broj + "!=" + fakt(broj)); 
            }
        }
    }
}
