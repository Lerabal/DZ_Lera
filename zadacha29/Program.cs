// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int n = 8;

int[] SetArray(int lenght)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] array)
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
PrintArray(SetArray(n));
