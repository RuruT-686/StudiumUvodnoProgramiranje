using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 2;

            Console.WriteLine("Aritemtički: ");
            Console.WriteLine(a + "+" + b + "=" + (a + b));
            Console.WriteLine(a + "-" + b + "=" + (a - b));
            Console.WriteLine(a + "*" + b + "=" + (a * b));
            Console.WriteLine(a + "/" + b + "=" + (a / b));
            Console.WriteLine(a + "/" + b + "=" + ((float) a / b));
            Console.WriteLine(a + "%" + b + "=" + (a % b));

            Console.WriteLine(a + b / a - b);
            Console.WriteLine((a+b) / (a-b));
            Console.WriteLine(((float)a+b) / (a-b));

            b--;
            --b;  //krementiranje i dekrementiranje
            Console.WriteLine(b);
            Console.WriteLine(b++);
            Console.WriteLine(b);
            Console.WriteLine(++b);

            //b = 0;
           //Console.WriteLine(a / 0);
          //Console.WriteLine(a / b); //većina programskih jezika ne može djeliti s nulom,izazvati će grešku!

            Console.WriteLine();
            Console.WriteLine("Relaciski operatori");

            Console.WriteLine(a + "<" + b + "=" + (a < b));
            Console.WriteLine(a + "<=" + b + "=" + (a <= b));
            Console.WriteLine(a + ">=" + b + "=" + (a >= b));
            Console.WriteLine(a + "==" + b + "=" + (a == b )); 
            Console.WriteLine(a + "!=" + b + "=" + ( a != b));

            Console.WriteLine();
            Console.WriteLine("Logički operatori");
            Console.WriteLine(!true); //false
            //Console.WriteLine(!b); Ne može se koristiti nad operantima brojčanog tipa!Samo koristiti nad logičkim podaktovnim tipovima!
            Console.WriteLine(true || false); //Alt ili alt gr (hrvatska tipkovnica) + W za ||(or).
            Console.WriteLine(true && false); //Shift + 6 za &(and).



            














        }
    }
}
