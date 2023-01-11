// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

Console.Clear();
Console.Write ("Введите число1: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write ("Введите число2: ");
int num2 = int.Parse(Console.ReadLine()!);
int count = 1;
int result = num1;

while (count < num2)
{
    result = result * num1;
    count++;
}

Console.WriteLine($"{num1} в {num2} степени = {result}");
