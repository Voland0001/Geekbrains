// Задача 43: Напишите программу, которая найдёт 
// точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



void Result(double numb1, double numb2, double numk1, double numk2)
{
    double arg = (numb2-numb1)/(numk1-numk2);
    if (numb1 == numb2 && numk1==numk2)
    {
        Console.Write("Прямые совпадают.");        
    }
    else if ((numb1 * numk2 - numb2 * numk1) == 0)
    {
         Console.Write("Прямые параллельны и не имеют общих точек.");
    }
    else
    {
        double function = numk1 * (arg) + numb1;
        Console.WriteLine($"({arg}, {function})");
    }
}

Console.WriteLine("Введите чисело b1: ");
double b1 =double.Parse(Console.ReadLine());
Console.WriteLine("Введите чисело b2: ");
double b2 =double.Parse(Console.ReadLine());
Console.WriteLine("Введите чисело k1: ");
double k1 =double.Parse(Console.ReadLine());
Console.WriteLine("Введите чисело k2: ");
double k2 =double.Parse(Console.ReadLine());

Result(b1, b2, k1, k2); 