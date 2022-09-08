using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class triangle:Shape
    {


    public triangle(float width, float height): base(width,height)
    {
        
    }

public float T(){
    float ta = (width * height) / 2;
    return ta;
}

}


