﻿/*
 * Program računa opseg i povrinu kruga,a traži unos radiusa.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsegPovršinaKruga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite radius");
            float r=float.Parse(Console.ReadLine());
            const float pi = 3.14f;
            float P, O;
            O= 2 * r * pi;
            P= r * r * pi; //P= r * 2 / 2;
            Console.WriteLine("Površina je "+P+"\nOpseg je "+O);
            Console.ReadKey();
        }
    }
}
