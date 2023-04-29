// Задача 38: 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GenArray(int arrayLength, int leftside, int rightside)
{
    double[] array = new double[arrayLength];
    Random rand = new Random();

    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = rand.Next(leftside, rightside) + rand.NextDouble();
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double Diff(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
    }
    double diff = max - min;
    return diff;
}

double[] array = GenArray(5, -10, 10);
PrintArray(array);
double diff = Diff(array);
Console.WriteLine(diff);