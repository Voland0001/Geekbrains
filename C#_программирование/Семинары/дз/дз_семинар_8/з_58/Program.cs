// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] getArray(int m, int minValue, int maxValue)
{
    int[,] result = new int[m, m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void printArray(int[,] array)
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

int[,] productArray(int[,] firstArray, int[,] secondArray, int m)
{
    int[,] resultArray = new int[m, m];
    {
        for (int i = 0; i < firstArray.GetLength(0); i++)
        {
            for (int j = 0; j < secondArray.GetLength(1); j++)
            {
                resultArray[i, j] = 0;
                for (int k = 0; k < firstArray.GetLength(1); k++)
                {
                    resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
                }
            }
        }
        return resultArray;
    }
}

Console.WriteLine("Введите количество строк и столбцов(m): ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное число элемента массива: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число элемента массива: ");
int max = int.Parse(Console.ReadLine());

int[,] firstArray = getArray(m, min, max);
Console.WriteLine();
printArray(firstArray);
Console.WriteLine();
int[,] secondArray = getArray(m, min, max);
printArray(secondArray);
Console.WriteLine();
int[,] resultArray = productArray(firstArray, secondArray, m);
printArray(resultArray);
Console.WriteLine();