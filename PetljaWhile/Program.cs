using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PetljaWhile   //While petlju čemo najčešće koristiti kada ne znamo koliko puta će se nešto ponoviti, dok s for petljom možemo predvidjeti koliko puta će se
                        // nešto ponoviti već u samome startu!
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            while (a > 3)
            {
                Console.WriteLine(a);
                a--;   //Operator dekramenta, oduzme se jedan te sprema u varijablu.
            }
            Console.WriteLine(" a je postao " + a);

            while (a > 2)
            {
                Console.WriteLine(a);
                a = a * 10;  
            }
            Console.WriteLine("a je postao " + a );
        }     
    }
}
