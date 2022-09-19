// Написать программу, которая из имеющегося массива строк формирует новый 
// массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный
// массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] arrayStart = new string[4] {"Hello", "2", "world", ":-)"};
string[] arrayFinish = new string[arrayStart.Length];

void CreatingArrayFinish(string[] arrayStart, string[] arrayFinish)
{
    int pos = 0;
    for (int i = 0; i < arrayStart.Length; i++)
    {
        if (arrayStart[i].Length <= 3)
        {
            arrayFinish[pos] = arrayStart[i];
            pos++;
        }
    }
}

void PrintArray(string[] array)
{
   Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

CreatingArrayFinish(arrayStart, arrayFinish);
PrintArray(arrayStart);
Console.WriteLine();
PrintArray(arrayFinish);
