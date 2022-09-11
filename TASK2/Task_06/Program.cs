// **Задача 26:**
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

using static System.Console;
Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine());
int count = CountDigilal(number);
WriteLine($"Количество цифр в числе {number} = {count}");



int CountDigilal(int number)
{
    int count = 0;
    while(number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}



