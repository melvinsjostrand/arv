using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arv
{
    public class Cylinder
    {
        private float height;
        private float Radie;

        public Cylinder(float Radie, float height)
        {

        }



        public float Area()
        {

            float Area = (2 * (float)Math.PI * Radie * height) + (2 * (float)Math.PI * (Radie * Radie));
            return Area;
        }

        public float Circumference()
        {
            float Circumference = ((float)Math.PI * (Radie* Radie)+(float)Math.PI * (Radie * Radie)+((2 * (float)Math.PI * Radie) * height));
            return Circumference;
        }


    }
}

