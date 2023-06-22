/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого числа в массиве нет [1,7]-это позиция элемента 1 - строка, 7 - столбец
*/


int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int val = 0;
    while ((int.TryParse(value, out val)) != true)
    {
        Console.Write("Неверный ввод. Повторите попытку: ");
        value = Console.ReadLine();
    }
   
    return val;
}


void PrintMatrix (int[,] array)
{
    for (int row = 0 ; row < array.GetLength(0) ; row ++)
    {
        for (int colum = 0 ; colum<array.GetLength(1) ; colum ++)
        {
            Console.Write($" {array [row , colum]}");
        }
    Console.WriteLine();
    }
}

int[,] CreateRandoMatrix (int rows , int colums , int minValue , int maxValue)
{
    int [,] matrix = new int[rows,colums];
    maxValue ++;
    for (int row = 0 ; row < matrix.GetLength(0) ; row ++)
    {
        for (int colum = 0 ; colum<matrix.GetLength(1) ; colum ++)
        {
            matrix[row,colum] = new Random().Next(1,100);
        }
    }
    return matrix;
}

int row = Prompt("Ведите количество строк массива: ");
int col = Prompt("Введите количество столбцов массива: ");

int[,] matr = CreateRandoMatrix(row,col, 1, 100);
PrintMatrix(matr);

int temp1 = row;
int temp2 = col;
string temp = string.Empty;
int i = 1;
while (i > 0)
{
    row = Prompt("Введите строку элемента: ");
    col = Prompt("Введите столбец элемента: ");
    int a = row-1;
    int b = col-1;
    if (row<=0 || row>matr.GetLength(0) || col<=0 || col>matr.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет в массиве");
    }
    else
    {
        Console.WriteLine($"Искомый элемент в массиве равен: {matr[a,b]}");
    }
        break;
}
