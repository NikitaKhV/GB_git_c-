// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(new Random().Next(0, 10));
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
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[] AverageValue(int[,] matrix)
{
    double[] averageInColumns = new double[matrix.GetLength(1)];
    for (int i = 0; i < averageInColumns.Length; i++)
    {
        double numbers = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            numbers = numbers + matrix[j, i];
        }
        averageInColumns[i] = numbers / matrix.GetLength(0);
        averageInColumns[i] = Math.Round(averageInColumns[i], 2);
    }
    return averageInColumns;
}
int m = ReadInt("Введите количество строк в матрице: ");
int n = ReadInt("Введите количество столбцов в матрице: ");
int[,] myMatrix = GenerateMatrix(m, n);
var averageInColumns = AverageValue(myMatrix);
PrintMatrix(myMatrix);
System.Console.WriteLine("Среднее арифметическое каждого столбца: ");
System.Console.Write(string.Join("\t", (averageInColumns)));