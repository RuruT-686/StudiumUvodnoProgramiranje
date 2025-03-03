/*
 * Nečemo tražiti nita da se unese,napraviti samo jednostavan ispis.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaPrvih100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;                        //Varijabla u koju spremamo sumu.
            for (int i = 1; i <= 100; i++)      //Petlja u koju....
            {
               sum += i;                        //Varijabla inicijalizacije se ne vidi nigdje van petlje,nema doseg van petlje.
            }
              Console.WriteLine(sum);
        }
    }
}
