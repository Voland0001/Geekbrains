// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void FillArray(int[] Collection)
{
    int length = Collection.Length;
    int index = 0;
    while (index < length)
    {
        Collection[index]= new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int[] array = new int[10];
