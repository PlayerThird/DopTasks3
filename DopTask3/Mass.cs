using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem5
{
    internal class Mass
    {
        // // Создание и вывод массива

        public static int[] CreateRandomArray(int N, int start, int end)
        {
            int[] RandomArray = new int[N];
            for (int i = 0; i < N; i++)
            {
                RandomArray[i] = new Random().Next(start, end + 1);
            }
            return RandomArray;
        }
        //Создание массива
        public static int[] CreateArray()
        {
            Console.WriteLine("Введите количество элементов массива");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент массива");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }
        //Печать массива
        public static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
