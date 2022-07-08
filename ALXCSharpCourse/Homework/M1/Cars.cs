using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.M1
{
    public class Cars
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public string SetCar()
        {
            int value = 0;
            Console.WriteLine("Chose what car you prefer:");
            foreach (var car in Enum.GetNames((typeof(ListOfCars))))
            {
                Console.WriteLine(car);
            }
            do
            {
                Name = Console.ReadLine().ToUpper();
                foreach (var car in Enum.GetNames((typeof(ListOfCars))))
                {
                    bool check;
                    check = Name == car;
                    if (check)
                        value++;
                }
                if(value == 0)
                {
                    Console.WriteLine("default");
                }
            }
            while (value == 0);


            return Name;
        }

        public string SetModel()
        {
            string[] bmwModels = { "2002 TURBO", "I3", "I8", "ISSETA", "M1", "M3", "M5", "M6", "SERIA1", "SERIA2", 
                                    "SERIA2 ACTICE TOURER", "SERIA3", "SERIA3 GT", "SERIA4", "SERIA5", "SERIA6", "SERIA7", "SERIA8", "X1", 
                                    "X2", "X3", "X4", "X5", "X6", "Z1", "Z3", "Z4", "Z8"};
            return Model;
        }
    }
}
