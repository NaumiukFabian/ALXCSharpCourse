using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.M1
{
    public class WhiskyBottle
    {
        public string Brand { get; set; }
        public double Capacity { get; set; }
        public string Type { get; set; }

        public string SetBrand()
        {
            Console.WriteLine("Enter your whisky's brand");
            Brand = Console.ReadLine();
            Console.WriteLine("Good choice :)");
            return Brand;

        }

        public double SetCapacity()
        {
            Console.WriteLine("What bottle capacity do you want?");
            Capacity = Convert.ToDouble(Console.ReadLine());
            while(Capacity < 0.7)
            {
                Console.WriteLine("Bad choice! You need more!");
                Console.WriteLine("What bottle capacity do you want?");
                Capacity = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Good choice");
            return Capacity;
        }

        public string SetType()
        {
            Console.WriteLine("Choice your whisky's type");
            Type = Console.ReadLine();
            Console.WriteLine("Not bad");
            return Type;
        }

        public void Drink()
        {
            Console.WriteLine("Wanna drink?[YES/NO]");
            string answer = Console.ReadLine();
            while (answer != "YES")
            {
                Console.WriteLine("Bad answer. Try again");
                Console.WriteLine("Wanna drink?[YES/NO]");
                answer = Console.ReadLine();

            }
            Console.WriteLine("Good choice");
        }
    }
}
