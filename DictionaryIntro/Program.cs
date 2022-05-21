using System;
using System.Collections.Generic;
namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> personlist = new Dictionary<int, string>();
            personlist.Add(1, "Mahmut");
            personlist.Add(2, "Mehmet");
            personlist.Add(4, "Ayşe");
            personlist.Add(6, "Fatma");

            foreach (var item in personlist)
            {
                Console.WriteLine(item);
            }


            MyDictionary<int, string> personlist2 = new MyDictionary<int, string>();
            personlist2.Add(1, "Mahmut");
            personlist2.Add(2, "Mehmet");
            personlist2.Add(4, "Ayşe");
            personlist2.Add(6, "Fatma");
            Console.WriteLine("Orjinal bitti.");
            for (int i = 0; i < personlist2.Lenght; i++)
            {
                Console.WriteLine("[" + personlist2.Key[i] + ", " + personlist2.Name[i] + "]");
                
            }

        }
    }
}
