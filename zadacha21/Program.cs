/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

int getUserValue(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int x1 = getUserValue("Введите x1: ");
int y1 = getUserValue("Введите y1: ");
int z1 = getUserValue("Введите z1: ");
int x2 = getUserValue("Введите x2: ");
int y2 = getUserValue("Введите y2: ");
int z2 = getUserValue("Введите z2: ");


double sgrt1 = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2)); //Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
Console.WriteLine(Math.Round(sgrt1,2));

