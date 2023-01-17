// 33. Определить, присутствует ли в заданном массиве, некоторое число 

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

int FindNumber(int[] array, int number)
{
    int result = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            result = i;
            break;
        }
        
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


int number = getUserData("Введите количество элементов в массиве");
int[] array = FillArray(number, 1, 20);
printArray(array);
Console.WriteLine();
int findnumber = getUserData("Введите искомое число");
int result = FindNumber(array, findnumber);
if (result == -1)
{ Console.WriteLine("Данного числа нет"); }
else { Console.WriteLine($"Число {findnumber} есть в массиве. Индекс позиции = {result}"); }