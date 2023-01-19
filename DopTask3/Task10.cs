//По введенному порядковому номеру месяца и дате выводится:
//название месяца, кол-во дней в нём, кол-во дней, оставшихся
//до конца текущего месяца, название следущего месяца
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DopTask3
{
    internal class Task10
    {
        internal static void Start()
        {
            DateTime moment = new DateTime(2023, 1, 13, 3, 57, 32, 11);
            // Year gets 1999.
            int year = moment.Year;

            // Month gets 1 (January).
            int month = moment.Month;

            // Day gets 13.
            int day = moment.Day;

            // Hour gets 3.
            int hour = moment.Hour;

            // Minute gets 57.

            int minute = moment.Minute;

            // Second gets 32.
            int second = moment.Second;

            // Millisecond gets 11.
            int millisecond = moment.Millisecond;
            Console.WriteLine("Дата = ", year, month, day, hour);
        }
    }
}
