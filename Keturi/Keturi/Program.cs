using System;

namespace Keturi
{
    class Program
    {
        static void Main(string[] args)
        {
            



            if (float.TryParse(Console.ReadLine(), out float pirmas))
            {
                
            }
            else
            {
                Console.WriteLine("no");
            }
            if (float.TryParse(Console.ReadLine(), out float antras))
            {
             
            }
            else
            {
                Console.WriteLine("no2");
            }

            float trys = pirmas * antras;
            Console.WriteLine(trys);





            /* Console.WriteLine("Provide lenght: ");
            while (isNumber == 0)
            {
                                
                if (float.TryParse(Console.ReadLine(), out float leght))
                {
                    Console.WriteLine();
                    int isNumber = 1;
                }
                else
                {
                    Console.WriteLine("Not a number");
                    int isNumber = 0;
                }
            }


            Console.WriteLine("Provide width");
            if (float.TryParse(Console.ReadLine(), out float width))
            {
                Console.WriteLine();
                int isNumber = 1;
            }
            else
            {
                Console.WriteLine("Not a number");
                int isNumber = 0;
            }



            

            float area = leght * width;
            Console.WriteLine("Area is: ", area);

            Console.WriteLine(area.ToString("0.00"));
           
*/









        }
    }
}
