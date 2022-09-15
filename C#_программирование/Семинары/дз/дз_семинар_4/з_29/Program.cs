// Задача 29: Напишите программу, которая задаёт массив из N элементов, 
// заполненных случайнми числами из [a, b) и выводит их на экран.
// 5, 0, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 35 -> [6, 1, 33]

void Newmas(int[] col, int num1, int num2)
{
    int length = col.Length;
    int index = 0;
    while(index<length)
    {
        if (num1<=num2)
        {col[index]= new Random().Next(num1, num2);
        }
        else if (num1>num2)
        {col[index]= new Random().Next(num2, num1);
        }
        index++;
    }
}  
void Printmas(int[] collection)
{
    int len = collection.Length;
    int count = 0;
    while(count<len)
    {
        Console.Write($"{collection[count]}, ");
        count++;
    }    
}

Console.WriteLine("Введите количество чисел массива: ");
int n =int.Parse(Console.ReadLine());
Console.WriteLine("Введите число начала диапазона массива: ");
int number1 =int.Parse(Console.ReadLine());
Console.WriteLine("Введите число конца диапазона массива: ");
int number2 =int.Parse(Console.ReadLine());
int[] newarray = new int[n];

Newmas(newarray, number1, number2);
Printmas(newarray);


