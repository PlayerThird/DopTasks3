// Формируется массив из 7 целых двузначных чисел путём ввода с клавиатуры
//Выводтся этот массив, чётные числа и их количество (for, foreach)
using System;

namespace DopTask3
{
    internal class Task3
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
            Console.WriteLine("Заполните массив 2х значными числами(Enther для продолжения)");
            Console.ReadLine();
            int[] mass = new int[7];
            int mesto = 0;
            int coll = 0;
            foreach (int item in mass)
            {
                int num = Checker.CheckInput<int>(x => x / 10 == 0 || x / 10 > 10, $"Введите {mesto + 1} элемент", "Введите 2х значное число(Enther для продолжения)");

                mass[mesto] = num;
                mesto++;
            }
            PrintMass("Введённый массив =", mass);
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] % 2 == 0)
                {
                    Console.Write($"Чётное = {mass[i]} ");
                    coll++;
                }

            }
            Console.WriteLine();
            Console.Write($"Всего чётных в массиве = {coll}");
        }
    }
}
