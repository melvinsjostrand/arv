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

public float TO(){
    float TO = (width + height + (float)Math.Sqrt((double)(width * width) + (double)(height * height)));
    return TO;
}


public float TOA(){
    float TOA = (width + height + height);
    return TOA;
}

public float TOO(){
    float TOO = (width + width + width);
    return TOO;
}
}