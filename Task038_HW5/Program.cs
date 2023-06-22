// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


int size = Prompt("Введите числовое значение длины одномерного массива: ");
int Prompt(string msg)
{
    Console.Write(msg);
    string size = Console.ReadLine()!;

    if((int.TryParse(size, out int val)) == false)
    {
        Console.WriteLine("Это не числовое значение длины массива! ");
    }
    return val;
}
Console.WriteLine();

double[] num = new double[size];
RandomMassive(num);
//PrintMassive(num);
Console.WriteLine($"[{String.Join("; ", num)}]");

double max = num[0];
double min = num[0];

for (int i = 0; i < num.Length; i++)
{
    if (num[i] > max)
    {
        max = num[i];
    }
    else if (num[i] < min)
    {
        min = num[i];
    }
   
}
Console.WriteLine();

Console.WriteLine($"Минимальное число в массиве: {min}");
Console.WriteLine($"Максимальное число в массиве: {max}");
Console.WriteLine($"Разница между максимальным и минимальным числами составляет: {max-min}");
Console.WriteLine();

//Создание нового массива длиной заданной пользователем

void RandomMassive(double[] array)     
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 255)/100.0;
    }
    
}
/*
void PrintMassive(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
*/
