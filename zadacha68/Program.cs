/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int GetDataFromUser(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int Akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    else if ((n != 0) && (m == 0)) return Akkerman(n - 1, 1);
    else return Akkerman(n - 1, Akkerman(n, m - 1));
}

int m = GetDataFromUser("Введите целое неотрицательное число m: ");
int n = GetDataFromUser("Введите целое неотрицательное число n: ");
int akker = Akkerman(m, n);
Console.WriteLine($"A({m},{n}) ->  =  {akker}");