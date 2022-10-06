// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int FindFunction(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return FindFunction(m - 1, 1);
  else return FindFunction(m - 1, FindFunction(m, n - 1));
}

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int functionAkkerman = FindFunction(m, n);
Console.Write($"Функция Аккермана = {functionAkkerman}");