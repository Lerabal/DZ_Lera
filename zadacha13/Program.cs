//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.Write ("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number / 100 > 0) 
{
    Console.WriteLine($"Третьей цифрой числа {number} является цифра {number.ToString()[2]}");
}
else 
{
    Console.WriteLine($"У числа {number} нет третьей цифры");
}

Console.WriteLine();

