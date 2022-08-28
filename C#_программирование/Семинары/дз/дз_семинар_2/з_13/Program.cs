//Напишите программу, которая выводит третью цифру (справа налево) заданного числа, 
//или сообщает, что третьей цифры нет.
//645->6
//78 -> третьей цифры нет
Console.WriteLine("Введите цифру: ");
int num = int.Parse(Console.ReadLine());
int num3; 
if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    num3 = (num % 1000) / 100;
    Console.WriteLine($"Третья цифра: {num3}");
}