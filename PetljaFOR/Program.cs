using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetljaFOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

              Console.WriteLine();


            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i+1);  
            }

            Console.WriteLine();

            for (int i = 0; i <= 100; i++)
            {
              Console.WriteLine(i);
            }

            Console.WriteLine();

            ///for(int i = 100; i >= 0; i--)
            // {
            //    Console.WriteLine(1);   //Odbrojava brojeve s malom stankom.
            //    Thread.Sleep(1000)
            // }  



            for (int i = 0; i <= 100; i=i+2)
            {
                Console.WriteLine(i);             //Preskače svaki drugi broj znači ispisuje samo parne brojeve.
            }

           
            Console.WriteLine();


            for (int i = 7; i <= 100; i = i + 7)
            {
                Console.WriteLine(i);             
            }

            Console.WriteLine();

            for (int i = 0; i <100;)
            {
                Console.WriteLine(i++);
            }


            //for (; ; )
            //{
            //    Console.WriteLine(1); U startu beskonačna petlja (može se prekinuti s break.) 
            //}
        }
    }
}
