using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;

namespace TypeUnsafeKolekcije
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            ArrayList lista = new ArrayList();

            lista.Add(1);
            lista.Add("Neka rečenica");
            lista.Add(null);
            lista.Add(3.14);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Broj elemnata liste: " + lista.Count);//Koristimo kako bi vidjeli koliko
                                                                      //elemenata imamo u listi.

            if (lista.Contains(1)) Console.WriteLine("Sadrži jedan!"); 
            else Console.WriteLine("Nema jedinice!"); //Koristimo kako bi vidjeli da li sadrži neki element.

            lista.Clear(); //Koristimo kako bi obrisali podatke.
           
            if (lista.Contains(1)) Console.WriteLine("Sadrži jedan!");
            else Console.WriteLine("Nema jedinice!");

            lista.Add(6);
            lista.Insert(0, "stavljen na početak :)");

            lista.Remove(1);
            lista.RemoveAt(1); //Ako želimo maknuti nešto s određene pozicije moramo staviti AT(ne može samo
                               //Remove).

            lista.Add(9);
            lista.Add(13);
            Console.WriteLine("Original lista: ");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            lista.Reverse();
            Console.WriteLine("Obrnuta: ");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Sortirana lista: ");

            //lista.Sort(); Radi samo kada su u listi usporedivi podatkovni tipovi!
            foreach (var item in  lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Kapacitet liste: " + lista.Capacity); //Dodavanjem elemenata kapacitet se povečava.
            Console.WriteLine("Broj elemenata liste: "+ lista.Count); //Koliko je elemenata trenutno u listi.
                                                                      //(maknuli smo 1 stoga je nama 3, a kapacitet 4).

            Console.WriteLine(lista.IndexOf(6));
            Console.WriteLine(lista.IndexOf(13));

            lista.Add("novi string");
            lista.Add(3.14);
            lista.Add('a');

            foreach (var item in lista)
            {
                Console.WriteLine(item.GetType().Name);
                if (item.GetType().Name == "String")
                {
                    Console.WriteLine("Radim s stringovima.");
                }
            }


        }
    }
}
