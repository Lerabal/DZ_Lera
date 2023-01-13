//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

Console.Clear();
int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int getSum(int userData)
{
    int sum = 0;
    while (userData > 0)
    {
        sum = sum + userData % 10;
        userData = userData / 10;
    }
    return sum;
}


int userData = getUserData("Введите число: ");
int result = getSum(userData);
Console.WriteLine($"Сумма цифр {userData} = {result}");