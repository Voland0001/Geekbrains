Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

if ((a>=b) && (a>=c)) 
{
    Console.Write($"Максимальное число = {a}");
}
else if ((b>=a) && (b>=c)) 
{
    Console.Write($"Максимальное число = {b}");
}
else if ((c>=a) && (c>=b)) 
{
    Console.Write($"Максимальное число = {c}");
}

//int max = Math.Max(Math.Max(a,b),Math.Max(a,c));
//int result = Convert.ToInt32(max);
//Console.Write($"Максимальное число = {result}");