using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Academy
{
    class Triangle:Shape
    {
        public double getAreaTriangle()
        {
            return ((width * height)/2);
        }
    }
}
