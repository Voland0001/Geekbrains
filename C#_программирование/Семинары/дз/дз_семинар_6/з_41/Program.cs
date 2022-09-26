// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Num (int[] mass, int length)
{
    int i = 0;
    while (i<length)
    {
        Console.WriteLine("Введите число эллемента массива: ");
        mass[i] = int.Parse(Console.ReadLine());
        i++;
    }
}


void Print(int[] collection)
{Console.WriteLine($"Все элементы массива: {String.Join(", ", collection)}");
} 


void Res (int[] arr)
{
    int length = arr.Length;
    int i = 0;
    int count = 0;
    while (i<length)
    {
        if (arr[i] > 0)
        {
            count++;
            i++;
        }
        else 
        {
            i++;
        }
    }
    Console.Write($"Числа больше нуля: {count}");
}


Console.WriteLine("Введите количество чисел массива: ");
int n =int.Parse(Console.ReadLine());
int[] result = new int[n];
Num(result, n);
Print(result);
Res(result);
