using ALXCSharpCourse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demos
{
    public class ConditionalsDemo
    {
        public static void Run()
        {
            int number = 2;
            if (number > 15)
            {
                Console.WriteLine($"The number {number} is greater than 15");
            }
            else if (number == 15)
            {
                Console.WriteLine($"The nuber {number} is equal to 15");
            }
            else
            {
                Console.WriteLine($"The number {number} is smaller than 15");
            }
        }

        public static void RunNumberApp()
        {
            Console.WriteLine("Numer app");
            Console.Write("Enter a number: ");
            int x;
            bool succeeded = Int32.TryParse(Console.ReadLine(), out x);
            //x = Convert.ToInt32(Console.ReadLine());

            if (succeeded)
            {
                if(x%2 == 0)
                {
                    Console.WriteLine($"The number {x} is eaven");
                }
                else
                {
                    Console.WriteLine($"The number {x} is odd");
                }
            }
            else
            {
                Console.WriteLine("The given input is not a number!");
            }
        }

        public static void RunSwitch()
        {
            var sex = Sex.MALE;
            switch (sex)
            {
                case Sex.MALE:
                    Console.WriteLine("The sex is male");
                    break;

                case Sex.FEMALE:
                    Console.WriteLine("The sex is female");
                    break;

                case Sex.CUSTOM:
                    Console.WriteLine("The sex is custom");
                    break;

                default:
                    Console.WriteLine("default");
                    break;
            }
            Console.WriteLine("Switch edn...");

            int number = 5;
            switch (number)
            {
                case 0:
                    Console.WriteLine("Hello");
                    break;

                case 1:
                    Console.WriteLine("Potato");
                    break;

                case 126:
                    Console.WriteLine("TFDF");
                    break;

                default:
                    Console.WriteLine("default");
                    break;
            }
            Console.WriteLine("Switch edn...");
        }
        
    }
}
