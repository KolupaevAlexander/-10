using System;

namespace ConsoleApp1
{
    class Program
    {
        //Задания 1-3
        static void PrintDoubleArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                    Console.Write($"{array[j, i]} ");
                Console.WriteLine();
            }
        }
        static void Task1()
        {
            try
            {
                Console.Write("Введите кол-во сотрудников ");
                int workerCount = Int32.Parse(Console.ReadLine());
                Console.Write("Введите кол-во рабочих месяцов ");
                int mounthCount = Int32.Parse(Console.ReadLine());
                double[,] salary = new double[mounthCount, workerCount];
                DateTime[] birthdays = new DateTime[workerCount];

                for (int i = 0; i < mounthCount; i++)
                    for (int j = 0; j < workerCount; j++)
                    {
                        Console.Write($"Введите зарплату {j + 1} сотрудника за {i + 1} месяц ");
                        salary[i, j] = Double.Parse(Console.ReadLine());
                    }

                for (int i = 0; i < birthdays.Length; i++)
                {
                    Console.Write($"Введите дату рождения {i + 1} сотрудника ");
                    birthdays[i] = DateTime.Parse(Console.ReadLine());
                }
                Console.Write("Вывод в виде таблицы ");
                PrintDoubleArray(salary);

                //Задание 2
                Console.Write("Наибольшее значение заработной платы работника №2");
                Console.WriteLine(Task2(salary));
            }
            catch
            {
                Console.Write("Неверный формат данных ");
            }
        }
        static double Task2(double[,] array)
        {
            double max = array[0, 1];
            for (int i = 1; i < array.GetLength(0); i++)
                if (max < array[i, 1]) max = array[i, 1];
            return max; 
        }

        //Задание 4
        static void Task4()
        {
            try
            {
                Console.WriteLine("Введите год");
                int year = Int16.Parse(Console.ReadLine());
                DateTime date = new DateTime(year, 1, 1);
                int Count = 0;
                while (date.Year == year)
                {
                    if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        Count++;
                    }
                    date = date.AddDays(1.0);
                }
                Console.WriteLine("Кол-во рабочих дней в " + year + " году: {0} ", DateTime.IsLeapYear(year) ? 366 - Count : 365 - Count);
                Console.WriteLine("Кол-во выходных в " + year + " году: {0} ", Count);
            }
            catch
            {
                Console.Write("Неверный формат данных ");
            }
        }

        //Задание 5
        static void Task5()
        {
            try
            {
                Console.Write("Введите возраст ");
                uint year = UInt32.Parse(Console.ReadLine());

                if (9 < year % 100 && year % 100 < 16)
                    Console.Write($"{year} лет");
                else
                    switch (year % 10)
                    {
                        case 1:
                            Console.Write($"{year} год");
                            break;
                        case 2:
                        case 3:
                        case 4:
                            Console.Write($"{year} года");
                            break;
                        default:
                            Console.Write($"{year} лет");
                            break;
                    }
            }
            catch
            {
                Console.Write("Неверный формат данных ");
            }
        }

        //Задание 6
        static void Task6()
        {
            try
            {
                string[] mounths = new string[] { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
                Console.Write("Введите число ");
                int day = Int32.Parse(Console.ReadLine());
                Console.Write("Введите месяц ");
                int mounth = Int32.Parse(Console.ReadLine());

                Console.WriteLine($"{day} {mounths[mounth - 1]}");
            }
            catch
            {
                Console.Write("Неверный формат данных ");
            }
        }
        static void Main(string[] args)
        {
            //Задания 1-3
            //Task1();

            //Задание 4
            //Task4();

            //Задание 5
            //Task5();

            //Задание 6
            //Task6();
            Console.ReadKey();
        }
    }
}
