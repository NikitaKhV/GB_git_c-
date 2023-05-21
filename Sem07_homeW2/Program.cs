// Задача 50.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-3, 5);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void Find (int[,] matrix)
{
    Console.WriteLine("Введите индекс строки:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс столбца:");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m < matrix.GetLength(0) && n < matrix.GetLength(1))
    {
       Console.WriteLine($"Внимание, значение указанного Вами элемента: {matrix[m, n]}");
    }
    else 
    {
        Console.Write("Такого числа в массиве нет!");
    }
}

int[,] matrix = CreateMatrix (4,4);
PrintMatrix (matrix);
Find (matrix);