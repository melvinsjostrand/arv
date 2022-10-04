using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



    public class Circle : Ishape
    {



        private float Radie;

        public Circle(float Radie)
        {
            this.Radie = Radie;
        }



        public float Area()
        {

            float Area = ((float)Math.PI * (Radie * Radie));
            return Area;
        }

        public float Circumference()
        {
            float Circumference = ((float)Math.PI * (Radie + Radie));
            return Circumference;
        }


    }




