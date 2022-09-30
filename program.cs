using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class program
{






    public static void Main()
    {
    Ishape  s = null;
    


        int val = 1;
                    Console.WriteLine("Skriv en höjd");
         float height = float.Parse(Console.ReadLine());
        Console.WriteLine("Skriv en bredd");
        float width = float.Parse(Console.ReadLine());
           Console.WriteLine("Skriv en Radie");
        float Radie = float.Parse(Console.ReadLine());
        while (val != 0)
        {

            Console.WriteLine("Vill du skriva ut en Rectangle skriv 1 och en triangle skriv 2");
            val = int.Parse(Console.ReadLine());

            if (val == 1)
            {
                s = new Rectangle(width, height);

            }
            else if (val == 2)
            {
                s = new triangle(width, height);
                

            }

            else if (val == 3)
            {
                s = new Circle(Radie);
            }
            else if (val == 4)
            {
                s = new Cylinder(Radie, height);
            }
            else if (val == 5)
            {
                s = new Sphere(Radie);
            }
            else
            {
                continue;
            }


            Console.WriteLine(s.Area());
            Console.WriteLine(s.Circumference());


        }
    }


}
















