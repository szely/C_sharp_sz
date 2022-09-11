// Вывести квадраты чисел от 1 до N таблица квадратов
// using static System.Console;
// Clear();
// WriteLine("Введите число:");
// int n = Convert.ToInt32(ReadLine());
// int count = 1;
// while(n > count)
// {
//     int sqr = count * count;
//     WriteLine($"{count}^2 = {sqr}");
//     count++;
// }
using static System.Console;
Clear();
WriteLine("Введите число:");
int n = Convert.ToInt32(ReadLine());
for(int count = 1; n > count; count++)
{
    int sqr = count * count;
    WriteLine($"{count}^2 = {sqr}");
}

