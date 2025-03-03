/* Program ispisuje riješnje kvadratne jednađbe za unesen a, b i c.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratnaJednađba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Unesite a : ");
            a= double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite b : ");
            b= double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite c : ");
            c= double.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;
            if(d<0) Console.WriteLine("Jednađba nema riješenje.");

            d=Math.Sqrt(d);
            double x1, x2;
            x1 = (-b + d) / (2 * a);
            x2 = (-b - d) / (2 * a);
            Console.WriteLine(" X1=" + x1 + "\nX2=" + x2);

        }    
    }
}
