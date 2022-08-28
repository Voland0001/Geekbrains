Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int current = 2;
while (current < a) 
{
    Console.Write($"{current } ");
    current+=2;
}