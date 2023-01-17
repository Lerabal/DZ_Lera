// 32. Написать программу замену элементов массива на противоположные


int[] generateArray(int lenght, int start, int end)
{
    int[] result = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        result[i] = new Random().Next(start, end + 1);
    }
    return result;
}

int getIntFromUser(string message)
{
    Console.WriteLine(message);
    int userInt = int.Parse(Console.ReadLine()!);
    return userInt;
}

int[] invertArray(int[] arrayToInvert)
{
    for (int i = 0; i < arrayToInvert.Length; i++)
    {
        arrayToInvert[i] = -arrayToInvert[i];
    }
    return arrayToInvert;
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

int lenght = getIntFromUser("Введите длину массива");
int[] array = generateArray(lenght, -100 ,100);
printArray(array);
int[] invertedArray = invertArray(array);
printArray(invertedArray);

