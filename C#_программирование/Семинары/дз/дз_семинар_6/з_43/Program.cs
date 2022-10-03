// Задача 43: Напишите программу, которая найдёт 
// точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



void result(double numB1, double numB2, double numK1, double numK2)
{
    double argument = (numB2 - numB1) / (numK1 - numK2);
    if (numB1 == numB2 && numK1 == numK2)
    {
        Console.Write("Прямые совпадают.");
    }
    else if ((numB1 * numK2 - numB2 * numK1) == 0)
    {
        Console.Write("Прямые параллельны и не имеют общих точек.");
    }
    else
    {
        double function = numK1 * (argument) + numB1;
        Console.WriteLine($"({argument}, {function})");
    }
}

Console.WriteLine("Введите чисело b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите чисело b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите чисело k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите чисело k2: ");
double k2 = double.Parse(Console.ReadLine());

result(b1, b2, k1, k2);