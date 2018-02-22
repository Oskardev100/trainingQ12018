using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshOnArrays.MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //Return backward string "aimedacA"
            string inputString = "Academia";
            //Size of the input string (aka "Academia")?
            int size = inputString.Length;


            //4 different methods to get the expected functionallity, all of them are valid.


            #region Method 1. Assign values to array
            char[] letters = new char[size];
            for (int i = 0; i < size; i++)
            {
                letters[i] = inputString[i];
            }
            char[] letters2 = inputString.ToCharArray();
            #endregion




            #region Method 2. Switch position one by one based on original string 
            char[] letters3 = new char[size];
            int count = 0;
            for (int i = size - 1; i >= 0; i--)
            {
                letters3[count] = inputString[i];
                count++;
            }
            #endregion




            #region Method 3. Switch position one by one based on an array
            char[] letters4 = new char[inputString.Length];

            for (int i = 0; i < inputString.Length; i++)
            {
                int position = inputString.Length - i;
                letters4[i] = letters2[position - 1];
            }
            Console.WriteLine("Backward Word: " + letters4.ToString());
            #endregion





            #region Method 4. Using reverse method on string and set values one by one
            char[] letters5 = new char[inputString.Length];
            count = 0;      //Reset value for the counter
            foreach (var item in inputString.Reverse())
            {
                letters[count] = item;
                count++;
            }
            #endregion





            #region Method 5. Single line method
            char[] letters6 = inputString.Reverse().ToList().ToArray();
            #endregion

            Console.Read();
        }


    }
}
