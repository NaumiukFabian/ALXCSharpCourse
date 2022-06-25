using System;
namespace ALXCSharpCourse.Demos
{
    public class VariablesDemos
    {
        public static void Run()
        {
            /*Console.WriteLine("Variables demo");
            int number = 10;
            bool booleanValue = true;
            bool booleanValue1 = false;
            //string name = "Fabian";
            double number2 = 0.22;
            float number3 = (float) number2;


            //Console.WriteLine(name);
            Console.WriteLine(1);
            Console.WriteLine(booleanValue);
            Console.WriteLine(number2);
            Console.WriteLine(number3);

            //name
            string name = "Jan";
            //last name
            string lastName = "Kowalski";
            //phone number
            string phoneNumber = "999 333 222";
            //height
            double heightInMeters = 1.82;
            //address
            string streetName = "Ciemna";
            string buildingName = "6";
            string flatName = "25";
            string postalCode = "00-203";
            string City = "Warszawa";
            Console.WriteLine("Ul. " + streetName +" "+ buildingName + "/" + flatName + " " + postalCode + " " + City);
            (Console.WriteLine($"Ul. {streetName} {buildingName}/{flatName} {postalCode} {City}");
            */

            //name
            Console.WriteLine("Personal data form\n");
            Console.Write("Enter name: ");
            string name1 = Console.ReadLine();
            //last name
            Console.Write("Enter last name: ");
            string lastName1 = Console.ReadLine();
            //phone number
            Console.Write("Enter phone number: ");
            string phoneNumber1 = Console.ReadLine();
            //height
            Console.Write("Enter heigh: ");
            double heightInMeters1 = Convert.ToDouble(Console.ReadLine());
            //address
            Console.Write("Enter street name: ");
            string streetName1 = Console.ReadLine();
            Console.Write("Enter building name: ");
            string buildingName1 = Console.ReadLine();
            Console.Write("Enter flat name: ");
            string flatName1 = Console.ReadLine();
            Console.Write("Enter postal code: ");
            string postalCode1 = Console.ReadLine();
            Console.Write("Enter City: ");
            string City1 = Console.ReadLine();
            string address1 = $"Ul. {streetName1} {buildingName1}/{flatName1} {postalCode1} {City1}";
            Console.WriteLine();
            Console.WriteLine($"{name1} {lastName1}\nheighnt: {heightInMeters1} [m], phone number: {phoneNumber1}" + $"\nAddress: {address1}");
            //Console.WriteLine($"Ul. {streetName1} {buildingName1}/{flatName1} {postalCode1} {City1}");



        }
        public static void RunCalculator()
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Enter x numer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y numer: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"{x} + {y} = {x+y}");
            Console.WriteLine($"{x} - {y} = {x-y}");
            Console.WriteLine($"{x} * {y} = {x*y}");
            Console.WriteLine($"{x} / {y} = {Convert.ToDouble(x) / Convert.ToDouble(y)}");
            Console.WriteLine($"{x} modulo {y} = {x%y}");
        }

        public static void RunLogicCalculator()
        {
            Console.WriteLine("Simple Logical Calculator");
            Console.WriteLine("Enter x numer: ");
            bool x = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter y numer: ");
            bool y = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"{x} AND {y} = {x && y}");
            Console.WriteLine($"{x} OR {y} = {x || y}");
            Console.WriteLine($"{x} XOR {y} = {x ^ y}");
        }
    }
}
