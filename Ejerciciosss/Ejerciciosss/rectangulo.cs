using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciosss
{
    class rectangulo : Shape
    {
        private float ba;
        private float al;

        public rectangulo(float ba, float al)
        {
            this.ba = ba
            this.al = al;
        }

        public override float CalculateAreaRectangulo()
        {
            return ba * al;
        }
    }
}
