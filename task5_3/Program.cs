// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int InputUser(string message)
{
    System.Console.Write($"{message} =>");
    int takeNumber = Convert.ToInt32(Console.ReadLine());
    return takeNumber;
}


double[] FillArray(double[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(random.Next(1, 1000) / 10.0);
    }
    return array;
}

double DiffMaxMinArray(double[] myArray)
{
    double min = myArray[0];
    double max = myArray[1];
    if (min > max)
    {
        max = min;
        min = myArray[1];
    }
    for (int i = 2; i < myArray.Length; i++)
    {
        if (max < myArray[i]) max = myArray[i];
        if (min > myArray[i]) min = myArray[i];
    }
    return Math.Round(max - min, 2);
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");

    }
    System.Console.WriteLine();
}

int userNum = InputUser("Введите количество элементов массива");
double[] mainArray = new double[userNum];
FillArray(mainArray);
PrintArray(mainArray);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна  {DiffMaxMinArray(mainArray)}");

