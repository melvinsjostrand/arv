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
            Console.WriteLine("Arean av Triangle = " + triangle.T());
            Console.WriteLine("Omkretsen är =" + triangle.TO());
            Console.WriteLine();


 




        Console.WriteLine("Räkna ut arean på rectanglen");
            Console.WriteLine("skriv in bredden på Rectangle:");
            width = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the höjden of a Rectangle:");
            Height = float.Parse(Console.ReadLine());


            Rectangle rectangle = new Rectangle(width, Height);

            Console.WriteLine("Omkretsen är =" + rectangle.Ro());
            Console.WriteLine($"Arean på rectanglen är {rectangle.R()}");


 

    }



    }
    

    