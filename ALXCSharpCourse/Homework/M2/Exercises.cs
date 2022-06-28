using ALXCSharpCourse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Homework.M2
{
    public class Exercises
    {
        public void Vol1()
        {
            string name = "Fabian";
            string surname = "Naumiuk";
            int age = 23;
            double height = 1.86;
            string sex = "male";
            string pesel = "99999999999";
            Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}[m], Sex: {sex}, PESEL: {pesel}");
        }

        public void Vol2()
        {
            string name = "Fabian";
            string surname = "Naumiuk";
            int age = 23;
            double height = 1.86;
            string sex = "male";
            string pesel = "99999999999";
            Console.WriteLine($"Name: {name}, Age: {age}, Height: {(int)height}[m], Sex: {sex}, PESEL: {pesel}");
        }

        public void Vol3()
        {
            DayOfWeek day = DayOfWeek.Tuesday;
            Months month = Months.JUNE;
            Console.WriteLine($"Today is {day}, month: {month}, year: 2022");
        }
    }
}
