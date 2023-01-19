using System;

namespace DopTask3
{
    internal class Switcher
    {
        internal static void Start()
        {
            int y = Checker.CheckInput<int>(x => x < 0 && x > 10, "Введите номер программы: ", "Такой программы нет");
            bool check = false;
            switch (y)
            {
                case 1:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    Task1.Start();
                    break;
                case 2:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    Task2.Start();
                    break;
                case 3:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    Task3.Start();
                    break;
                case 4:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    Task4.Start();
                    break;
                case 5:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    Task5.Start();
                    break;
                case 6:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    Task6.Start();
                    break;
                case 7:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    Task7.Start();
                    break;
                case 8:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    Task8.Start();
                    break;
                case 9:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    Task9.Start();
                    break;
                case 10:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    Task10.Start();
                    break;
                default:
                    Console.WriteLine("Такой программы нет");
                    Console.ReadLine();
                    CheckContinue(check);
                    break;
            }

            bool UnlockTasks()
            {
                bool check = false;
                Console.WriteLine("Это та программа, которая вам нужна?( + или - )");
                string answer = Console.ReadLine();
                string v = "+";
                if (answer == v)
                {
                    check = true;
                }
                return check;
            }
            void DiscriptionTasks(int y)
            {
                switch (y)
                {
                    case 1:
                        Console.WriteLine("Задан массив дней недели. По введеному порядковому номеру" +
                            "\r\nвыводится название дня недели и количество дней до Вс");
                        break;
                    case 2:
                        Console.WriteLine("// Заданы диагонали мониторов в дюймах" +
                            "\r\n// 10.1, 11.6, 14, 15.6, 17, 19, 24, 27\r\n//Формируется и выводится таблица перевода диагонаей в сантиметры\r\n//Разделите значение \"Длина\" на 2,54 сантиметр 2,54 = 1 дюйм");
                        break;
                    case 3:
                        Console.WriteLine("// Формируется массив из 7 целых двузначных чисел путём ввода с клавиатуры" +
                            "\r\n//Выводтся этот массив, чётные числа и их количество (for, foreach)");
                        break;
                    case 4:
                        Console.WriteLine("// Формируется массив из n натуральных нечетных чисел" +
                            "\r\n//Выводится исходный массив из n натуральных нечетных чисел");
                        break;
                    case 5:
                        Console.WriteLine("// Формируется массив из n целых случайных числет от 10 до 99" +
                            "\r\n//Выводится исходный массив и их количество");
                        break;
                    case 6:
                        Console.WriteLine("//Формируется массив из n целых случайных чисел от -50 до 50" +
                            "\r\n//Массив упорядочивается. Выводятся числа в интервале от -20 до 20");
                        break;
                    case 7:
                        Console.WriteLine("//Формируется массив из n целых случайных чисел от -40 до 40" +
                            "\r\n//Выводятся нечетные отрицательные числа и их к-во");
                        break;
                    case 8:
                        Console.WriteLine("//Формируется массив из n целых случайных чисел от -50 до 50" +
                            "\r\n//Выводятся положительные числа в порядке убывания и их количество");
                        break;
                    case 9:
                        Console.WriteLine("//Заданы массивы названий и обозначений транспортных средств, а также" +
                            "\r\n//их скоростей, например: a - автомобиль, 70 км/ч; v - велосипед, 12 км/ч;" +
                            "\r\n//m - мотоцикл, 60 км/ч; p - поезд, 90 км/ч; s - самолёт, 800 км/ч" +
                            "\r\n//По введенному обозначения транспортного средства" +
                            "\r\n//выводится его название и скорость");
                        break;
                    case 10:
                        Console.WriteLine("//По введенному порядковому номеру месяца и дате выводится:" +
                            "\r\n//название месяца, кол-во дней в нём, кол-во дней, оставшихся" +
                            "\r\n//до конца текущего месяца, название следущего месяца");
                        break;
                }
            }

            void CheckContinue(bool check)
            {
                if (check == false)
                {
                    Start();
                }
            }


        }
    }
}
