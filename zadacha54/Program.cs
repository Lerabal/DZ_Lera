/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 
*/
Console.Clear();

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

int[,] SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int min = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, min]) min = k;
            }
            int temp = array[i, j];
            array[i, j] = array[i, min];
            array[i, min] = temp;
        }

    }
    return array;
}


int colLength = 4;
int rowLength = 4;
int start = 1;
int finish = 10;

int[,] array = AddArray(colLength, rowLength, start, finish);
PrintArray(array);
Console.WriteLine();
int[,] sorted = SortArray(array);
PrintArray(sorted);