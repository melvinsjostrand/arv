using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using arv;

public class Rectangle : Ishape
{
    private float height;
    private float width;
    public Rectangle(float width, float height)
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



    public float Area()
    {
        float Area = width * height;

        return Area;
    }



    public float Circumference()
    {
        float Circumference = ((width * 2) + (height * 2));
        return Circumference;
    }


}


