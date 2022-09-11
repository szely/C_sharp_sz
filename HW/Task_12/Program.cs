// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintSum(number, SumNumbers(number));

int SumNumbers(int n)
{
    int sum = 0;
    while(n/10 > 0)
    {
        int m = n % 10;
        sum = sum + m;
        n = n/10;
    }
    sum = sum + n;
    return sum;
}

void PrintSum(int i, int s)
{
    Console.WriteLine($"Суммма цифр в числе {i} равна: {s}");
}