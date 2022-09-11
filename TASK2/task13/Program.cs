//16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет
Console.Clear();
Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
if(number1 == number2 * number2)
{
    Console.WriteLine("Одно число является квадратом второго");
}
else
{
    if(number2 == number1 * number1)
    {
        Console.WriteLine("Одно число является квадратом второго");
    }
    else
    {
        Console.WriteLine("Одно число не является квадратом второго");
    }
}