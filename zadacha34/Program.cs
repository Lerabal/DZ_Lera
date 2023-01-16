/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
Console.Clear();

int[] GetArrayRandom(int lenght)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

void ShowArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}]");
        }
    }
}

void PrintResult(int[] array)
{
    int even = 0;
    int uneven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            even++;
        }
        else
        {
            uneven++;
        }
    }
    Console.WriteLine($"Четных чисел {even}, нечетных {uneven}");
}

int[] array = GetArrayRandom(5);
ShowArray(array);
Console.WriteLine();
PrintResult(array);