﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetljaDOWHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.Write("Unesite broj: ");
                a=int .Parse(Console.ReadLine());
            }   while (a < 0);                          //Izlazimo iz petlje van tek kad unesemo pozitivan broj.
            
        }
    }

}


