using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_6
{
    internal class Program
    {
        public class Neboder
        {
            private double visina;
            private int brojkatova;

            public double Visina
            {
                get { return visina; }
                set { visina = value; }
            }

            public int Brojkatova
            {
                get { return brojkatova; }
                set { brojkatova = value; }
            }

            public override string ToString()
            {
                return $"Visina nebodear je {visina}, a broj katova je {brojkatova}";
            }

            public double AverageFloorHeight()
            {
                return visina / brojkatova;
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
