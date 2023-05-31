// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Input()
{
    Console.WriteLine("Введите число:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void DegreeAtoB(int count)
{
    int i = 1;
    int result = 0;
    while (0 < count)
    {
        int a = count % 10;
        result = result + a;
        count /= 10;
    }
    Console.WriteLine($"Сумма цифр в числе = {result}");
}
int number = Input();
DegreeAtoB(number);