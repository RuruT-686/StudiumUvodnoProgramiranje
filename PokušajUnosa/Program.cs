using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokušajUnosa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj;
            Console.WriteLine("Unesite broj: ");
            //broj=int.Parse(Console.ReadLine()); -Program će puknuti umjesto toga radimo...

            if (int.TryParse(Console.ReadLine(), out broj))
            {
                Console.WriteLine("Uspješno ste unjeli broj " + broj);
            }
            else
            {
                Console.WriteLine("Ne znam kako to pretvoriti u broj!");
                //broj = -1;
            }

            Console.WriteLine(broj);

            
            

        }
    }
}
