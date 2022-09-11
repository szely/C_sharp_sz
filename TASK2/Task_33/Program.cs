// Напишите программу которая на вход будет принимать число и возвращать сумму его чисел

using static System.Console;
using System.Linq;
Clear();

Write("Введите число N: ");
int num = int.Parse(ReadLine());
WriteLine($"{GetSumNumbers(num)}");


int GetSumNumbers(int n)
{
    return (n>0)? n%10+GetSumNumbers(n/10):0;
}