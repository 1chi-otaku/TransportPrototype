using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine engineengine = new Engine("Supa");
            Vessel a = new Vessel("Karasik","A1",engineengine,35);
            a.Print();
            Vessel b = (Vessel)a.Clone();
            Console.WriteLine();
            b.cargo_capacity = 1000;
            b.Print();
            Console.WriteLine();
            a.Print();

        }
    }
}
