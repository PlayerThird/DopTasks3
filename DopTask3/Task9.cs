//Заданы массивы названий и обозначений транспортных средств, а также
//их скоростей, например: a - автомобиль, 70 км/ч; v - велосипед, 12 км/ч;
//m - мотоцикл, 60 км/ч; p - поезд, 90 км/ч; s - самолёт, 800 км/ч
//По введенному обозначения транспортного средства
//выводится его название и скорость
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopTask3
{
    internal class Task9
    {
        internal static void Start()
        {
            string[] name = { "avto", "velik", "moto", "parovoz", "plane" };
            int[] speed = { 70, 12, 60, 90, 800 };
            Console.WriteLine("Введите название транспорта: " +
                "\r\n a - автомобиль," +
                "\r\nv - велосипед," +
                "\r\nm - мотоцикл," +
                "\r\np - поезд, " +
                "\r\ns - самолёт, ");
            string search = Console.ReadLine();
            MarkSpeed(search);




            void MarkSpeed(string search)
            {
                switch (search)
                {
                    case "a":
                        PrintSpeed(name, speed, 0); break;
                    case "v":
                        PrintSpeed(name, speed, 1); break;
                    case "m":
                        PrintSpeed(name, speed, 2); break;
                    case "p":
                        PrintSpeed(name, speed, 3); break;
                    case "s":
                        PrintSpeed(name, speed, 4); break;
                    default:
                        Console.WriteLine("Такого тут нет, попробуй еще раз");
                        Console.ReadLine();
                        Start();
                        break;
                }
            }



            void PrintSpeed(string[] name, int[] speed, int namepoz)
            {
                Console.WriteLine($"Speed {name[namepoz]} = {speed[namepoz]}");
            }



        }
    }
}
