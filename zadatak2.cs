using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisi prvu rijec");
            string strin1 = Console.ReadLine();
            Console.WriteLine("Upisi drugu rijec");
            string strin2 = Console.ReadLine();
            string[] strings = { strin1, strin2 };
            Sortiraj.Sort(strings);
            Console.WriteLine("Rijeci su po redu");
            foreach (string str in strings) 
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
