// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Newmas(int[] col)
{
    int length = col.Length;
    int index = 0;
    while(index<length)
    {
        col[index]= new Random().Next(1, 1000);      
        index++;
    }
}  
   
void Printmas(int[] collection)
{
    int len = collection.Length;
    int count = 0;
    int sum = 0;
    while(count<len)
    {
        if (collection[count] % 2 == 0)
        {sum = sum +1;
        count++;}
        else
        {
        count++;
        }
    } 
    Console.WriteLine($"Количество четных чисел в массиве: {sum}");  
}

void Print(int[] collection)
{Console.WriteLine($"Элементы сгенерированного массива: {String.Join(", ", collection)}");
} 

Console.WriteLine("Введите количество чисел массива: ");
int n =int.Parse(Console.ReadLine());
int[] newarray = new int[n];

Newmas(newarray);
Printmas(newarray);
Print(newarray);



