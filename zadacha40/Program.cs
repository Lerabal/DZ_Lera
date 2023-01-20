// 40.Принимает на вход три числа и проверяет может ли существовать треугольник с сторонами такой длины. Теорема  о неравенстве треугольника:
// каждая сторона треуг меньше суммы двух других сторон

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

bool IsTriangleExist(int a, int b, int c)
{
    bool isExist = false;
    if (a < b + c && b < c + a && c < b + a)
    {
        isExist = true;
    }
    return isExist;
}

int a = getUserData("Введите длину стороны А");
int b = getUserData("Введите длину стороны B");
int c = getUserData("Введите длину стороны C");
bool isExist = IsTriangleExist(a, b, c);

Console.WriteLine($"Треугольник со сторонами [{a}, {b}, {c}] {((isExist) ? "существует" : "не существует")}");

/*
string str;
if (isExist)
{str = "Существует";}
else {str = "неСуществует";}

int str = (isExist)?4+a:5-b)
*/
