// 42. Преобразовать число в двоичное 

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

string TransformBinary(int number)
{
    string result = string.Empty;
    while (number > 0)
    {
        result = number % 2+result;
        number = number / 2;
    }
    return result;
}
int number = getUserData("Введите число: ");
string binary = TransformBinary(number);
Console.WriteLine ($"{number} = {binary}");