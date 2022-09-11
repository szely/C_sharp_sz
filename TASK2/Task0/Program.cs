using static System.Console;
// Задача 0
Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine());
int sqr1 = Convert.ToInt32(Math.Pow(number,2));
int sqr = number * number;
WriteLine($"Квадрат числа {number} = {sqr}");
WriteLine($"Квадрат числа {number} = {sqr1}");