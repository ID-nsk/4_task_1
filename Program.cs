using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа вычисляет квадраты всех целых чисел от 1 до N");
            // Ввод данных
            Console.WriteLine("Введите число N");
            int N = Convert.ToInt32(Console.ReadLine());
            // Решение
            if (N >= 1)
            {
                int pow = 1;
                for (int n = 1, i = 0; N + 1 > n; i = pow, n++)
                {
                    pow = i + 2 * n - 1;
                    Console.WriteLine("Квадрат числа {0} равен {1}", n, pow);
                }
                Console.WriteLine("Для выхода нажмите любую клавишу");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Введенное значение вне диапазона");
                Console.WriteLine("Для выхода нажмите любую клавишу");
                Console.ReadKey();
            }
        }
    }
}