using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class Compare
    {
        public static void Licr()
        {
             


        Console.WriteLine("Enter value for  coordinate x1");
               double  x1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter value for   coordinate y1");
               double y1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter value for  first coordinate x2");
               double x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter value for  first coordinate y2");
               double y2 = Convert.ToInt32(Console.ReadLine());

            double length1 = Math.Sqrt(Math.Pow((x2 - x1), 2)) + Math.Sqrt(Math.Pow((y2 - y1), 2));

            double a1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for   coordinate y1");
            double b1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter value for  first coordinate x2");
            double a2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for  first coordinate y2");
            double b2 = Convert.ToInt32(Console.ReadLine());

            double length2 = Math.Sqrt(Math.Pow((a2 - a1), 2)) + Math.Sqrt(Math.Pow((b2 - b1), 2));

            if (length1==length2)
            {
                Console.WriteLine("Two are equal");
            }

            else
            {
                Console.WriteLine("Unequal");
            }





        }
    }
}
