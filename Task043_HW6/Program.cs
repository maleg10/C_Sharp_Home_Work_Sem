// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    return val;
}
 
Console.WriteLine("Укажите запрошенные переменные для двух прямыx заданых уравнением: y = k * x + b ");


double b1 = Prompt("B1 = ");
double k1 = Prompt("K1 = ");
double b2 = Prompt("B2 = ");
double k2 = Prompt("K2 = ");

if (k1 != k2)
{
    double X = (b2 - b1) / (k1 - k2);
    double Y = k2 * X + b2;

    Console.WriteLine($"Координаты точки пересечения двух прямых: X = {X} ; Y = {Y}");
}

else if (b1 == b2) Console.WriteLine("Прямые совпадают");
else Console.WriteLine("Прямые параллельны");

