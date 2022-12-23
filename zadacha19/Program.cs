/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/


int getUserValue(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int IsPalindrom(int num)
{
    for (int i = 1; i < num / 2;)
    {
        int num1 = num / 10000;
        int num2 = num % 10;
        if (num > 99999 || num <= 9999) 
        {
            Console.WriteLine("Введите пятизначнеое число!");
            break;
        }
        else if (num1 == num2)
        {
            Console.WriteLine($"Число {num} является палиндромом");
            break;
        }
        else
        {
            Console.WriteLine($"Число {num} не является палиндромом");
            break;
        }
    }
    return num;
}
int num = getUserValue("Введите пятизначное число: ");
IsPalindrom(num);




