using static System.Console;
// Задача 4
Clear();
WriteLine("Введите трехзначное число: ");
int number = int.Parse(ReadLine());
int last = number % 10;
WriteLine(last);