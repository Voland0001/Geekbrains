﻿// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

static void Foundindex(int[,] inputArray)
{
    int rows = inputArray.GetLength(0);
    int cols = inputArray.GetLength(1);

    for (int j = 0; j < cols; j++)
    {
        float colAvg = 0;
        for (int i = 0; i < rows; i++)
        {                  
            colAvg += inputArray[i,j];
        }
        colAvg = colAvg / rows;
        Console.Write("Average of cols {0} is :{1}", j,colAvg);         
    }
}

Console.WriteLine("Введите количество строк (m): ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (n): ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное число элемента массива: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число элемента массива: ");
int max = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, min, max);
Console.WriteLine();
PrintArray(myArray);
Console.WriteLine();
Foundindex(myArray);






