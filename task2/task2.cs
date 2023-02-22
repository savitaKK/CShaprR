// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = ReadInt("Введите х1 : ");
int y1 = ReadInt("Введите y1 : ");
int z1 = ReadInt("Введите z1 : ");
int x2 = ReadInt("Введите х2: ");
int y2 = ReadInt("Введите y2: ");
int z2 = ReadInt("Введите z2: ");

int Xi = x2 - x1;
int Yi = y2 - y1;
int Zi = z2 - z1;

double length = Math.Sqrt(Xi * Xi + Yi * Yi + Zi * Zi);
Console.WriteLine($"Расстояние между точками равно в 3D пространстве равно  {length} ");


