using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class program{
   
   
   
   
   
   
    public static void Main(){
            Console.WriteLine("Räkna ut arean på trianglen");
            Console.WriteLine("Skriv in bredden:");
            float width = float.Parse(Console.ReadLine());
            Console.WriteLine("skriv in höjden:");
            float Height = float.Parse(Console.ReadLine());
            triangle triangle = new triangle(width, Height);
            Console.WriteLine(triangle.T());
            Console.Write("Arean av Triangle = " + triangle.T());

            Console.WriteLine();

Console.WriteLine("Räkna ut omkretsen på trianglen");





        Console.WriteLine("Räkna ut arean på rectanglen");
            Console.WriteLine("skriv in bredden på Rectangle:");
            width = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the höjden of a Rectangle:");
            Height = float.Parse(Console.ReadLine());


            Rectangle rectangle = new Rectangle(width, Height);
            Console.WriteLine(rectangle.R());
            Console.WriteLine($"Arean på rectanglen är {rectangle.R()}");

Console.WriteLine("Räkna ut omkretsen på rectanglen");
Console.WriteLine("skriv in bredden");
width = float.Parse(Console.ReadLine());
 Console.WriteLine("skriv in höjden:");
 Height = float.Parse(Console.ReadLine());
 Console.WriteLine(rectangle.Ro());
 Console.WriteLine("Omkretsen är =" + rectangle.Ro());

    }



    }
    

    