//Формируется массив из n целых случайных чисел от -50 до 50
//Выводятся положительные числа в порядке убывания и их количество
using Sem5;
using System;
using System.Linq;

namespace DopTask3
{
    internal class Task8
    {
        internal static void Start()
        {
            int size = Checker.CheckInput<int>(x => x < 0, "Введите размер массива", "Введите положительный размер");
            int[] array = Mass.CreateRandomArray(size, -50, 51);
            Mass.ShowArray(array);
            array = array.OrderBy(x => x).ToArray();
            Mass.ShowArray(array);
            int summ = 0;
            foreach (int item in array)
            {
                if (item > 0)
                {
                    Console.WriteLine($"Положительное число = {item}");
                    summ++;
                }
            }
            Console.WriteLine($"Всего положительных чисел = {summ}");
        }
    }
}
