// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] RandomArray = new int[m,n];

void Massive(int m, int n)
{
    int i,j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            RandomArray[i,j] = rand.Next(1,10);
        }
    }
}

void PrintMassive(int[,] array)
{
    int i,j;
    for (i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
    }
}

Massive(m,n);
Console.WriteLine("\nИсходный массив: ");
PrintMassive(RandomArray);

// Функция, считающая сумму элементов в строке

int SumLine(int[,] array, int i)
{
    int sum = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
    }
      return sum;
}

int minSum = 1;
int sum = SumLine(RandomArray, 0);
for (int i = 1; i < RandomArray.GetLength(0); i++)
{
    if (sum > SumLine(RandomArray, i))
    {
        sum = SumLine(RandomArray, i);
        minSum = i+1;
    }
}
Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");