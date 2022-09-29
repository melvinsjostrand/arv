using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arv
{
    public class Sphere
    {
       
        private float Radie;

        public Sphere(float Radie)
        {

        }



        public float Area()
        {

            float Area = (4 * (float)Math.PI * (Radie * Radie));
            return Area;
        }

        public float Circumference()
        {
            float Circumference = ((float)Math.PI * (Radie + Radie));
            return Circumference;
        }


    }
}
