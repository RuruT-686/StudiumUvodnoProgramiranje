/*Program traži unos stanja visine vode tri senzora.Koliko svaki senzor pokazuje
 * iznad 130mm,pumpa mora biti upaljena,no ukoliko bilo koji pokaže između 100 i 130;
 * sustav mora biti u fazi spremnost.Ukoliko svaki pokazuje iznad 200,onda je sustav zakazao!
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PumpaIF
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int s1, s2, s3;

            Console.WriteLine("Unesite očitanje 1. senzora");
            s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite očitanje 2. senzora");
            s2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite očitanje 3. senzora");
            s3 = int.Parse(Console.ReadLine());

            if (s1 > 130 && s2 > 130 && s3 > 130) Console.WriteLine("Pumpe upaljene");
            if ((s1 > 100 && s1 <= 130) ||
                (s2 > 100 && s2 <= 130) ||
                s3 > 100 && s3 <= 130) Console.WriteLine("Sustav u fazi spremnosti!");
            if (s1 > 200 && s2 > 200 && s3 > 200) Console.WriteLine("Sustav neispravan!");

        }
    }
}
