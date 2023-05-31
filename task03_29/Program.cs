// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

string ArrayInput()
{
    int[] array = new int[8];
    int lenght = array.Length;
    string result = String.Empty;
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(0,100);
        result = result + array[i] + ", ";
    }
    return result;
}
string arr = ArrayInput();
Console.Write($"[{arr}]");