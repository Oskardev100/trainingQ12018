using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();

            Rect.setWidth(5);
            Rect.setHeight(7);
            Triangle tr = new Triangle();

            tr.setWidth(5);
            tr.setHeight(7);

            // Print the area of the object.
            Console.WriteLine("Total area Rectangle: {0}", Rect.getAreaRectangle());
            Console.WriteLine("Total area Triangle: {0}", tr.getAreaTriangle());
            Console.ReadKey();
        }
    }


}
