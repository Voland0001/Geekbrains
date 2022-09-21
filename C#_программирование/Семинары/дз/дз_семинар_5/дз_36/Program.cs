// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Newmas(int[] col, int number1, int number2)
{
    int length = col.Length;
    int index = 0;
    while(index<length)
    {
        if(number1<=number2)
        {col[index]= new Random().Next(number1, number2);      
        index++;
        }
        else if (number1>number2)
        {
        col[index]= new Random().Next(number2, number1);      
        index++;
        }
    }
}  
   
void Printmas(int[] collection)
{
    int len = collection.Length;
    int count = 1;
    int sum = 0;
    while(count<len)
    {
        sum = sum + collection[count];
        count = count+2;      
    } 
    Console.WriteLine($"Сумма чисел на нечетных позициях: {sum}");  
}

void Print(int[] collection)
{Console.WriteLine($"Элементы сгенерированного массива: {String.Join(", ", collection)}");
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
Print(newarray);


