/*Задача 51: 
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
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
void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}

void printArray(int[,] array)
{
    Console.Write(" \t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j + " \t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + " \t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //Console.Write(array[i, j] + " \t");
            if (i == j)
            {
                printInColor(array[i, j] + " \t");
            }
            else
            {
                Console.Write(array[i, j] + " \t");
            }
        }
        Console.WriteLine();
    }
}

int FindSum(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                result = result + array[i, j];
            }
        }
    }
    return result;
}

void Change(int[,] array)
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
    return;
}



int colLength = GetDataFromUser("Введите количество строк ");
int rowLength = GetDataFromUser("Введите количество столбцов");
int[,] array = AddArray(colLength, rowLength, 0, 10);
printArray(array);
Console.WriteLine();
int sum = FindSum(array);
Console.WriteLine($"Сумма элементов главной диагонали = {sum}");
