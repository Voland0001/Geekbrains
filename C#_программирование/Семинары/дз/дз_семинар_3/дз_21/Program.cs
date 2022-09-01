//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты z2: ");
int z2 = int.Parse(Console.ReadLine());
int ax = (x1 - x2) * (x1 - x2);
int ay = (y1 - y2) * (y1 - y2);
int az = (z1 - z2) * (z1 - z2);
int sum = ax + ay + az;
double result = Math.Sqrt(sum);
Console.WriteLine($"Длина вектора равна {Math.Round(result,2)}");










