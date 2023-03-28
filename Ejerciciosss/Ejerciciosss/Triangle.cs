﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciosss
{
    class Triangle : Shape
    {
        private float b;
        private float h;

        public Triangle(float b, float h)
        {
            this.b = b;
            this.h = h;
        }

        public override float CalculateArea()
        {
            return b * h / 2;
        }
    }
}
