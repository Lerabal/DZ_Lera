
/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int GetDataFromUser(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}


int[,] AddArray(int row, int col, int start, int end)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(start, end);
        }
    }
    return array;
}

void PrintArr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " \t ");
        }
        Console.WriteLine();
    }
}

double[] Sum(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            result[j] = sum / array.GetLength(1);
            
        }
        Console.Write($"{result[j]+ " \t"}");

    }
    return result;
}

int colLength = GetDataFromUser("Введите количество строк ");
int rowLength = GetDataFromUser("Введите количество столбцов");
Console.WriteLine();
int[,] arr = AddArray(colLength, rowLength, 2, 10);
PrintArr(arr);
Console.WriteLine();
double[] sum = Sum(arr);


