// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int m, int n)
{
    if (m == n + 1) return 0;
    return m + SumNumbers(m + 1, n);
}

System.Console.WriteLine();
int m = ReadInt("Введите значение M: ");
int n = ReadInt("Введите значение N: ");
if (m < n)
{
    System.Console.Write($"Сумма натуральных значений {m} to {n}: ");
    System.Console.WriteLine(SumNumbers(m, n));
    System.Console.WriteLine();
}
else
{
    System.Console.Write($"Сумма натуральных значений {n} to {m}: ");
    System.Console.WriteLine(SumNumbers(n, m));
    System.Console.WriteLine();
}