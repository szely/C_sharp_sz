// Задайте массив напишите программу которая определяет присутствует ли число в массиве

using static System.Console;

Clear();
WriteLine("Введите челое число: ");
int n = int.Parse(ReadLine());
int[] array = GetArray(10, -10, 10);
PrintArray(array);
WriteLine(FindNumber(array, n));



int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue+1);
    }
    return result;
}

bool FindNumber(int[] mass, int number)
{
    foreach(int item in mass)
    {
            if(item == number) 
            {
                return true;  
                break;
            }
    }
return false;
}

void PrintArray(int[] mass)
{
    WriteLine($"[{String.Join(",",mass)}]");
}


