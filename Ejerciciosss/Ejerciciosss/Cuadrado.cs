using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciosss
{
    class Cuadrado : Shape
    {
        private float side;

        public Cuadrado(float side)
        {
            this.side = side;
        }

        public override float CalculateArea()
        {
            return side * side;
        }
    }
}
