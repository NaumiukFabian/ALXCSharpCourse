using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.M1
{
    public class TV
    {
        public string TvMake { get; set; }
        public double TvSize { get; set; }
        public string TvSystem { get; set; }

        public TV(string tvMake, double tvSize, string tvSystem)
        {
            TvMake = tvMake;
            TvSize = tvSize;
            TvSystem = tvSystem;
            Console.WriteLine($"You own a {tvMake} brand TV that is {tvSize} inches and {tvSystem}");
        }

        public void TurnOn()
        {
            Console.WriteLine("Do you want turn on your TV? [YES/NO]");
            string answer = Console.ReadLine();
            if(answer == "YES")
            {
                Console.WriteLine("Your TV has been turned on");
            }
            else
            {
                Console.WriteLine("Your TV hasn not been tourned on");
                
            }

        }

        public string TurnOf()
        {
            Console.WriteLine("Do you want turn of your TV? [TAK/NIE]");
            string answer = Console.ReadLine();
            if (answer == "YES")
            {
                Console.WriteLine("Your TV has been turned of");
            }
            else
            {
                Console.WriteLine("Your TV hasn not been tourned of");
            }
            return answer;

        }
    }
}
