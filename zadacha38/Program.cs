/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

*/
int[] FillArray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}

int getMaxMinDiffer(int[] array)
{
    int max = array[0];
    int min = array[0];
    int differ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
        differ = max - min;
    }
    return differ;
}


int[] array = FillArray(5, 1, 50);
printArray(array);
Console.WriteLine();
int differ = getMaxMinDiffer(array);
Console.WriteLine($"Разница между максимальным и минимальным числом = {differ}");