using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double a, b;
                string c;



                Console.WriteLine("Выберите операцию:  1 - Сложение  2 - Вычитание 3 - Умножение 4 - Деление  5 - Возведение в степень 6 - Квадратный корень  7 - 1% от числа  8 - Факториал  9 - Выход из программы");

                c = Console.ReadLine();


                if (c == "1")
                {
                    Console.WriteLine("Введите первое число");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine(a + b);
                }
                else if (c == "2")
                {
                    Console.WriteLine("Введите первое число");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine(a - b);
                }

                else if (c == "3")
                {
                    Console.WriteLine("Введите первое число");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    b = double.Parse(Console.ReadLine());
                   
                    Console.WriteLine(a * b);
                }

                else if (c == "4")
                {
                    Console.WriteLine("Введите первое число");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    b = double.Parse(Console.ReadLine());

                    if (b == 0)
                        Console.WriteLine("Ошбика");
                    else
                        Console.WriteLine(a / b);
                }

                else if (c == "5")
                {
                    Console.WriteLine("Введите первое число");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine (Math.Pow(a, b));
                }
                else if (c == "6")
                {
                    Console.WriteLine("Введите число");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine (Math.Sqrt(a));
                }
                else if (c == "7") 
                {
                    Console.WriteLine("Введите число");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Round((double)(a/100)));
                }
                else if (c == "8")
                {
                    Console.WriteLine("Введите число");
                    a = double.Parse(Console.ReadLine());
                    double n = a;  //количество циклов в факториале
                    double factorial = 1;   // значение факториала

                    for (double i = 2; i <= n; i++) // цикл начинаем с 2, т.к. нет смысла начинать с 1
                    {
                        factorial = factorial * i;
                    }
                }


                else if (c == "9")
                {
                    Console.WriteLine("Выход из программы");
                    break;
                }
                else
                {
                    Console.WriteLine("Операция не найдена");
                }
                Console.ReadLine(); 

            }
        }
    }
}
