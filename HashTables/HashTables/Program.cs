using System;
using System.Collections;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("001", ".Net");
            ht.Add("002", "C#");
            ht.Add("003", "ASP.Net");

            ICollection key = ht.Keys;

            Console.WriteLine(ht.ContainsKey("001"));
            Console.WriteLine(ht.ContainsValue("C#"));
            foreach (String k in key)
            {
                Console.WriteLine(ht[k]);
            }
            Console.ReadKey();

        }
    }
}
