// Задача 34:
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenArray(int arrayLength, int leftside, int rightside)
{
    int[] array = new int[arrayLength];
    Random rand = new Random();
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = rand.Next(leftside, rightside + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}
int CountElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        { count++; }
    }
    return count;
}

var myArray = GenArray(5, 100, 999);
PrintArray(myArray);
Console.WriteLine(CountElements(myArray));