//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3   


Console.WriteLine("Введите первое число: ");
double num1 = double.Parse(Console.ReadLine ()!);
Console.WriteLine("Введите второе число: ");
double num2 = double.Parse(Console.ReadLine ()!);

if (num1 > num2)
    {
    Console.Write("Первое число больше второго: " + num1 + " > " + num2);
    }
else if (num1 == num2)
    {
    Console.WriteLine("Числа равны друг другу: " + num2 + " = " + num1);
    }
else
    {
    Console.WriteLine("Второе число больше первого: " + num2 + " > " + num1);
    }