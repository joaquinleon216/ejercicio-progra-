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
            bool continueFlag = true;

            while (continueFlag)
            {
                Shape shape = null;

                string selection;

                Console.WriteLine("Introduce el número: ");
                Console.WriteLine("1. Triángulo");
                Console.WriteLine("2. Rectangulo");
                Console.WriteLine("3. Cuadrado");
                selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        float triangleB;
                        float triangleH;
                        Console.WriteLine("Introduce la base del triángulo: ");
                        triangleB = float.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura del triángulo: ");
                        triangleH = float.Parse(Console.ReadLine());
                        shape = new Triangle(triangleB, triangleH);
                        break;

                    case "2":
                        float rectanguloB;
                        float rectanguloH;
                        Console.WriteLine("Introduce la base del rectángulo: ");
                        rectanguloB = float.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura del rectángulo: ");
                        rectanguloH = float.Parse(Console.ReadLine());
                        shape = new Rectangulo(rectanguloB, rectanguloH);
                        break;
                    case "3":
                        float side;
                        Console.WriteLine("Introduce el lado: ");
                        side = float.Parse(Console.ReadLine());
                        shape = new Cuadrado(side);
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

                if (shape != null)
                {
                    Console.WriteLine($"El área es {shape.CalculateArea()}");
                }
                Console.WriteLine("presiona si: ");
                string option = Console.ReadLine();
                if (option != "si")
                {
                    continueFlag = false;
                }
            }
            Console.ReadLine();
        }
    }
}
