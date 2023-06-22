/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Write("Введите количество строк (m) массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество стобцов (n) массива: ");
int n = Convert.ToInt32(Console.ReadLine());


void PrintMatrix (int[,] matrix)
{
    for (int i = 0 ; i < matrix.GetLength(0) ; i ++)
    {
        for (int j = 0 ; j<matrix.GetLength(1) ; j ++)
        {
            Console.Write($" {matrix [i , j]}");
        }
    Console.WriteLine();
    }
}


int[,] RandomMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 50);
        }
    }
     return result;
}

int [,] matr = RandomMatrix(m,n,1,50);
PrintMatrix(matr);

    Console.WriteLine("Среднее арифметическое столбцов:");

    double arithmeticalMean = 0;

    for (int j = 0; j < n; j++)
    {
        for (int i = 0; i < m; i++)
        {
            arithmeticalMean += matr[i, j];
        }
        arithmeticalMean = Math.Round(arithmeticalMean / m, 2);
        Console.Write(arithmeticalMean + "\t|");     
    }
   









