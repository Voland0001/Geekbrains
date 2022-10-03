// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void elementArray(int[] mass, int length)
{
    int i = 0;
    while (i < length)
    {
        Console.WriteLine("Введите число элемента массива: ");
        mass[i] = int.Parse(Console.ReadLine());
        i++;
    }
}


void printArray(int[] collection)
{
    Console.WriteLine($"Все элементы массива: {String.Join(", ", collection)}");
}


void findResult(int[] array)
{
    int length = array.Length;
    int i = 0;
    int count = 0;
    while (i < length)
    {
        if (array[i] > 0)
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
int n = int.Parse(Console.ReadLine());
int[] result = new int[n];
elementArray(result, n);
printArray(result);
findResult(result);
