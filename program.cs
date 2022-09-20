using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class program
{






    public static void Main()
    {

        Shape s;
        Console.WriteLine("Skriv en höjd");
        float height = float.Parse(Console.ReadLine());
        Console.WriteLine("Skriv en bredd");
        float width = float.Parse(Console.ReadLine());


        int val = 1;

        while (val != 0)
        {

            Console.WriteLine("Vill du skriva ut en Rectangle skriv 1 och en triangle skriv 2");
            val = int.Parse(Console.ReadLine());

            if (val == 1)
            {
                s = new Rectangle(width, height);
                Console.WriteLine(s.Area());
                Console.WriteLine(s.Circumference());
            }
            else if (val == 2)
            {
                s = new triangle(width, height);
                Console.WriteLine(s.Area());
                Console.WriteLine(s.Circumference());
            }
        }



        s = new triangle(width, height);
        s = new Rectangle(width, height);


        /*      int val = 1;

              while (val != 0)
              {


                  Console.WriteLine("Vill du göra en rectangle,kvadrat, rätviklig eller en liksidig triangle");

                  val = int.Parse(Console.ReadLine());

                  if (val == 1)
                  {
                      Console.WriteLine("rectangle");
                      Console.WriteLine("vilken width");
                      float width = float.Parse(Console.ReadLine());
                      Console.WriteLine("vilken Height");
                      float height = float.Parse(Console.ReadLine());
                      Rectangle rectangle = new Rectangle(width, height);
                      Console.WriteLine("Omkretsen är =" + rectangle.Ro());
                      Console.WriteLine($"Arean på rectanglen är {rectangle.R()}");




                  }



                  else if (val == 2)
                  {
                      Console.WriteLine("kvadrat");
                      Console.WriteLine("Vad är längden på sidan?");
                      float width = float.Parse(Console.ReadLine());
                      Rectangle rectangle = new Rectangle(width, width);
                      Console.WriteLine("Omkretsen är =" + rectangle.ROA());
                      Console.WriteLine($"Arean på rectanglen är {rectangle.ROC()}");
                  }



                  else if (val == 3)
                  {

                      Console.WriteLine("Rätviklig");
                      Console.WriteLine("vilken width");
                      float width = float.Parse(Console.ReadLine());
                      Console.WriteLine("vilken Height");
                      float height = float.Parse(Console.ReadLine());
                      triangle triangle = new triangle(width, height);
                      Console.WriteLine("Arean av Triangle = " + triangle.T());
                      Console.WriteLine("Omkretsen är =" + triangle.TO());


                  }


                  else if (val == 4)
                  {
                      Console.WriteLine("liksidig");
                      Console.WriteLine("Rätviklig");
                      Console.WriteLine("Hur lång är en av sidorna");
                      float width = float.Parse(Console.ReadLine());
                      triangle triangle = new triangle(width, width);
                      Console.WriteLine("Arean av Triangle = " + triangle.TOAC());
                      Console.WriteLine("Omkretsen är =" + triangle.TOO());

                  } 



              }

          }*/

    }


}
















