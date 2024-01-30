using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        class KlassX
        {
            private int broj;
            public int broj1
            {
                get(return broj);
                set(broj= value);
            }
        }
    class KlassX : KlassY
    {

    }
        static void Main(string[] args)
        {
        KlassY y = new KlassY();
        y.Broj = 10;

        Console.WriteLine("Vrijednost broja je (y.broj)");
        }
    
    }
}
}
