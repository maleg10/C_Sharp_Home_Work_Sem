// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int arrayRows = 3;
int arrayColumns = 4;
int arrayMaxValue = 10;
int arrayMinValue = 1;

Console.WriteLine("Исходный массив:");
int[,] array = FillArray(arrayRows, arrayColumns, arrayMaxValue, arrayMinValue);

for (int currentStringIndex = 0; currentStringIndex < arrayRows; currentStringIndex++)
{
    SortStrOfArray(array, currentStringIndex);
}

Console.WriteLine("\nРезультат: ");
for (int i = 0; i < arrayRows; i++)
{

    for (int j = 0; j < arrayColumns; j++)
    {
        Console.Write(array[i, j] + "\t|");
    }
    Console.WriteLine("<-- row " + (i + 1));
}

void SortStrOfArray(int[,] array, int currentStringIndex)
{
    int tempMemory;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = array.GetLength(1) - 1; j > i; j--)
        {
            if (array[currentStringIndex, j] < array[currentStringIndex, j - 1])
            {
                tempMemory = array[currentStringIndex, j];
                array[currentStringIndex, j] = array[currentStringIndex, j - 1];
                array[currentStringIndex, j - 1] = tempMemory;
            }
        }
    }
}
