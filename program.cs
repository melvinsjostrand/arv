using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class program{
   
   
   
   
   
   
    public static void Main(){


            


int val = 1;

            while(val !=0)
            {


                Console.WriteLine("vilken width");
                float width = float.Parse(Console.ReadLine());
                Console.WriteLine("vilken Height");
                float height = float.Parse(Console.ReadLine());
                    triangle triangle = new triangle(width, height); 
                    Rectangle rectangle = new Rectangle(width, height);



Console.WriteLine("är de triangle elr rectangle");

val = int.Parse(Console.ReadLine());
            if (val == 1){
            Console.WriteLine("Arean av Triangle = " + triangle.T());
            Console.WriteLine("Omkretsen är =" + triangle.TO());
int val2 = 1;

while(val2 !=0){


Console.WriteLine("Skriv 1 om den är rätvinklig och 2 om den inte är de");
val2 = int.Parse(Console.ReadLine());

if ( val2 == 1){
    Console.WriteLine("den är rätvinklig WPWPWPWPWP");

}
else ( val2 == 2){
    Console.WriteLine("Den är inte rätvikling WPWPWPWWPWPWP");
}
}


            }

            


 
else if (val == 2)
{
            Console.WriteLine("Omkretsen är =" + rectangle.Ro());
            Console.WriteLine($"Arean på rectanglen är {rectangle.R()}");


 
}



}
    }



    }
    

    