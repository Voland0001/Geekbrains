// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Newmas(double[] col, int num1, int num2)
{
    int length = col.Length;
    int index = 0;
    while(index<length)
    {
        if (num1<=num2)
        {col[index]= new Random().Next(num1, num2) + new Random().NextDouble();
;
        }
        else if (num1>num2)
        {col[index]= new Random().Next(num2, num1)+ new Random().NextDouble();
        }
        index++;
    }
}    

void Minmax(double[] mas)
{
    for(int i =0; i<mas.Length-1; i++)
    {
        int minpos = i;
        for(int j =i+1; j<mas.Length; j++)
        {
            if (mas[j] < mas[minpos])
            {
                minpos = j;
            }

        }
        double temporery = mas [i];
        mas[i] = mas[minpos];
        mas[minpos] = temporery;
    }
}

void Diffminmax(double[] mas)
{
    double max = 0;
    int i = 0;
    int length= mas.Length;
    while (i<length)
        if (max <= mas[i])
        {
            max = mas[i];
            i++;                     
        }
        else
        {
            i++;
        }
    Console.WriteLine("Разница между максимальным и минимальным элементом массива равна {0}", Math.Round(max-mas[0],2));    
}

void Printmas(double[] collection)
{
    int len = collection.Length;
    int count = 0;
    while(count<len)
    {
        Console.Write($"({Math.Round(collection[count], 2)}), ");
        count++;
    }    
}

Console.WriteLine("Введите количество чисел массива: ");
int n =int.Parse(Console.ReadLine());
Console.WriteLine("Введите число начала диапазона массива: ");
int number1 =int.Parse(Console.ReadLine());
Console.WriteLine("Введите число конца диапазона массива: ");
int number2 =int.Parse(Console.ReadLine());
double[] newarray = new double[n];

Newmas(newarray, number1, number2);
Minmax(newarray);
Diffminmax(newarray);
Printmas(newarray);


