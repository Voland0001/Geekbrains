// Задача 50. Напишите программу, которая на вход принимает число 
// и генерирует случайный двумерный массив, и возвращает индексы этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет.

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

void Foundindex(int[,] array, int num)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] != num)
            {
                continue;
            }
            else
            {
                Console.Write($"{(i, j)} ");
                count++;
            }
        }       
    }
    Console.WriteLine();
    if (count > 0)
    {
        Console.WriteLine($"{num} -> число в массиве есть.");
    }
    else
    {
        Console.WriteLine($"{num} -> такого числа в массиве нет.");
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
Console.WriteLine("Введите число элемента массива: ");
int number = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, min, max);
Console.WriteLine();
PrintArray(myArray);
Console.WriteLine();
Foundindex(myArray, number);











// if (Foundindex(myArray, number) == string.Empty)
// {
//      Console.WriteLine("Совпадающие элементов отсутствуют.");
// }
// else
// {
//     Console.WriteLine("Индексы совпадающих элементов: ");
//     ;
// }