using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string c;
                Console.WriteLine("Выберите операцию:  1 - Угадай число  2 - Таблица умножения 3 - Делитель 4 - Выход" );

                c = Console.ReadLine();

                if (c == "1")
                {
                    Console.WriteLine("Угадай число от 0 до 100");
                    Random rand = new Random();
                    int numb;
                    int secret = rand.Next(0, 100);
                    while (true)
                    {
                        numb = int.Parse(Console.ReadLine());
                        if (numb == secret)
                        {
                            Console.WriteLine("Число угадано!!! УРАААА!!1!!11!");
                            break;
                        }
                        else
                        {
                            if (numb > secret)
                            {
                                Console.WriteLine("Меньше");
                            }
                            else
                            {
                                Console.WriteLine("Больше");
                            }
                        }
                    }
                }
                else if (c == "2")
                {
                    Console.WriteLine("Таблица умножения");
                    int[,] umnozh = new int[,]
                    {
                        {1, 2, 3, 4, 5, 6, 7, 8, 9 },
                        {1, 2, 3, 4, 5, 6, 7, 8, 9 },
                        {1, 2, 3, 4, 5, 6, 7, 8, 9 },
                        {1, 2, 3, 4, 5, 6, 7, 8, 9 },
                        {1, 2, 3, 4, 5, 6, 7, 8, 9 },
                        {1, 2, 3, 4, 5, 6, 7, 8, 9 },
                        {1, 2, 3, 4, 5, 6, 7, 8, 9 },
                        {1, 2, 3, 4, 5, 6, 7, 8, 9 },
                        {1, 2, 3, 4, 5, 6, 7, 8, 9 },

                    };
                    for (int i = 1; i <= 10; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            Console.Write(i * j + "\t");
                        }
                        Console.WriteLine();
                    }


                        
                }
                else if (c == "3")
                {

                    Console.Write("Введите число ");
                    int num = int.Parse(Console.ReadLine());
                    
                    int i = 1;
                    while (i <= num)
                    {
                        i++;
                        if (num % i == 0)
                            Console.WriteLine(" {0} / {1}", num, i);
                    }


                }
                else if (c == "4")
                {
                    Console.WriteLine("Выход");
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
