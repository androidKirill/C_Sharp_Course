// 1. Напишите программу, которая принимает на вход трёхзначное число
//    и на выходе показывает вторую цифру этого числа.

string NumSec(int num)
{   
    if (num < 1000)
        return $"{num / 10 % 10}";
    return "The number is not three-digit!";
}

Console.WriteLine(NumSec(int.Parse(Console.ReadLine())));