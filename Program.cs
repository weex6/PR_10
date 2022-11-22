using System;

namespace PR_10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                {
                    Console.Clear();
                    Console.WriteLine("Практическая работа № 10");
                    Console.Write("Введите размер матрицы: ");
                    int size = Convert.ToInt32(Console.ReadLine()); //вводим размер массив
                    int[,] a = new int[size, size];
                    Console.WriteLine("Введите элементы массива: ");
                    for (int i = 0; i < size; i++) // перебор по строкам
                    {
                        for (int j = 0; j < size; j++) // перебор по столбцам
                        {
                            Console.WriteLine($"Введите [{i},{j}] значение массива: ");
                            a[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine();
                    }

                    int min = a[0, 0];
                    for (int i = 0; i < size; i++) // поиск минимального по модулю элемента главной дигонали
                    {
                        if (Math.Abs(a[i, i]) < Math.Abs(min))
                            min = a[i, i];
                    }

                    for (int i = 0; i < size; i++)
                    {
                        a[i, i] = min;
                    }

                    for (int i = 0; i < size; i++) // замена елементов выше гл. диагонали на 1
                    {
                        for (int j = 0; j < size; j++)
                        {
                            if (j > i)
                                a[i, j] = 1;
                        }
                    }

                    for (int i = 0; i < size; i++) // замена елементов ниже гл. диагонали на 2
                    {
                        for (int j = 0; j < size; j++)
                        {
                            if (j < i)
                                a[i, j] = 2;
                        }
                    }

                    //ВЫВОД ИТОГОВОГО МАССИВА
                    Console.WriteLine($"Массив: ");
                    for (int i = 0; i < size; i++) // перебор по строкам
                    {
                        for (int j = 0; j < size; j++) // перебор по столбцам
                        {
                            Console.Write(a[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            catch (System.FormatException fe)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Исключение: {fe.Message}");
            }
            catch (IndexOutOfRangeException io)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Исключение: {io.Message}");
            }
        }
    }
}
