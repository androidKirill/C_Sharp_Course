﻿// 2. Напишите программу, которая принимает
//    на вход число и выдаёт сумму цифр в числе.


int SumNums(int num)
{
    int n_sum = 0;

    while (num > 0)
    {
        n_sum += num % 10;
        num /= 10;
    }
    return n_sum;
}

Console.WriteLine(SumNums(int.Parse(Console.ReadLine())));


// --------------------------------- 2 вариант

int SumNums_1(int num)
{
    int n_sum = 0;

    for (int i = num; num != 0; num /= 10)
        n_sum += num % 10;

    return n_sum;
}

Console.WriteLine(SumNums_1(int.Parse(Console.ReadLine())));


// --------------------------------- 3 вариант
// https://shwanoff.ru/char-c-sharp/


double DigitSum(int num)
{
    string n = num.ToString();
    int length = n.Length;
    double sum = 0;

    for (int i = 0; i < length; i++)
    {
        double m = char.GetNumericValue(n[i]);
        sum += m;
    }

    return sum;
}

Console.WriteLine(DigitSum(int.Parse(Console.ReadLine())));