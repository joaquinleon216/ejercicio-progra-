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

                Console.WriteLine("Introduce el número de la figura: ");
                Console.WriteLine("1. Triángulo");
                Console.WriteLine("2. Rectángulo");
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
                        float rectangleB;
                        float rectangleH;
                        Console.WriteLine("Introduce la base del rectángulo: ");
                        rectangleB = float.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura del rectángulo: ");
                        rectangleH = float.Parse(Console.ReadLine());
                        shape = new Rectangle(rectangleB, rectangleH);
                        break;
                    case "3":
                        float side;
                        Console.WriteLine("Introduce el lado: ");
                        side = float.Parse(Console.ReadLine());
                        shape = new Square(side);
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

                if (shape != null)
                {
                    Console.WriteLine($"El área es {shape.CalculateArea()}");
                }
                Console.WriteLine("Introducir si para continuar ingresando figuras: ");
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
