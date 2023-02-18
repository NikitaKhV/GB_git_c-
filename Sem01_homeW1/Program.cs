// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
System.Console.WriteLine(numberA + " - Большее число");
System.Console.WriteLine(numberB + " - Меньшее число");
}
else
{
    System.Console.WriteLine(numberB + " - Большее число");
    System.Console.WriteLine(numberA + " - Меньшее число");
}