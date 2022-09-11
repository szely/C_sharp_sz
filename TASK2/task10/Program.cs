//11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

int randomNumber = new Random().Next(100,999);
Console.WriteLine(randomNumber);
int firstDigit = randomNumber / 100;
Console.Write(firstDigit);
int secondDigit = randomNumber % 10;
Console.WriteLine(secondDigit);

