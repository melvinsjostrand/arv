using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Sphere : Ishape
{

    private float Radie;

    public Sphere(float Radie)
    {
        this.Radie = Radie;
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

