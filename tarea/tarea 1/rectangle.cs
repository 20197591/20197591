using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace tarea_1
{
    class rectangle
    {
        public double basis;
        public double height;

        public double Area()
        {

            double area = this.basis * this.height;

            return area;

        }


        public double perimeter()
        {

            double perim;

           perim = this.basis+this.basis+this.height+this.height;

            return perim;
        }

        public void Grow(double quantity)
        {
            this.basis = this.basis + quantity;
            this.height = this.height + quantity;




        }


        public double Compare (rectangle rect)
        {

            return this.Area() - rect.Area();




        }

    }
}
