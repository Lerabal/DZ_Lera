// / 31. Задать массив из 12 элементов, заполненных числами из [-9,9]. 
// Найти сумму положительных/отрицательных элементов массива

int[] generateArray(int lenght, int start, int end)
{
    int[] result = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        result[i] = new Random().Next(start, end + 1);
    }
    return result;
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

int getSumPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int getSumNegative(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

//flag=1 положительные flag= -1 тогда отрицательные
int getSumPositiveNegative(int[] array, int flag = 1)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]*flag > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
int[] array = generateArray(12, -9, 9);
printArray(array);
Console.WriteLine();
int SumPositive = getSumPositive(array);
int SumNegative = getSumNegative(array);
Console.WriteLine($"Сумма положительных чисел {SumPositive}");
Console.WriteLine($"Сумма отрицательных чисел {SumNegative}");

int SumPositive1 = getSumPositiveNegative(array, 1);
int SumNegative1 = getSumPositiveNegative(array, -1);
Console.WriteLine($"Сумма положительных чисел {SumPositive1}");
Console.WriteLine($"Сумма отрицательных чисел {SumNegative1}");