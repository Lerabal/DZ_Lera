// 30.Задать массив, заполненных нулями и единицами вывести их на экран

int[] GetArrayRandom(int lenght)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}

void ShowArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}]");
        }
    }
}
int[] array = GetArrayRandom(8);
ShowArray(array);

//void stringMassage (int[] array)