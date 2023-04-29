// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
    for (int i = 1; i < array.Length; i += 2)
    {
        count += array[i];
    }
    return count;
}

var myArray = GenArray(5, 0, 99);
PrintArray(myArray);
Console.WriteLine(CountElements(myArray));