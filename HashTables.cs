using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesandBinarySearchTree
{
    internal class HashTables
    {
        public static void PerformHashTables()
        {
            Hashtable Hash = new Hashtable();
            Hash.Add("1", "Ajay");
            Hash.Add("2", "Chandra");
            Hash.Add("3", "Awesome");
            foreach(DictionaryEntry data in Hash) 
            {
                Console.WriteLine(data.Key + " "+data.Value);
            }
            Console.WriteLine("entry deleted using the Remove method");
            Hash.Remove("1");
            foreach (DictionaryEntry data in Hash)
            {
                Console.WriteLine(data.Key + " " + data.Value);
            }
            Console.WriteLine("----------------------");
            Hash.Clear();
            Console.WriteLine("HashTable got cleared");

        }
    }
}
