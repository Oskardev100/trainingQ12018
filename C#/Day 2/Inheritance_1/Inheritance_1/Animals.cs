using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_1
{
  public  class Animals
    {

        //protected int ID { get; set; }
        //protected string Title { get; set; }
        //protected string Description { get; set; }
        //protected TimeSpan jobLength { get; set; }
       protected int num { get; set; }
      protected  int num1 { get; set; }
        public Animals()
        {
            num = 12;
            num1 = 13;
        }
        public Animals(string type, string name, int age)
        {
            type = "NNN";
            name = "OOO";
                age = 12;
            
        }

        public void multi(int result)
        {
            num = 12;
            num1 = 13;
            result = result * num * num1;
            Console.WriteLine(result);
            
        }

    }
}
