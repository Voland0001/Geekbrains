void ElementArray(string[] mass, int length)
{
    int i = 0;
    while (i < length)
    {
        Console.WriteLine("Введите элемент массива: ");
        mass[i] = Console.ReadLine();
        i++;
    }
    Console.WriteLine($"Все элементы массива: {String.Join(", ", mass)}");
}

void SortArray(string[] array, int lengthArray, int maxLengthElement)
{
    int i = 0;
    int lengthElement = 0;
    while (i < lengthArray)
    {
        lengthElement = array[i].Length;
        if (lengthElement <= maxLengthElement)
        {
            Console.Write($"{array[i]} ");
            i++;
        }
        else
        {
            i++;
        }
    }
}

Console.WriteLine("Введите количество элементов массива: ");
int lengthArray = int.Parse(Console.ReadLine());
int maxLengthElement = 3;
string[] result = new string[lengthArray];
ElementArray(result, lengthArray);
SortArray(result, lengthArray, maxLengthElement);
