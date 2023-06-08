/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// d = √ [(X2 - X1) 2 + (Y2 - Y1) 2 + (Z2 - Z1) 2]  

Console.Clear();

double x1 = Prompt("Введите координату X1: ");
double y1 = Prompt("Введите координату Y1: ");
double z1 = Prompt("Введите координату Z1: ");
double x2 = Prompt("Введите координату X2: ");
double y2 = Prompt("Введите координату Y2: ");
double z2 = Prompt("Введите координату Z2: ");
Console.WriteLine();

Console.WriteLine($"Имеются две точки с координатами: точка первая ({x1}, {y1}, {z1}) точка вторая ({x2}, {y2}, {z2})");

double Prompt(string message)
{
    Console.Write(message);
    double num = double.Parse(Console.ReadLine());
    return num;
}
double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
Console.WriteLine($"Растояние между первой и второй точкой равно: {result}");

