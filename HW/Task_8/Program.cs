// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
using static System.Console;
Clear();
WriteLine("Введите пятизначное число: ");
int n = int.Parse(ReadLine());
if(n > 99999 || n < 10000)
{
    WriteLine("Введите всетаки пятизначное положительное число ");
}
else
{
    int partNfirst = n / 1000;
    int partNsecond = n % 100;
    if(partNfirst / 10 == partNsecond % 10 && partNfirst % 10 == partNsecond / 10 )
    {
        WriteLine($"Число {n} является палиндромом");
    }
    else
    {
        WriteLine($"Число {n} не является палиндромом");
    }
}