using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Manage a list for a position--------------------
            List<int> list = new List<int>(new int[] { 2, 3, 7 });

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("List: " + list[i]);

            }
            Console.ReadKey();

            //----------------Manage a list in a simply way
            list.Add(2);
            list.Add(3);
            list.Add(7);
           // Loop through List with foreach.
            foreach (int prime in list)
                {
                    System.Console.WriteLine(prime);
                }

            //-----------------Manage a bool list

            List<bool> listbool = new List<bool>();
            listbool.Add(true);
            listbool.Add(false);
            listbool.Add(true);
            Console.WriteLine(listbool.Count);//3 Result
            list.Clear();
            Console.WriteLine(listbool.Count);//0 Result

            //----------------------Copy an array in a list
            int[] arr = new int[3];
            arr[0] = 2;
            arr[1] = 3;
            arr[2] = 5;
            List<int> list_array = new List<int>(arr);
            Console.WriteLine(list_array.Count);
            //---------------Exists o Does not Exist?

            List<string> names = new List<string>();
            names.Add("Oralia");// Position 0
            names.Add("Otto");//1
            names.Add("Yusel");//2
            int index = names.IndexOf("Oralia");//Exists
            Console.WriteLine(index);

            index = names.IndexOf("AAA");//Does not exist
            Console.WriteLine(index);
            Console.ReadKey();

            //How to join------------------------
            List<string> cities = new List<string>();
            cities.Add("New York");
            cities.Add("Mumbai");
            cities.Add("Berlin");
            cities.Add("Istanbul");
            cities.Insert(2, "Tokio");

            string line = string.Join(",", cities.ToArray());
            Console.WriteLine(line);







        }
    }
}
