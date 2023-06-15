// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int value = Prompt("Введите числовое значение длины одномерного массива: ");
int Prompt(string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine()!;

    if((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не числовое значение длины массива! ");
    }
    return val;
}

//Создание нового массива длиной заданной пользователем

int [] RandomMassive(int value)     
{
    int [] array = new int[value];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

//Подсчет четных чисел в массиве

void countEvenNumbers(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0) count++;
  }
 Console.WriteLine($"Количество чётных чисел в массиве = {count}");
}

//Распечатываем готовый массив и количество четных чисел в консоль
/*
void PrintMassive(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

}
*/
int[] array2 = RandomMassive (value);

//PrintMassive (array2);
Console.WriteLine($"[{String.Join("; ", array2)}]");  // открыл для себя новый спобов красиво распечатать массив в консоль =)
countEvenNumbers(array2);














