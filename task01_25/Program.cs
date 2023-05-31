// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Input()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void DegreeAtoB(int a, int b)
{
    int i = 1;
    int result = a;
    while (i < b)
    {
        result = result*a;
        i++;
    }
    Console.WriteLine($"{a} в {b} степени = {result}");
}
Console.WriteLine("Введите число A:");
int numA = Input();
Console.WriteLine("Введите число B:");
int numB = Input();
DegreeAtoB(numA, numB);