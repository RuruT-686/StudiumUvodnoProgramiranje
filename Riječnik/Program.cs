using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Riječnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string,string> hrvatski= new Dictionary<string,string>();

            hrvatski.Add("menu", "izbornik");
            hrvatski.Add("copy", "kopiraj");
            hrvatski.Add("paste", "zalijepi");
            /*
             * foreach (var red in datoteka){
             * riječnik.Add(original,prijevod);  
             * }
             */  

            try
            {
                hrvatski.Add("menu", "glavni izbobrnik");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            foreach(var riječ in hrvatski)
            {
                Console.WriteLine(riječ.Key+" = "+riječ.Value);
            }

            Console.WriteLine(hrvatski["paste"]);
            hrvatski["write"] = "zapiši";
            Console.WriteLine();

            foreach (var riječ in hrvatski)
            {
                Console.WriteLine(riječ.Key + " = "+ riječ.Value);
            }

            hrvatski["write"] = "unesi";
            Console.WriteLine(hrvatski["write"]);

            Console.WriteLine();
            try
            {
                Console.WriteLine(hrvatski["read"]);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string r ="";
            if(!hrvatski.TryGetValue("read", out r))
            {
                hrvatski["read"] = "čitaj";         
            }
            else
            {
                Console.WriteLine(r);
            }

            foreach (var riječ in hrvatski)
            {
                Console.WriteLine(riječ.Key + " = "+ riječ.Value);
            }
            Console.WriteLine();

            hrvatski.Remove("čitaj");
            foreach (var riječ in hrvatski)
            {
                Console.WriteLine(riječ.Key + " = "+ riječ.Value);
            }
            Console.WriteLine();

            hrvatski.Remove("read");
            foreach (var riječ in hrvatski)
            {
                Console.WriteLine(riječ.Key + " = " + riječ.Value);
            }
            Console.WriteLine();

            Console.WriteLine("Ključevi: ");
            foreach(string k in  hrvatski.Keys)
            {
                Console.WriteLine(k);
            }



        }   
    }
}
