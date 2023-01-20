/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4*/


int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int getCount(int size)
{
    int count = 0;

    while (size > 0)
    {
        int num1 = getUserData("Введите число");
        if (num1 > 0) count++;
        size--;
    }

    return count;
}
 int step=getCount(5);
Console.WriteLine($"Количество чисел больше 0 = {step}");