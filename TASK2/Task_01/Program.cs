//Задача 17 выввести номер четверти по координатам
using static System.Console;
Clear();
WriteLine("Введите координату x: ");
int x = Convert.ToInt32(ReadLine());
WriteLine("Введите координату y: ");
int y = Convert.ToInt32(ReadLine());
if(x > 0 & y > 0)
{
    WriteLine("Это I четверть");
}
if(x < 0 & y > 0)
 {
    WriteLine("Это II четверть");
}
if(x < 0 & y < 0)
{
    WriteLine("Это III четверть");
}
else
{
    WriteLine("Это IV четверть");
}