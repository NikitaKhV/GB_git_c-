// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите второе число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 1)
{
System.Console.WriteLine(number + " - число нечетное");
}
else
{
System.Console.WriteLine(number + " - число четное");
}