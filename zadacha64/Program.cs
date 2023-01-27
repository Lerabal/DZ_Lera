﻿/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetDataFromUser(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int Recur(int n)
{
    if (n > 1)
    {
        Console.Write(n +",  ");
        Recur(n - 1);
    }
    return 1;
}

int dataUser = GetDataFromUser("Задайте значение N: ");
Console.Write(Recur(dataUser));
