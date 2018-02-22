using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Abstraction:Encapsulation
    {
        Abstraction()
        {
            double result = this.length * this.width;
            Console.WriteLine("Result :" + result);
        }
    }
}
