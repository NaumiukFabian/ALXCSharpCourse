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

        public void Vol4()
        {
            int a = 3;
            int b = 6;
            int c = 15;
            double wynik;
            wynik = ((double)(a ^ 2) / 2) % c;
            bool cond;
            cond = a > wynik;
            Console.WriteLine(cond);
        }
        public void vol5()
        {
            //1 prawo
            bool p;
            bool q;
            bool wynik;
            p = true;
            q = true;
            wynik = ((!(p && q)) == ((!p) || (!q)));
            Console.WriteLine(wynik);

            bool p1;
            bool q1;
            bool wynik1;
            p1 = true;
            q1= false;
            wynik1 = ((!(p1 && q1)) == ((!p1) || (!q1)));
            Console.WriteLine(wynik1);

            bool p2;
            bool q2;
            bool wynik2;
            p2 = false;
            q2 = true;
            wynik2 = ((!(p2 && q2)) == ((!p2) || (!q2)));
            Console.WriteLine(wynik2);

            bool p3;
            bool q3;
            bool wynik3;
            p3 = false;
            q3 = false;
            wynik3 = ((!(p3 && q3)) == ((!p3) || (!q3)));
            Console.WriteLine(wynik3);

            //2 prawo
            bool p4;
            bool q4;
            bool wynik4;
            p4 = true;
            q4 = true;
            wynik4 = ((!(p4 || q4)) == ((!p4) && (!q4)));
            Console.WriteLine(wynik4);

            bool p5;
            bool q5;
            bool wynik5;
            p5 = true;
            q5 = false;
            wynik5 = ((!(p5 || q5)) == ((!p5) && (!q5)));
            Console.WriteLine(wynik5);

            bool p6;
            bool q6;
            bool wynik6;
            p6 = false;
            q6 = true;
            wynik6 = ((!(p6 || q6)) == ((!p6) && (!q6)));
            Console.WriteLine(wynik6);

            bool p7;
            bool q7;
            bool wynik7;
            p7 = false;
            q7 = false;
            wynik7 = ((!(p7 || q7)) == ((!p7) && (!q7)));
            Console.WriteLine(wynik7);
        }

        public void vol6()
        {
            Console.WriteLine("Enter value of purchas");
            double purchasValue = Convert.ToDouble(Console.ReadLine());

            if (purchasValue > 100)
            {
                double wynik = purchasValue * 0.85;
                Console.WriteLine(wynik);
            }

            else if((purchasValue < 100) && (purchasValue > 60))
            {
                double wynik = purchasValue * 0.95;
                Console.WriteLine(wynik);
            }

            switch(purchasValue)
            {
                case >100:
                    double wynik = purchasValue * 0.85;
                    Console.WriteLine(wynik);
                    break;
                case  >60:
                    double wynik1 = purchasValue * 0.95;
                    Console.WriteLine(wynik1);
                    break;
                default:
                    Console.WriteLine("default");
                        break;
            }
                
            
        }
    }
}
