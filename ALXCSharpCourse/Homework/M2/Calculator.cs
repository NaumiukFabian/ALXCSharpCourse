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
        public void Calc()
        {

            Console.WriteLine("On how many numbers do you want to perform the action?");
            int numberOfAction;
            bool action = Int32.TryParse(Console.ReadLine(), out numberOfAction);
            Console.WriteLine(numberOfAction);
            string quit = "a";
            do
            {
                if (action)
                {
                    if (numberOfAction < 1)
                    {
                        Console.WriteLine("You must specify number greater than 1");

                    }
                    else if (numberOfAction == 2)
                    {
                        Console.WriteLine("Entered 2 numbers");
                        Console.WriteLine("What operation do you want?");
                        Console.WriteLine("You can select:");
                        Console.WriteLine("ADDITION - ENTER 0");
                        Console.WriteLine("SUBTRACTION - ENTER 1");
                        Console.WriteLine("MULTIPLICATION - ENTER 2");
                        Console.WriteLine("DIVISION - ENTER 3");
                        Console.WriteLine("Enter your option");
                        int option = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"You chose {option}");
                        Console.WriteLine("Enter 1 number");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter 2 number");
                        int number2 = Convert.ToInt32(Console.ReadLine());



                        switch (option)
                        {
                            case (int)Operations.ADDITION:
                                int additionResult = number1 + number2;
                                Console.WriteLine($"Your additional result is: {additionResult}");
                                Console.WriteLine("If you want end press q on you keyboard otherwise select next operation");
                                quit = Console.ReadLine();
                                break;

                            case (int)Operations.MULTIPLICATION:
                                int multiplicationResult = number1 * number2;
                                Console.WriteLine($"Your multiplication result is: {multiplicationResult}");
                                break;

                            case (int)Operations.DIVISION:
                                double dividedResult = number1 / number2;
                                Console.WriteLine($"Your division result is: {dividedResult}");
                                break;

                            case (int)Operations.SUBTRACTION:
                                double subtractionResult = number1 - number2;
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

                }
            } while (quit == "q");
            
        }
    }
}
