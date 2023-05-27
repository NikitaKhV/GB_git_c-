// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
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
int FindMin(int[,] matrix)
{
    int min = 0;
    int matrixminline = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrixminline = matrixminline + matrix[0, j];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int matrixminstroke = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrixminstroke += matrix[i, j];
        }
        if (matrixminline > matrixminstroke)
        {
            min = i;
            matrixminline = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrixminline += matrix[min, j];
            }
        }
    }
    return min + 1;
}

int[,] matrix = CreateMatrix(5, 3);
PrintMatrix(matrix);
System.Console.WriteLine();
System.Console.WriteLine("Строка с наименьшей суммой элементов: - строка № " + FindMin(matrix));