using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pholymorfism
{
    class Program
    {

        public class TestOverloading
        {
            public void Add(string a1, string a2)
            {
                Console.WriteLine("Adding Two String {0} {1} :" , a1 , a2);
            }

            public void Add(int a1, int a2)
            {
                Console.WriteLine("Adding Two Integer {0} {1}:" , a1 , a2);
                Console.WriteLine(a1+a2);
            }
        }
        static void Main(string[] args)
        {
            TestOverloading obj = new TestOverloading();
            obj.Add("Manish", "Agrahari");
            obj.Add(5, 10);
            Console.ReadLine();
        {


        }


        }
    }
}
