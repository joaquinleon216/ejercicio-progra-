using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciosss
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangle t = new Triangle(10, 20);
            Shape s = new Shape();
            Shape st = t;


            Console.WriteLine($"Triangle: {t.CalculateArea()}");
            //Console.WriteLine($"Shape: {s.CalculateArea()}");
            Console.WriteLine($"ST: {st.CalculateArea()}");


            Console.ReadLine();








            /*
            float b;
            float h;
            Triangle t;

            Console.WriteLine("Introducir la base: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Introducir la altura: ");
            h = float.Parse(Console.ReadLine());

            t = new Triangle(b, h);

            Console.WriteLine($"Area: {t.CalculateArea()}");

            Shape s = new Shape();
            Console.WriteLine($"Area: {s.CalculateArea()}");
            Console.ReadLine();*/
        }
    }
}
