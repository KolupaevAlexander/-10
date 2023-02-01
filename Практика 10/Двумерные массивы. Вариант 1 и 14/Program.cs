using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {   
        //Задание 1
        static void PrintArray(int[,] array)//Вывод массива в консоль
        {
            for (int i = 0; i < array.GetLength(0); i++)
            { 
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write($"{array[i, j]} ");
                Console.WriteLine();
            }
        }
        static int FindMax(int[,] array)//Поиск максимального элемента в двумерном массиве
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    if (max < array[i, j]) max = array[i,j];

            return max;
        }
        static int GetSum(int[,] array)//Вычисление суммы элементов двумерного массива
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    sum+=array[i,j];

            return sum;
        }
        static int GetMultiply(int[,] array)//Вычисление произведения элементов двумерного массива
        {
            int multiply = 1;
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    multiply *= array[i, j];

            return multiply;
        }
        static void Task1()
        {
            int[,] array = new int[4, 3];

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    if (i < 3) array[i, j] = i + 1;
                    else array[i, j] = 3;

            Console.WriteLine($"Полученный массив");
            PrintArray(array);

            Console.WriteLine($"\nЗадания по данному массиву");
            Console.WriteLine($"Максимальный элемент массива - {FindMax(array)}");
            Console.WriteLine($"Сумма элементов массива - {GetSum(array)}");
            Console.WriteLine($"Произведение элементов массива - {GetMultiply(array)}");
        }

        //Задание 14
        static int[,] FillTrain(int carriages, int places)
        {
            int[,] tickets = new int[carriages, places];
            Random rand = new Random();
            for (int i = 0; i < carriages; i++)
                for (int j = 0; j < places; j++)
                    tickets[i, j] = rand.Next(0, 2);
            return tickets;
        }

        static int CountFreePlaces(int[,] tickets, int numberOfCarriage, int places)
        {
            int counter = 0;
            for (int i = 0; i < places; i++)
                if (tickets[numberOfCarriage-1, i] == 0) counter++;
            return counter;
        }
        static void Task14()
        {
            try
            {
                int carriages = 10;
                int places = 36;
                int[,] tickets = FillTrain(carriages, places);
                Console.WriteLine("Случайно сгенерированный случай");
                PrintArray(tickets);

                Console.WriteLine("Введите номер вагона");
                int number = Int32.Parse(Console.ReadLine());

                Console.WriteLine($"Кол-во свободных мест {CountFreePlaces(tickets, number, places)}");
            }
            catch 
            {
                Console.WriteLine("Неверный ввод");
            }
            

        }
        static void Main(string[] args)
        {
            //Task1();
            //Task14();

            Console.ReadLine();
        }
    }
}
