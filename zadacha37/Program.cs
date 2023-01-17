// //37/Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.


int[] newarray(int[] array)
{
    int newlength = (int)Math.Ceiling(array.Length / 2.0);
    int[] arr = new int[newlength];
    for (int i = 0; i < newlength; i++)
    {
        if (i < newlength - 1 || array.Length % 2 == 0)
        {
            arr[i] = array[i] * array[array.Length - i - 1];
        }
        else
        {
            arr[i] = array[i];
        }
    }
    return arr;
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

int number = getUserData("Введите количество элементов в массиве");
int[] array = FillArray(number, 1, 20);
printArray(array);
Console.WriteLine();
int[] array2 = newarray(array);
printArray(array2);