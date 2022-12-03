using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem
{
    internal class CheckEquality
    {
        public void Equality()
        {
            Console.WriteLine("Enter the line point x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the line point x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the line point y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the line point y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            var Length1 = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine("Length1 is:" + Length1);

            Console.WriteLine("Enter the line point x3: ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the line point x4: ");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the line point y3: ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the line point y4: ");
            int y4 = Convert.ToInt32(Console.ReadLine());
            var Length2 = Math.Sqrt((Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2))); 
            Console.WriteLine("Length2 is:" + Length2); 
           
            if (Length1.Equals(Length2))
            {
                Console.WriteLine("The two lines are equal");
            }
            else
            {
                Console.WriteLine("The two lines are not equal");
            }
        }
    }
}


