//  35. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]


int[] FillArray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int Find(int[] array, int start, int end)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= start && array[i] <= end)
        {
            count += 1;
        }

    }
    return count;
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


int number = getUserData("Введите количество элементов в массиве");
int[] array = FillArray(number, 1, 20);
printArray(array);
Console.WriteLine();
int start = getUserData("Введите начальное число диапазона");
int end = getUserData("Введите конечное число диапазона");

int count = Find(array, start, end);
Console.WriteLine($"Количество элементов в диапазоне [{start}, {end}] = {count}");