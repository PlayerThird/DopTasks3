// Заданы диагонали мониторов в дюймах
// 10.1, 11.6, 14, 15.6, 17, 19, 24, 27
//Формируется и выводится таблица перевода диагонаей в сантиметры
//Разделите значение "Длина" на 2,54 сантиметр 2,54 = 1 дюйм
using System;

namespace DopTask3
{
    internal class Task2
    {
        internal static void Start()
        {
            
            double[] Dujm = { 10.1, 11.6, 14, 15.6, 17, 19, 24, 27 };
            double[] Santi = new double[8];

            void PrintMass(string text, double[] mass)
            {
                Console.Write(text + " ");
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.Write($"{mass[i]} ");
                }
                Console.WriteLine();
            }
            PrintMass(string.Empty, Dujm);

            PrintMass(string.Empty, Santi);

            for (int i = 0; i < 8; i++)
            {
                Santi[i] = Dujm[i] * 2.54;
            }
            PrintMass("Дюйм равен =", Dujm);

            PrintMass("Сантиметры равны =", Santi);
        }
    }
}
