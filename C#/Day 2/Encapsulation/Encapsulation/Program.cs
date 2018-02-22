using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{

    //class Rectangle
    //{
    //    //member variables
    //    public double length;
    //    public double width;

    //    protected double GetArea()
    //    {
    //        return length * width;
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine("Length: {0}", length);
    //        Console.WriteLine("Width: {0}", width);
    //        Console.WriteLine("Area: {0}", GetArea());
    //    }
    //}//e
    class Program
    {
        static void Main(string[] args)
        {
            Encapsulation r = new Encapsulation();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }
}
