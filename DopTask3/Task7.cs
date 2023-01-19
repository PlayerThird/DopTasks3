//Формируется массив из n целых случайных чисел от -40 до 40
//Выводятся нечетные отрицательные числа и их к-во
using Sem5;
using System;

namespace DopTask3
{
    internal class Task7
    {
        internal static void Start()
        {
            int size = Checker.CheckInput<int>(x => x < 0, "Введите размер массива", "Введите положительный размер");
            int[] array = Mass.CreateRandomArray(size, -40, 41);
            Mass.ShowArray(array);
            int nech = 0;
            foreach (int item in array)
            {
                if (item % 2 == -1 && item < 0)
                {
                    Console.WriteLine($"Нечётное, отрицательное число = {item}");
                    nech++;
                }
            }
            Console.WriteLine($"Кол-во нечетных, отрицательных чисел = {nech}");
        }
    }
}
