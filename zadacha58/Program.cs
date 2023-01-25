/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int[,] AddArray(int colLength, int rowLength, int start, int finish)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, finish);
        }
    }
    return array;
}

int[,] MultiplyArray(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            result [i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
            result[i, j] += array1[i, k] * array2[k,j];
            }
        }
    }
    return result;
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

int[,] array1 = AddArray(2, 2, 1, 10);
int[,] array2 = AddArray(2, 2, 1, 10);
int[,] result = MultiplyArray(array1, array2);
Console.WriteLine("Первая матрица:");
PrintArray(array1);
Console.WriteLine("Вторая матрица:");
PrintArray(array2);
Console.WriteLine("Произведение матриц:");
PrintArray(result);
