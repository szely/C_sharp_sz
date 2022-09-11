//14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да
Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
int result1 = number1 % 7;
int result2 = number1 % 23;
if(result1 == 0 & result2 == 0)
{
    Console.WriteLine("Число кратно 7 и 23");
}
    else
{
    Console.WriteLine("Число не кратно 7 и 23");
}
