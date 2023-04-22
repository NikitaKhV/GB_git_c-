// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно полиандромом
//14212 -> нет
//23432 -> да
//12821 -> да

System.Console.WriteLine("Введите пятизначное число:");
string num = Console.ReadLine()!;
int palind = num.Length;
if (palind == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"Число {num} - палиндром");
    }
    else
    {
        Console.WriteLine($"Число {num} - не палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: число {num} - не является пятизначным");
}