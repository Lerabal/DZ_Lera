/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetDataFromUser(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int Sum(int start, int end)
{
    if (start > end) return end + Sum(end + 1, start);
    if (start == end) return end;
    else return start + Sum(start + 1, end);

}

int m = GetDataFromUser("Задайте значение от M: ");
int n = GetDataFromUser("Задайте значение до N: ");
int sum = Sum(m,n);
Console.WriteLine($"Cуммa натуральных элементов в промежутке от {m} до {n} = {sum}");


