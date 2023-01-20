//39. перевернуть массив

int[] newArray (int length, int deviation)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-deviation, deviation+1);
    }
    return array;
}
 void printArray(int[] array)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("[");
    Console.ResetColor();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("]");
    Console.ResetColor();
}

int[] reversArray (int[] array)
{ 
    //int length=(int)Math.Ceiling(array.Length / 2.0); // если длина массива 10 то длина пополам 5, если длина массива 7 то длина пополам 4
    int fullength = array.Length;
    int length = array.Length/2;
    for (int i = 0; i < length; i++)
    {
       int buf = array[i];
       array[i] =array[fullength-i-1];
       array[fullength-i-1] = buf;
    }
    return array;
}

int[] array = newArray(10,20);
printArray(array);
int[] revers= reversArray(array);
printArray(revers);