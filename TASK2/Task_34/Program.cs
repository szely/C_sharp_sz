// Принимае два числа и возводит одно в степень другого

using static System.Console;
using System.Linq;
Clear();

Write("Введите число A: ");
int a = int.Parse(ReadLine());
Write("Введите число B: ");
int b = int.Parse(ReadLine());
WriteLine($"{GetSumNumbers(a, b)}");


int GetSumNumbers(int num1, int num2)
{
    return (num2 > 0) ? num1 * GetSumNumbers(num1, num2 - 1):1;
}
