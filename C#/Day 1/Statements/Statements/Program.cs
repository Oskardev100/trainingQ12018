using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration statement.
            int counter;

            // Assignment statement.
            counter = 1;

            // Error! This is an expression, not an expression statement.
            // counter + 1; 

            // Declaration statements with initializers are functionally
            // equivalent to  declaration statement followed by assignment statement:         
            int[] radii = { 15, 32, 108, 74, 9 }; // Declare and initialize an array.
            const double pi = 3.14159; // Declare and initialize  constant.          

            // foreach statement block that contains multiple statements.
            foreach (int radius in radii)
            {
                // Declaration statement with initializer.
                double circumference = pi * (2 * radius);

                // Expression statement (method invocation). A single-line
                // statement can span multiple text lines because line breaks
                // are treated as white space, which is ignored by the compiler.
               Console.WriteLine("Radius of circle #{0} is {1}. Circumference = {2:N2}",
                                        counter, radius, circumference);

                // Expression statement (postfix increment).
                counter++;
                Console.ReadKey();

            } // End of foreach statement block
        }
    }
}
