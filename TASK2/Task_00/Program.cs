// using static System.Console;
// Clear();
// WriteLine("Введите число ");
// int n = Convert.ToInt32(ReadLine());
// // string answer = n % 2 == 0? "Yes" : "No";
// WriteLine(n % 2 == 0? "Yes" : "No");

// using static System.Console;
// Clear();
// Write("Введите число A: ");
// int a = Convert.ToInt32(ReadLine());
// Write("Введите число B: ");
// int b = Convert.ToInt32(ReadLine());
// // string answer = a > b? "a>b" : a<b ? "a<b" : "a=b";
// // WriteLine(answer);
// WriteLine(a > b? "a>b" : a<b ? "a<b" : "a=b");

// using static System.Console;
// Clear();
// Write("Введите число A: ");
// int a = Convert.ToInt32(ReadLine());
// Write("Введите число B: ");
// int b = Convert.ToInt32(ReadLine());
// Write("Введите число C: ");
// int c = Convert.ToInt32(ReadLine());
// int max = a;
// max = max<b?b 
// // WriteLine(answer);
// WriteLine(a > b? "a>b" : a<b ? "a<b" : "a=b");

using static System.Console;
Clear();
WriteLine("Введите число ");
int a = Convert.ToInt32(ReadLine());
// if(a==1)
// {
//     WriteLine("Понедельник");
// }
switch(a)
{
    case 1:
    {
        WriteLine("Раб");
        break;
    }
    case 2:
    {
        WriteLine("Раб");
        break;
    }
    case 3:
    {
        WriteLine("Раб");
        break;
    }
    case 4:
    {
        WriteLine("Раб");
        break;
    }
    case 5:
    {
        WriteLine("Раб");
        break;
    }
    case 6:
    {
        WriteLine("Вых");
        break;
    }
    case 7:
    {
        WriteLine("Вых");
        break;
    }
    default:
    {
        WriteLine("Это не день недели");
        break;
    }
}