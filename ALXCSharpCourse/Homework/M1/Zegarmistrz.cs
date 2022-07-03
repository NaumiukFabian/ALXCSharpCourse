using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.M1
{
    public class Zegarmistrz
    {
        public static void UstawZadanaGodzineNaZegarku(Zegar zegarek, int zadanaGodzina, int zadanaMinuta)
        {
            zegarek.Godzina = zadanaGodzina;
            zegarek.Minuta = zadanaMinuta;
        }
    }
}
