Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int current = 2;
while ((current < a) && (current % 2 == 0))
{
    Console.Write($"{current } ");
    current+=2;
}