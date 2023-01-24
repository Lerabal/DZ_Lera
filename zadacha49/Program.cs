/* Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
*/

int GetDataFromUser(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int[,] AddArray(int colLength, int rowLength, int start, int finish)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]+" \t");
        }
        Console.WriteLine();
    }
}

int [,] Change(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = (int)Math.Pow(array[i, j], 2);
            }
        }
    }
    return array;
}

int colLength = GetDataFromUser("Введите количество строк ");
int rowLength = GetDataFromUser("Введите количество столбцов");
int[,] array = AddArray(colLength, rowLength, 0, 10);
PrintArray(array);
Console.WriteLine();
int [,] arraySquare = Change(array);
PrintArray(arraySquare);
Console.WriteLine();

