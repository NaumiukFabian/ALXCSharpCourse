using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demos
{
    public class Tree
    {
        public string KindOfTree { get; set; }
        public int SizeOfTree { get; set; }


        public void Photosynthesis()
        {
            Console.WriteLine("Oxygen is in prodution");
        }

        public void YourTree()
        {
            Console.WriteLine($"Your tree is a {SizeOfTree} meters {KindOfTree} tree");
        }

        public void ChangeTree()
        {
            Console.WriteLine("What kind of tree do you see?");
            KindOfTree = Console.ReadLine();
            Console.WriteLine("What size has that tree?[m]");
            SizeOfTree = Convert.ToInt32(Console.ReadLine());
        }
    }
}
