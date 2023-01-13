// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

Console.Clear();
int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int userData = getUserData("Введите число 1: ");
int userData1 = getUserData("Введите число 2: ");

int stepen(int userData, int userData1)
{
    int count = 1;
    int result = userData;
    while (count < userData1)
    {
        result = result * userData;
        count++;
    }
    return result;
}

int end = stepen(userData, userData1);
Console.WriteLine($"{userData} в {userData1} степени = {end}");