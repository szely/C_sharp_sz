// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4  -> 24
// 5  -> 120

using static System.Console;
Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine());
int sum = GetSum(number);
WriteLine($"Сумма от 1 до {number} = {sum}");



int GetSum(int number)
{
    int result = 1;
    for(int i = 1; i<=number; i++)
    {
        result*=i;
    }
    return result;
}


