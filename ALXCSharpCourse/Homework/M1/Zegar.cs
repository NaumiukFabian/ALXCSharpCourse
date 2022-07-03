using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.M1
{
    public class Zegar
    {
        public int Godzina = 12;
        public int Minuta = 45;

        public string ZwrocUstawionaGodzine()
        {
            return Godzina.ToString() + ":" + Minuta.ToString();
        }
    }
}
