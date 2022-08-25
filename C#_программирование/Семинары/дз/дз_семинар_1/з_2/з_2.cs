Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int max = a;
if (a >= b) 
{
   Console.WriteLine($"Максимальным числом является число: {a}");
   Console.WriteLine($"Минимальным числом является число: {b}");
}
else
{
   Console.WriteLine($"Максимальным числом является число: {b}"); 
   Console.WriteLine($"Минимальным числом является число: {a}");   
};