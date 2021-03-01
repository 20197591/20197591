using System;

namespace tarea_1
{
    class Program
    {
        static void Main(string[] args)
        {


            rectangle rectangulo1 = new rectangle();

            rectangulo1.basis = 3;
            rectangulo1.height = 7;

            
            rectangle rectangulo2 = new rectangle();

            rectangulo2.basis = 1.5;
            rectangulo2.height = 4;


            rectangle rectangulo3 = new rectangle();

            rectangulo3.basis =7;
            rectangulo3.height = 10;

            rectangulo1.Grow(10);



            Console.WriteLine("AREAS");

            Console.WriteLine(rectangulo1.Area());
            Console.WriteLine(rectangulo2.Area());
            Console.WriteLine(rectangulo3.Area());


            Console.WriteLine("PERIMETROS");

            Console.WriteLine(rectangulo1.perimeter());
            Console.WriteLine(rectangulo2.perimeter());
            Console.WriteLine(rectangulo3.perimeter());



            Console.WriteLine("COMPARACION");

            Console.WriteLine(rectangulo1.Compare(rectangulo2));




            Console.ReadKey();
        }
    }
}
