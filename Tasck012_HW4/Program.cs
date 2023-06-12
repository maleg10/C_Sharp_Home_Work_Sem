// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите любое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());


int SumDigit(int number)
{
    int sum = 0;
    for (int i = 1; number > 0; i++)
    {
        int digit = number % 10;
        number = number / 10;
        sum = sum + digit;
    }
    return sum;
}

Console.WriteLine($"Сумма всех цифр в числе равна: {SumDigit(number)}");