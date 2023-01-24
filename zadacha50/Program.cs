/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "  ");
        }
        Console.WriteLine();
    }
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

int colLength = getUserData("Введите количество строк ");
int rowLength = getUserData("Введите количество столбцов");
int[,] array = AddArray(colLength, rowLength, 0, 10);
PrintArray(array);
Console.WriteLine();
int userData = getUserData("Введите число: ");

int[] FindNumber(int[,] arr, int userData)
{
    int[] position = new int[2];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == userData)
            {
                position[0] = i + 1;
                position[1] = j + 1;
                return position;
            }
        }
    }
    position[0] = -1;
    position[1] = -1;
    return position;
}
void PrintPosition(int[] pos, int num)
{
    Console.WriteLine();
    if (pos[0] > 0 && pos[1] > 0)
    {
        Console.WriteLine($"Число {num} находится в {pos[0]}-й строке, {pos[1]}-м столбце");
    }
    else
    {
        Console.WriteLine($"Число {num} отсутствует в заданном массиве");
    }
    Console.WriteLine();
}

int[] position = FindNumber(array, userData);
PrintPosition(position, userData);



