// Формируется массив из n натуральных нечетных чисел
//Выводится исходный массив из n натуральных нечетных чисел
using System;

namespace DopTask3
{
    internal class Task4
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
            Console.WriteLine("Введите размер массива");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[size];
            int mesto = 0;
            int coll = 0;
            foreach (int item in mass)
            {
                int num = Checker.CheckInput<int>(x => x % 2 == 0, $"Введите {mesto + 1} элемент", "Введите НЕчётное число(Enther для продолжения)");

                mass[mesto] = num;
                mesto++;
            }
            PrintMass("Введённый массив =", mass);
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] % 3 == 0)
                {
                    Console.WriteLine($"Кратное 3 = {mass[i]} ");
                    coll++;
                }

            }
            Console.WriteLine();
            Console.Write($"Всего кратных 3м в массиве = {coll}");
        }
    }
}
