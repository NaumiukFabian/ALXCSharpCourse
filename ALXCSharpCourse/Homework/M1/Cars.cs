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
            string[] audiModels = { "E-TRON GT", "E-TRON", "A1", "A3", "A4", "A5", "A6", "A7", "A8", "Q2", "Q3", "Q4 E-TRON", "Q5", "Q7", "Q8", "TT", "R8" };

            string[] volkswagenModels = { "UP!", "POLO", "T-CROSS", "TAIGO", "ID.3", "ID.4", "ID.5", "ID.BUZZ", "T-ROC", "GOLF", "GOLF VARIANT", "TOURAN",
                                            "TIGUAN", "TIGUAN ALLSPACE", "PASSAT", "ARTEON", "SHARAN", "TOUAREG"};

            Console.WriteLine($"You can chose this models {Name}");

            switch (Name)
            {
                case "BMW":
                    int value = 0;
                    foreach(string model in bmwModels)
                    {
                        Console.WriteLine(model);
                    }
                    Console.WriteLine($"Enter what model {Name} you want:");

                    do
                    {
                        Model = Console.ReadLine().ToUpper();
                        foreach (string model in bmwModels)
                        {
                            bool check = Model == model;
                            if (check)
                                value++;
                        }
                        if (value == 0)
                        {
                            Console.WriteLine("default");
                        }
                    }
                    while (value == 0);

                    break;

                case "AUDI":
                    int value1 = 0;
                    foreach (string model in audiModels)
                    {
                        Console.WriteLine(model);
                    }
                    Console.WriteLine($"Enter what model {Name} you want:");

                    do
                    {
                        Model = Console.ReadLine().ToUpper();
                        foreach (string model in audiModels)
                        {
                            bool check = Model == model;
                            if (check)
                                value1++;
                        }
                        if (value1 == 0)
                        {
                            Console.WriteLine("default");
                        }
                    }
                    while (value1 == 0);
                    break;

                case "VOLKSWAGEN":
                    int value2 = 0;
                    foreach (string model in volkswagenModels)
                    {
                        Console.WriteLine(model);
                    }
                    Console.WriteLine($"Enter what model {Name} you want:");

                    do
                    {
                        Model = Console.ReadLine().ToUpper();
                        foreach (string model in volkswagenModels)
                        {
                            bool check = Model == model;
                            if (check)
                                value2++;
                        }
                        if (value2 == 0)
                        {
                            Console.WriteLine("default");
                        }
                    }
                    while (value2 == 0);
                    break;

                    default:
                    Console.WriteLine("default");
                    break;
            }

            return Model;
        }

        public void info()
        {
            Console.WriteLine($"You chose: {Name} {Model}");
        }
    }
}
