using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Comparision Programs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("-------LineComparisionProblems ------");
                Console.WriteLine("Select the option");
                Console.WriteLine("1.CalculateLength" + "\n" +
                                  "2.CheckEquality" + "\n" +
                                  "3.Compare2Lines" + "\n" +
                                  "4.Exit" + "\n");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        Console.WriteLine("Welcome To Line Comparison Program");
                        CalculateLength calculateLength = new CalculateLength();
                        calculateLength.Length();
                        break;
                    case 2:
                        CheckEquality checkEquality = new CheckEquality();
                        checkEquality.Equality();
                        break;
                    case 3:
                        Compare2Lines compare2Lines = new Compare2Lines();
                        compare2Lines.Compare();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}