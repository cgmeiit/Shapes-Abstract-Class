using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : shape
    {


        private int Length { get; set; }
        private int Width { get; set; }
        private int Result { get; set; }

        public override void getArea()
        {
            this.Width = 4;
            this.Length = 5;
            this.Result = this.Length * this.Width;
        }

        public override void toString()
        {

            Console.WriteLine("Hello World");

            Console.WriteLine(this.Result);
        }
        public Rectangle()
        {
            this.Length = 10;
            this.Width = 5;

        }
    }
}


    

