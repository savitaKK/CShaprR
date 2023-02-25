// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        array[i] = random.Next(-100, 101);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    System.Console.WriteLine();
}

int SumOddIndex(int[] tazik)
{
    int sumResult = 0;
    for (int i = 1; i < tazik.Length; i += 2)
    {
        sumResult += tazik[i];
    }
    return sumResult;
}
int userNum = InputUser("Введите количество элементов массива");
int[] mainArray = new int[userNum];
FillArray(mainArray);
PrintArray(mainArray);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна  {SumOddIndex(mainArray)}");