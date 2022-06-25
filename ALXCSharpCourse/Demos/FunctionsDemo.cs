using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demos
{
    public class FunctionsDemo
    {
        public static void Run()
        {
            Console.WriteLine("-- Functions demo --");
            WriteSentence();
            Console.WriteLine("\n------\n");
            WriteSentence("Truskawski są smaczne...");
            WriteSentence("Truskawski są smaczne...", 12);
            int sum = AddNumbers(2, 3);
            string address = FormatAddress("Jasna", "12", "23");
            Console.WriteLine(address);
            Console.WriteLine(FormatAddress("Meander", "22", "12"));
            Console.WriteLine(sum);
        }

        /*
         modyfikatotDostępu coZwraca Nazwa(argumenty)
        sygnatura funckji: coZwraca Nazwa(argumenty)
        */

        public static void WriteSentence()
        {
            Console.WriteLine("Hello");
        }
        public static void WriteSentence(string sentence)
        {
            Console.WriteLine(sentence);
        }

        //Overload - przeładowanie
        public static void WriteSentence(string sentence, int number)
        {
            Console.WriteLine($"{sentence} {number}");
        }

        public static int WriteSentence(string sentence, double number)
        {
            Console.WriteLine($"{sentence} {number}");
            return 0;
        }

        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public static string FormatAddress(string streetName, string buildingNumber, string flatNumber)
        {
            return $"Ulica {streetName} {buildingNumber}/{flatNumber}";
        }
    }
   
}
