// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5,
// b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string message)
{
    Console.Write(message);
    double num = Convert.ToDouble(Console.ReadLine()!);
    return num;
}
void GetPoint(double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k2 - k1);

    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;

    Console.Write($" -> ({y1}; {y2})");
}
double b1 = Prompt($"Введите значение b1: ");
double k1 = Prompt($"Введите значение k1: ");
double b2 = Prompt($"Введите значение b2: ");
double k2 = Prompt($"Введите значение k2: ");
Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} ");
GetPoint(k1, b1, k2, b2);