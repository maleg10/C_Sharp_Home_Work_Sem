// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


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
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
// подсчет суммы числовых элементов массива стоящих не на четных позициях

void PrintEvenSum(int[] array)
{
    int sum = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (i%2!=0)
        {
            sum+=array[i];
        }
    }
    Console.WriteLine ($"Сумма элементов с НЕ ЧЕТНЫМ индексом равна: {sum} ");
}

int[] array2 = RandomMassive (value);
Console.WriteLine($"[{String.Join("; ", array2)}]");
PrintEvenSum(array2);
