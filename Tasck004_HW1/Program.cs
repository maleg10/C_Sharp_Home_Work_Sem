// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число больше нуля: ");
int num = int.Parse(Console.ReadLine ()!);
int temp = 2;

if ( num > 2)
    {
    while (temp <= num)
        {
        Console.Write(temp + " ");
        temp += 2;
        }
    }
else
    {
    Console.Write("Вы ввели слишком маленькое значение");
    }
