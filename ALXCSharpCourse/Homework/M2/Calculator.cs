using ALXCSharpCourse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.M2
{
    public class Calculator
    {
        public void CalcPlusMinus()
        {

            int numberOfAction = 0;
            Console.WriteLine("On how many numbers do you want to perform the action?");
            bool action = Int32.TryParse(Console.ReadLine(), out numberOfAction);
            int[] arrayNumberOfAction = new int[numberOfAction];

            if (action)
            {
                if (numberOfAction <= 1)
                {
                    Console.WriteLine("You must specify number greater than 1");
                }
                else
                {
                    Console.WriteLine($"Entered {numberOfAction} numbers");
                    Console.WriteLine("What operation do you want?");
                    Console.WriteLine("You can select:");
                    Console.WriteLine("ADDITION - ENTER 0");
                    Console.WriteLine("SUBTRACTION - ENTER 1");
                    Console.WriteLine("Enter your option");
                    int option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"You chose {option}");

                    for (int i = 1; i <= arrayNumberOfAction.Length; i++)
                    {
                        Console.WriteLine($"Enter {i} number");
                        arrayNumberOfAction[i - 1] = Convert.ToInt32(Console.ReadLine());
                    }

                    switch (option)
                    {
                        case (int)OperationsPlusMinus.ADDITION:
                            int additionResult = arrayNumberOfAction.Sum();
                            Console.WriteLine($"Your additional result is: {additionResult}");
                            break;

                        case (int)OperationsPlusMinus.SUBTRACTION:
                            double subtractionResult = (arrayNumberOfAction.Sum()) * (-1);
                            Console.WriteLine($"Your substraction result is {subtractionResult}");
                            break;

                        default:
                            Console.WriteLine("default");

                            break;
                    }

                }

            }
            else
            {
                Console.WriteLine("You have to enter number of action");
                Console.WriteLine("If you want end press q on you keyboard otherwise select next operation");
            }

        }

        public void CaclSubDiv()
        {
            Console.WriteLine("Enter 1 number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2 number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What operation do you want?");
            Console.WriteLine("You can select:");
            Console.WriteLine("SUBTRACTION - ENTER 0");
            Console.WriteLine("DIVISION - ENTER 1");
            Console.WriteLine("Enter your option");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You chose {option}");

            switch (option)
            {
                case (int)OperationsSubDev.MULTIPLICATION:
                    int multiplicationResult = number1 * number2;
                    Console.WriteLine($"Your multiplication result is: {multiplicationResult}");
                    break;

                case (int)OperationsSubDev.DIVISION:
                    double dividedResult = number1 / number2;
                    Console.WriteLine($"Your division result is: {dividedResult}");
                    break;
            }
        }

    }

}
