using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demos
{
    public  class LoopsDemo
    {
        public static void Run()
        {
            int[] digitArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var sum1 = 0;
            Console.WriteLine("For each...");
            foreach(var digit in digitArray)
            {
                sum1 = sum1 + digit;
                Console.WriteLine($"Sum of digits: {sum1}");
            }

            sum1 = 0;
            Console.WriteLine("For...");
            for (int i = 0; i < digitArray.Length; i++)
            {
                sum1 = sum1 + digitArray[i];
                Console.WriteLine($"Sum of digits: {sum1}");
            }

            Console.WriteLine("While...");
            sum1 = 0;
            var iterator = 0;

            while (sum1 < 0)
            {
                sum1 = sum1 + digitArray[iterator];
                Console.WriteLine($"Sum of digits: {sum1}");
                iterator++;
            }

            iterator = 0;
            sum1 = 0;

            Console.WriteLine("DO While...");
            do 
            {
                sum1 = sum1 + digitArray[iterator];
                Console.WriteLine($"Sum of digits: {sum1}");
                iterator++;
            }
            while (sum1 < 0);

        }


    }
}
