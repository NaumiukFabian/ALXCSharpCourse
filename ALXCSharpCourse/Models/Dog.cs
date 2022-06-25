using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Models
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }

        public void Bark()
        {
            Console.WriteLine("Woof! Woof!");
        }

        public Dog()
        {
            Console.WriteLine("A new DOG has been created!");
        }

        public Dog(string name, string race)
        {
            Console.WriteLine("A new DOG with arguments has been created!");
            Name = name;
            Race = race;
        }

        public void Bite()
        {
            Console.WriteLine("Snap! Grr!");
        }

        public void Present()
        {
            Console.WriteLine($"Attention here is {Race} named {Name}!");
        }

        public static void Run()
        {
            Console.WriteLine("[Dog] running...");
        }
    }
}
