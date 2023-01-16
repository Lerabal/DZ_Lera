/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

Console.Clear();

int[] GetArrayRandom(int lenght)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        arr[i] = new Random().Next(-10, 10);
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
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0)
        {
            sum += array[i];
        }

    }
    Console.WriteLine($"Cумма элементов, стоящих на нечётных позиция {sum}");
}

int[] array = GetArrayRandom(4);
ShowArray(array);
Console.WriteLine();
PrintResult(array);
