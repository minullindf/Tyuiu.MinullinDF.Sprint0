﻿using System.ComponentModel.Design;
using Tyuiu.MinullinDF.Sprint0.Task7.V0.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        string zv = new string('*', 75);

        Console.Title = "Спринт #0 | Выполнил: Минуллин Д. Ф. | АСОиУБ-25-1";
        Console.WriteLine(zv);
        Console.WriteLine("* Спринт #0                                                               *");
        Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #0                                                              *");
        Console.WriteLine("* Выполнил: Минуллин Динар Фаатович | АСОиУБ-25-1                            *");
        Console.WriteLine(zv);
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
        Console.WriteLine("* одиныковых массивов по длинне.                                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine(zv);
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine(zv);

        // место решения
        int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Значения массива №1");
        for (int i = 0; i < arrayNums1.Length; i++)
        {
            Console.Write(arrayNums1[i] + ",");
        }
        Console.WriteLine();

        int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Значения массива №2");
        for (int i = 0; i < arrayNums2.Length; i++)
        {
            Console.Write(arrayNums2[i] + ",");
        }

        Console.WriteLine();
        Console.WriteLine(zv);
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine(zv);

        if (arrayNums1.Length == arrayNums2.Length)
        {
            int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

            Console.WriteLine("Сумма элементов массива равна");
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write(resultArray[i] + ",");
            }
        }
        else 
        {
            Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов");
        }
        Console.ReadKey();    
    }
}