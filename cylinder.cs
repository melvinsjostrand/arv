using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Cylinder : Ishape
{
    private float height;
    private float Radie;

    public Cylinder(float Radie, float height)
    {
        this.Radie = Radie;
        this.height = height;
    }



    public float Area()
    {

        float Area = (2 * (float)Math.PI * Radie * height) + (2 * (float)Math.PI * (Radie * Radie));
        return Area;
    }

    public float Circumference()
    {
        float Circumference = ((float)Math.PI * (Radie + Radie) + (float)Math.PI * (Radie + Radie) + ((2 * Radie) * height));
        return Circumference;
    }


}


