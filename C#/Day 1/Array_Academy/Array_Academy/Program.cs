using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Academy
{
    class Program
    {
        static void Main(string[] args)
        {


            double[] salary = { 111, 2000, 2000 };
            float[] bonus = { 1.1f,1.2f,1.3f};

            salary.CopyTo(bonus, 0);

            Console.WriteLine("Salary:" + salary[0]);
            Console.WriteLine("Salary:" + salary[1]);
            Console.WriteLine("Salary:" + salary[2]);

            //int x = 1;

            //int[] arraysize;


            //for (int i = 0; i < 10; i++)
            //{

            //    arraysize = new int[x];
            //    arraysize[i] = i;
            //    Console.WriteLine("Array Number {0}", arraysize[i]);
            //    x++;
            //    Console.ReadKey();

            //}

            //int[,] biarray = new int[3, 3];

            //for(int i = 0; i < 3;i++)
            //{
            //    for(int x = 0; x < 3;x++)

            //    {
            //        biarray[i, x] = x+2;
            //        Console.WriteLine("BiArray" + biarray[i, x] + x +i);
            //        Console.ReadKey();
            //    }
            //}
        }
    }
}
