// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();

Console.WriteLine ("Введите номер дня недели:" );
int userday = int.Parse(Console.ReadLine ()!);

if (userday<=0)
{
    Console.Write("Введите номер дня недели");
}
else if (userday>=8)
{
    Console.Write("Введите номер дня недели");
}
else if (userday>5)
{
    Console.Write("Выходной день ");
}
else if (userday<=5)
{
    Console.Write("Будний день ");
}

else {Console.WriteLine ("Введите номер дня недели:" );}