using ALXCSharpCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demos
{
    public class ArraysAndListsDemo
    {
        public static void Run()
        {
            int x = 4;
            //typ[] nazwa = new typ[numberOfElements];
            int[] array1 = new int[7];
            array1[0] = 4;
            array1[1] = 2;
            array1[2] = 1;
            array1[3] = 0;
            array1[4] = 3;
            array1[5] = 4;
            array1[6] = 1;
            //typ[] nazwa = {elements}
            int[] array2 = { 4, 2, 1, 0, 3, 4, 1 };

            //foreach(typ elementName in arrayName)
            Console.WriteLine("Array1");
            foreach(int nubmer in array1)
            {
                Console.Write($"{nubmer} ");
            }

            Console.WriteLine();

            Console.WriteLine("Array2");
            foreach (int nubmer in array2)
            {
                Console.Write($"{nubmer} ");
            }

            Console.WriteLine();
            Console.WriteLine("Dog Array");
            Dog[] dogArray = new Dog[3];
            dogArray[0] = new Dog("Mickey", "Golden Retriever");
            dogArray[1] = new Dog("Azor", "Doberman");
            dogArray[2] = new Dog("Burek", "Jack Russel Terrier");

            Dog westieDog = new Dog("Skiper", "WHWT");
            Dog dobermanDog = new Dog("Miso", "Doberman");
            Dog[] dogArray2 = {westieDog, dobermanDog, new Dog("Jack", "Husey")}; 

            foreach(Dog dog in dogArray)
            {
                dog.Present();
                dog.Bark();
            }

            Console.WriteLine("Dog Array2");
            foreach (Dog dog in dogArray2)
            {
                dog.Present();
                dog.Bark();
            }
        }

        public static void RunLists()
        {
            //var - can be any type, it is used in methods (not usable for declaring class properties)
            var dog1 = new Dog("Mickey", "Golden Retriever");
            var dog2 = new Dog("Azor", "Doberman");
            var dog3 = new Dog("Burek", "Jack Russel Terrier");
            var dog4 = new Dog("Jack", "Husky");

            //List<ListElementClass> listaName = new List<ListElementCalss>()
            //List<Dog> dogs = new List<Dog>();
            var dogs = new List<Dog>();

            Console.WriteLine($"List Size: {dogs.Count}");
            dogs.Add(dog2);
            Console.WriteLine($"List Size: {dogs.Count}");
            dogs.Add(dog3);
            Console.WriteLine($"List Size: {dogs.Count}");
            dogs.Add(dog1);
            Console.WriteLine($"List Size: {dogs.Count}");
            dogs.Add(dog4);
            Console.WriteLine($"List Size: {dogs.Count}");
            dogs.Remove(dog2);
            Console.WriteLine($"List Size: {dogs.Count}");

            foreach(var dog in dogs)
            {
                dog.Present();
            }

        }
    }
}
