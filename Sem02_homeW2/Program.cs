﻿// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число состоящее не менее, чем из трех символов ");
int i = Convert.ToInt32(Console.ReadLine());
if (i < 100)
{
    System.Console.WriteLine("Некорректное значение ");
}
else
{
    while (i > 999)
    {
        i = i / 10;
    }
    i = i % 10;
    System.Console.WriteLine(i + " - третья цифра ");
}