// Задан массив дней недели. По введеному порядковому номеру
//выводится название дня недели и количество дней до Вс
using System;

namespace DopTask3
{
    internal class Task1
    {
        internal static void Start()
        {
            
        
            int DayOfWeek = Checker.CheckInput<int>(x => x < 1 || x > 7, "Введите день недели 1-7:", "Вы вышли ЗА неделю!");
            //проверяемя на условие, что не выходит за пределы недели

            string[] DayInWeek = { "Пон", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
            void PrintDay(string[] Week, int Day)
            {
                Console.WriteLine($"День = {Day}, День недели {Week[Day - 1]}, Дней до Вс = {7 - Day}");
            }
            PrintDay(DayInWeek, DayOfWeek);
        }
    }
}
