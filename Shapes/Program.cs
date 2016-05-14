using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle shape1 = new Triangle();
            shape1.getArea();
            shape1.ToString();

            Rectangle shape2 = new Rectangle();
            shape2.getArea();
            shape2.ToString();
            // testing app still not prining.

              
          
        }
    }
}
