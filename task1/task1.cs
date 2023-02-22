// // Задача 1
// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Проверка без применения строк
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да

 Console.WriteLine ("Введите 5-ти значное число-> ");
 string number = Console.ReadLine();
 int pal = number.Length;

 if (pal == 5)
 {
     if (number[0] == number[4] && number [1] == number[3])
    {
        Console.WriteLine($" Число {number}  палиндром");
    }

     else
     {
        Console.WriteLine($" Число {number} не палиндром");
    }
}
 else
 {
    Console.WriteLine ("число не подходит, нужно пятизначное!");
}