using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle:shape

    {
        private double Result { get; set; }
        public virtual int BaseT { get; set; }
        public virtual int Height { get; set; }

        public override void getArea()
        {
           this.Result=this.BaseT * this.Height;
        }

        public override void toString()
        {
            Console.WriteLine(this.Result);
        }
        public Triangle ()
        {
            this.BaseT = 5;
            this.Height = 6;

        }
       
    }

}



