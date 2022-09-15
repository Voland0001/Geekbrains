//Задача 25: 
// Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Ansver (int num1, int num2)
{
    int index = 0;
    int result = 1;
    while (index <= num2)
    {
        if (index == num2)
        { 
        Console.WriteLine($"A в степени B = {result}"); 
        break;       
        }
        else if (index < num2)
        {
        result = result * num1;
        index++;
        }
    }      
}

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());
Ansver(A, B);