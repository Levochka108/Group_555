﻿/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int[,] array = new int[4, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        sum += array[i, j];
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine($"    {sum}");
}

int countLine = 1;

int min = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    min += array[0, i];
}

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    if (sum < min)
    {
        min = sum;
        countLine = i + 1;
    }
}
Console.WriteLine();
Console.Write($"Номер стороки с наименьшей суммой элементов: {countLine}");