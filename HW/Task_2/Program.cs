using static System.Console;
// Задача 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Clear();
WriteLine("Введите первое число: ");
int number1 = int.Parse(ReadLine());
WriteLine("Введите второе число: ");
int number2 = int.Parse(ReadLine());
WriteLine("Введите третье число: ");
int number3 = int.Parse(ReadLine());
int max = number1;
if(number2 > max) max = number2;
if(number3 > max) max = number3;
Write("Максимальное число ");
WriteLine(max);