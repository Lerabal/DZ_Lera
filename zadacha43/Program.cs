/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

double b1 = getUserData("Введите b1: ");
double k1 = getUserData("Введите k1: ");
double b2 = getUserData("Введите b2: ");
double k2 = getUserData("Введите k2: ");
double cord = Koord(b1,k1,b2,k2);
double cord1 = Koord1(b2,k2);

double Koord(double b1, double k1, double b2, double k2)
{
    double x = (-b2 + b1) / (-k1 + k2);
    return x; 
    }

double Koord1(double b2, double k2)
{
    double y = k2 * cord + b2;
    return y;
}
 
Console.WriteLine($"Прямые пересекутся в точке с координатами X: {cord}, Y: {cord1}");

