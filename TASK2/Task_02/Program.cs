//Задача 18 выввести по номеру четверти значения координвт
using static System.Console;
Clear();
WriteLine("Введите номер четверти: ");
int n = Convert.ToInt32(ReadLine());
switch(n)
{
    case 1:
    {
        WriteLine("x>0, y>0");
        break;
    }
    case 2:
    {
        WriteLine("x<0, y>0");
        break;
    }
    case 3:
    {
        WriteLine("x<0, y<0");
        break;
    }
    case 4:
    {
        WriteLine("x>0, y<0");
        break;
    }
    default:
    {
        WriteLine("Нет такой четверти");
        break;
    }
}