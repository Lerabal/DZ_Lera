//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

Console.Write ("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Второй цифрой числа {number} является {number/10%10}");



