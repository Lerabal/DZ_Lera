// 28. Написать программу вычисления произведения чисел от 1 до N
//4 - -> 24
//5 --> 120

Console.Clear();
int getUserData(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int getMultiplic(int start, int end)
{
    int multip = 1;
    for (int i = 1; i <= end; i++)
    {
        multip = multip * i;
    }
    return multip;
}

int num = getUserData("Введите число N");
int result = getMultiplic(1, num);
Console.Write(result);
