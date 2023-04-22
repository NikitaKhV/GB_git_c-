// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

System.Console.WriteLine("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int result = numA;

for (int i=2; i <= numB; i++)
{
    result *= numA;
}
Console.Write($"Число {numA} в {numB} степени равно {result} ");