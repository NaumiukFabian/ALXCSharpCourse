using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.M1
{
    public class CarAccessories : Cars
    {
        public string engine { get; set; }
        public string packet { get; set; }

        public string Engine()
        {
            int value = 0;
            Console.WriteLine("Kind of engine:");
            foreach(var i in Enum.GetNames(typeof(KindOfEngine)))
            {
                Console.WriteLine(i);
            }
            do
            {
                engine = Console.ReadLine().ToUpper();
                foreach (var engineCar in Enum.GetNames((typeof(KindOfEngine))))
                {
                    bool check;
                    check = engine == engineCar;
                    if (check)
                        value++;
                }
                if (value == 0)
                {
                    Console.WriteLine("default");
                }
            }
            while (value == 0);

            return engine;
        }

    }
}
