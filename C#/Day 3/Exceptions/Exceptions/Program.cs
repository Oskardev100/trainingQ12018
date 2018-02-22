using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static double SafeDivision(double x, double y)

        {

            if (y == 0)
                throw new System.DivideByZeroException();
            return y / x;
        }

        static void Main(string[] args)
        {
            //DivideByZeroException--------------------------------------
            //int number1 = 3000;
            //int number2 = 0;
            //int result = number1 / number2;
            //try
            //{
            //    Console.WriteLine(number1 / number2);
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("Division of {0} by zero.", number1);
            //    Console.WriteLine(e);
            //}
            //Console.ReadKey();


            //IndexOutofRangeException----------------------
            //int[] array = { 1, 2, 3, 4, 5, 6 };

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Array {0}", array[i]);
            //    Console.ReadKey();
            //}




            // IndexOutofRangeException --------------------
            string[] names = { "Dog", "Cat", "Fish" };
            Object[] objs = (Object[])names;


            objs[1] = "Mouse";

            foreach (object animalName in objs)
            {
                System.Console.WriteLine(animalName);
                Console.ReadKey();
            }
            // Object obj = (Object)"HHHH";
            //objs[2] = obj;
            System.Console.WriteLine(objs[0]);
            Console.ReadKey();
            System.Console.WriteLine(objs[1]);
            Console.ReadKey();
            System.Console.WriteLine(objs[2]);
            System.Console.WriteLine(objs[3]);
            Console.ReadKey();

            ////  Bool to char -----Exception
            //  bool flag = true;
            ////  double number2 = 2;
            //Char a;
            //a = Convert.ToChar(flag);
            //Console.WriteLine(a);


            //for (int i = 0; i - 1 < i++; i++)
            //{

            //    Console.WriteLine("  " + i);
            //}
            //Console.ReadKey();

            //REcursive methods - Overflow exception-------------------
            //int i = RecursiveMethod();


        }

        //private static int RecursiveMethod()

        //{

        //    return RecursiveMethod();

        //}


    }

  
}
