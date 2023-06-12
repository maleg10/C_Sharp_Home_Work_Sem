// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
double NumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
double NumberB = Convert.ToInt32(Console.ReadLine());

double result = NumberA;

for (int i = 2; i <= NumberB; i++)
{
    result *= NumberA;
}

Console.WriteLine($"{NumberA}^{NumberB} = {result}");