/*
 * Za uneseni radius izračunati opseg i površinu,no prikazati rezultat u float,double i int.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreopterečivanjeKrug
{
    internal class Program
    {
        static double Površina (double r)
        {
            return r * r * Math.PI;
        }

        static float Površina (float r)
        {
            return (float)Površina((double)r);

        }

        static int Površina (int r)
        {
            return (int)Površina((double)r);
        }

        static double Opseg(double r)
        {
            return 2 * r * Math.PI;
        }

        static float Opseg (float r)
        {
            return (float)(Opseg((double)r));
        }

        static int Opseg (int r)
        {
            return (int)(Opseg((double)r));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Unesite radius: ");
            double r=double.Parse(Console.ReadLine());

            Console.WriteLine("double površina: "+Površina(r));
            Console.WriteLine("float površina: "+Površina((float)r));
            Console.WriteLine("int površina: "+Površina((int)r));

        }
    }
}
