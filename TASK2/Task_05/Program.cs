// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
using static System.Console;
Clear();
Write("Введите число А: ");
int A = int.Parse(ReadLine());
int sum = GetSum(A);
WriteLine($"Сумма от 1 до {A} = {sum}");







int GetSum(int number)
{
    int result = 0;
    for(int i = 1; i<=number; i++)
    {
        result+=i;
    }
    return result;
}

