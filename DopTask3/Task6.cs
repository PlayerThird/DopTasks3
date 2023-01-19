//Формируется массив из n целых случайных чисел от -50 до 50
//Массив упорядочивается. Выводятся числа в интервале от -20 до 20
using System;
using System.Linq;

namespace DopTask3
{
    internal class Task6
    {
        internal static void Start()
        {
            void PrintMass(string text, int[] mass)
            {
                Console.Write(text + " ");
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.Write($"{mass[i]} ");
                }
                Console.WriteLine();
            }
            Console.Clear();
            int size = Checker.CheckInput<int>(x => x <= 0, "Введите размер массива", "Введите положительный размер");
            int[] mass = new int[size];
            for (int i = 0; i < size; i++)
            {
                mass[i] = new Random().Next(-50, 51);
            }

            PrintMass("Введённый массив =", mass);
            mass = mass.OrderBy(x => x).ToArray();//OrderBy сортирует по возрастанию. ToArray (превращает)приводит к типу Массив
            PrintMass("Остортированный массив =", mass);
            mass = mass.Where(x => x >= -20 && x <= 20).ToArray();
            PrintMass("Отфильтрованный массив =", mass);
            //mass.OrderByDescending(x => x).ToArray();//OrderByDescending сортирует по убыванию.

        }
    }
}
