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

        public void vol7()
        {
            int[] id = { 1, 2, 3, 4, 5 };
            double[] price = { 3.58, 9.61, 8.52, 10.25, 6.17 };
            double[] vat = { 1.05, 1.05, 1.08, 1.08, 1.23 };
            int[] numberOfPieces = { 10, 25, 18, 36, 4 };
            int[] numberOfBoxes = { 2, 5, 3, 6, 1 };

            for(int i = 0; i < id.Length; i++)
            {
                double priceWithVat = price[i] * vat[i];
                Console.WriteLine(String.Format("{0:N2}",priceWithVat) + "zł");
            }

            for( int i = 0; i < id.Length; i++)
            {
                double valueOfStorage = price[i] * vat[i] * numberOfPieces[i] * numberOfBoxes[i];
                Console.WriteLine(String.Format("{0:N2}", valueOfStorage) + "zł");
            }
        }

        public void vol8()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= number; i++)
            {
                if(number%i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void vol9()
        {
            string[] product = { "product1", "product2", "product3", "product4" };
            int[] priceBrutto = { 100, 150, 200, 250 };
            Console.WriteLine("Chose product - 1, 2, 3 or 4");
            int check;
            bool numberOfProduct = Int32.TryParse(Console.ReadLine(), out check);
            string q = "";

            if(numberOfProduct)
            {
                do
                {
                    
                    switch (check)
                    {
                        case 1:
                            Console.WriteLine($"{product[check - 1]}");
                            Console.WriteLine($"Brutto price - {priceBrutto[check - 1]}, Netto price - {((double)priceBrutto[check - 1]) * 0.77}");
                            Console.WriteLine("If tou want quit press q, if don't press anything other");
                            q = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine($"{product[check - 1]}");
                            Console.WriteLine($"Brutto price - {priceBrutto[check - 1]}, Netto price - {((double)priceBrutto[check - 1]) * 0.77}");
                            Console.WriteLine("If tou want quit press q, if don't press anything other");
                            q = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine($"{product[check - 1]}");
                            Console.WriteLine($"Brutto price - {priceBrutto[check - 1]}, Netto price - {((double)priceBrutto[check - 1]) * 0.77}");
                            Console.WriteLine("If tou want quit press q, if don't press anything other");
                            q = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine($"{product[check - 1]}");
                            Console.WriteLine($"Brutto price - {priceBrutto[check - 1]}, Netto price - {((double)priceBrutto[check - 1]) * 0.77}");
                            Console.WriteLine("If tou want quit press q, if don't press anything other");
                            q = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("default");
                            break;

                    }
                    
                    if(q != "q")
                    {
                        Console.WriteLine("Chose product - 1, 2, 3 or 4");
                        check = Convert.ToInt32(Console.ReadLine());
                    }
                    
                }
                while (q != "q");
                
            }
            else
            {
                Console.WriteLine("Is not 1,2,3,4");
            }
        }

        public void vol10()
        {
            int[,] matrix = new int[3,3];

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Enter a[{i},{j}]");
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for(int j = 0; j < 3; j++)
            {
                Console.WriteLine();
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(matrix[j, i]);
                }
            }


        }

        public void vol11()
        {
            int[] table = new int[5];
            int[] table1 = new int[5];
            const int x = 5;

            for( int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter {i + 1} number");
                table[i] = Convert.ToInt32(Console.ReadLine());
                table1[i] = table[i] + x;
            }

            Console.WriteLine("Your nubmers + 5");
            foreach(int number in table1)
            {
                Console.WriteLine(number);
            }
        }


    }
}
