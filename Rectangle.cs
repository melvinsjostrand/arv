using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Rectangle : Shape
{


    public Rectangle(float width, float height) : base(width, height)
    {


    }
    public float R()
    {
        float ra = width * height;
        return ra;
    }
    public float Ro()
    {
        float ro = ((width * 2) + (height * 2));
        return ro;
    }

    public float ROA()
    {
        float ROA = (width + width + width + width);
        return ROA;


    }

    public float ROC()
    {
        float ROC = width * width;
        return ROC;
    }



    public override float Area()
    {
        float Area = width * height;

        return Area;
    }



    public override float Circumference()
    {
        float Circumference = ((width * 2) + (height * 2));
        return Circumference;
    }


}


