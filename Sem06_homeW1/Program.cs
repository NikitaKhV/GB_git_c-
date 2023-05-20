// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через пробел: ");
int[] myArray = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int count = 0;
int GenerateArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
        if (myArray[i] > 0)
        {
            count++;
        }
    return count;
}
GenerateArray(myArray);
PrintArray(myArray);
void PrintArray(int[] array)
{
    Console.WriteLine($"Кол-во элементов > 0: - {count}");
}