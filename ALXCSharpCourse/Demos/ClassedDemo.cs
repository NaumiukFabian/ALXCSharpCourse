using ALXCSharpCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demos
{
    public class ClassedDemo
    {
        public static void Run()
        {
            // NazwaKlasy nazwaObiektu = new NazwaKlasy();
            Dog westieDog = new Dog();
            westieDog.Name = "Doris";
            westieDog.Race = "Null";
            westieDog.Bite();
            westieDog.Bark();
            westieDog.Present();
            Dog labradorDog = new Dog();
            labradorDog.Name = "Borys";
            labradorDog.Race = "Labrador Retriever";
            labradorDog.Bark();
            labradorDog.Bite();
            labradorDog.Present();

            Dog goldenDog = new Dog
            {
                Name = "Miso",
                Race = "Golden Retriever"
            };
            goldenDog.Bark();
            goldenDog.Bite();
            goldenDog.Present();

            Dog borderColieDog = new Dog("Java", "Border Colie");
            borderColieDog.Present();
            borderColieDog.Bark();
            borderColieDog.Bite();
            Dog.Run();
        }
    }
}
