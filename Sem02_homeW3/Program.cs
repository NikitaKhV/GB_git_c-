// Напишите программу, которая принимает на вход цифру, 
//бозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.WriteLine("Введите номер дня недели от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7)
{
    System.Console.WriteLine("Нет - такого значения не существует ");
}
if (number < 6)
{
    System.Console.WriteLine("Нет - значения от 1 до 5 не относятся к выходным дням");
}
else if (number > 5 && number < 8)
{
    System.Console.WriteLine("Да - выходной день");
}