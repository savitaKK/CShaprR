// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int InputUser(string message)
{
    System.Console.Write($"{message} =>");
    int takeNumber = Convert.ToInt32(Console.ReadLine());
    return takeNumber;
}


int[] FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    System.Console.WriteLine();
    return array;
}

int TakeEvenArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result++;
    }
    return result;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");

    }
    System.Console.WriteLine();
}

int userNum = InputUser("Введите количество элементов массива");
int[] mainArray = new int[userNum];
FillArray(mainArray);
PrintArray(mainArray);
Console.WriteLine($"Количество четных чисел в массиве {TakeEvenArray(mainArray)}");
