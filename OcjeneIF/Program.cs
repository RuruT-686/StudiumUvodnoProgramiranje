/*
 *Za unesen prosjek ocjena u brojačnom obliku,ispisati opći uspjeh u riječima.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcjeneIF
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Unesite prosjek ocjena: ");
            float ocjena = float.Parse(Console.ReadLine());

            //Klasičan način rada
            if (ocjena < 1.0) Console.WriteLine("Neispravan unos,ocjena mora biti u rasponu od 1.0 do 5.0!");
            if (ocjena >= 1.0 && ocjena < 2.0) Console.WriteLine("Nedovolno!");
            if (ocjena >= 2.0 && ocjena < 2.5) Console.WriteLine("Dovoljan");
            if (ocjena >= 2.5 && ocjena < 3.5) Console.WriteLine("Dobar");
            if (ocjena >= 3.5 && ocjena < 4.5) Console.WriteLine("Vrlo dobar");
            if (ocjena >= 4.5 && ocjena < 5.0) Console.WriteLine("Odličan");
            if (ocjena > 5.0) Console.WriteLine("Neispravan unos,ocjene moraju biti u rasponu od 1.0 do 5.0!");


            //Prošireni if...else

            if (ocjena <1.0) Console.WriteLine("Neispravan unos,ne smie biti manja od 1.0!");
            else if (ocjena <2.0) Console.WriteLine("Nedovoljno!");
            else if (ocjena < 2.5) Console.WriteLine("Dodovolno!");
            else if (ocjena < 3.5) Console.WriteLine("Dobar");
            else if (ocjena < 4.5) Console.WriteLine("Vrlo dobar");
            else if (ocjena <= 5.0) Console.WriteLine("Odličan");
            else Console.WriteLine("Neispravan unos,ocjene moraju biti u rasponu od 1.0 do 5.0!");

        }
    }
}
