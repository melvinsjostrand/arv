using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class triangle : Ishape
{

    private float height;
    private float width;

    public triangle(float width, float height)
    {

    }



    public float Area()
    {
        Console.WriteLine("width: " + width);
        float Area = (width * height) / 2;
        return Area;
    }

    public float Circumference()
    {
        float Circumference = (width + height + (float)Math.Sqrt((double)(width * width) + (double)(height * height)));
        return Circumference;
    }


}