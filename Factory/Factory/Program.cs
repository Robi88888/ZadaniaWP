using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory fabryka = new Factory();
            FactoryInterface obiekt = fabryka.GetObject("users");
            Console.WriteLine(obiekt.addItem());

            FactoryInterface obiekt2 = fabryka.GetObject("products");
            Console.WriteLine(obiekt2.addItem());

            FactoryInterface obiekt3 = fabryka.GetObject("privileges");
            Console.WriteLine(obiekt3.addItem());
        }

    }
}
