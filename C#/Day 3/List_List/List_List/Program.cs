using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_List
{
    class Program
    {
        static void Main(string[] args)
        {

          

            //Copy a list into another list
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> list2 = new List<int>(list1);

            //Print a simple list

            foreach (int param in list2)

            {
                Console.WriteLine("List:" + param);
                Console.ReadKey();
            }


            //Create a matrix
            List<List<int>> matriz = new List<List<int>>();
            for (int i = 0; i < 10; i++)
            {
                matriz.Add(new List<int>());
                for (int j = 0; j < 10; j++)
                {
                    matriz[i].Add(j);
                }
            }
            //Print the matrix 
            foreach (List<int> fila in matriz)
            {
                foreach (int num in fila)
                {
                    Console.Write(" " + num);


                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
