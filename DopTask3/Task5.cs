// Формируется массив из n целых случайных числет от 10 до 99
//Выводится исходный массив и их количество
using System;

namespace DopTask3
{
    internal class Task5
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
                int num = new Random().Next(10, 100);
                mass[mesto] = num;
                mesto++;
            }
            PrintMass("Введённый массив =", mass);
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] % 2 == 1)
                {
                    Console.WriteLine($"Нечетные числа = {mass[i]} ");
                    coll++;
                }

            }
            Console.WriteLine();
            Console.Write($"Всего нечётных в массиве = {coll}");//это область самого обычного кода аля

        }
    }
}
