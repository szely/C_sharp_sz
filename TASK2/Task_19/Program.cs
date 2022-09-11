// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

using static System.Console;
Clear();
WriteLine("Введите число: ");
int number10 = int.Parse(ReadLine());
WriteLine(System2(number10));

string System2(int number)
{
    string result = "";
    while (number > 0)
    {
        result = number % 2 + result;
        number /= 2;
    }
    return result;
}

// using static System.Console;
// using System.Linq;
// Clear();
// WriteLine("Введите число:");

// int num = int.Parse(ReadLine()!);
// WriteLine(Convert.ToString(num,8));
// WriteLine(GetNum1(num));
// WriteLine(DecToNum(num,8));


// string GetNum1(int number)
// {
//     string result="";

//     while(number>0)
//     {
//         result=number%8+result;
//         number/=8;
//     }
//     return result;
// }

// string DecToNum(int decNumber, int otherSystem)
// {
//     string res="";
//     string nums="0123456789ABCDEF";
//     while(decNumber>0)
//     {
//         int ost=decNumber/otherSystem;
//         res=nums[decNumber-otherSystem*ost]+res;
//         decNumber/=otherSystem;
//     }
//     return res;
// }

// string DecToNum1(int decNumber, int otherSystem)
// {
//     string res="";
//     string nums="0123456789ABCDEF";
//     while(decNumber>0)
//     {
//         int ost=decNumber%otherSystem;
//         res=nums[ost]+res;
//         decNumber/=otherSystem;
//     }
//     return res;
// }

