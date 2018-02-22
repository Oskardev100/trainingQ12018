using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animals = new Animals("Dog",
                "Rocko",
               3
                );

            Mammals mammals = new Mammals("Bear",
            "Monkey",
            "Whale",
            3
            );
            
            animals.multi(0);
            Console.WriteLine(animals.ToString());
            Console.WriteLine(mammals.ToString());
            Console.ReadKey();

        }
    }
}
