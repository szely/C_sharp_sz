using static System.Console;
// Задача 1
Clear();
WriteLine("Введите первое число: ");
int a = int.Parse(ReadLine());
Write("Введите второе число: ");
int b = int.Parse(ReadLine());
//if(b == a * a)
if(b == Convert.ToInt32(Math.Sqrt(a)))
{
    WriteLine("Второе число равно квадрату первого");
}
else
{
    WriteLine("Второе число не равно квадрату первого");
}