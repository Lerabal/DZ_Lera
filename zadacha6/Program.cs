// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет
//string number1 = Console.ReadLine();
//int number = Convert.ToInt32(number1);

Console.Clear();

Console.Write ("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number%2 == 0) //Если остаток от деления равен 0
{
    Console.Write ("Введено четное число");
}
else
{
    Console.Write ("Введено нечетное число");
}