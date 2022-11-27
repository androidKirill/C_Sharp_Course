// 2. Напишите программу, которая выводит случайное
//    трёхзначное число и удаляет вторую цифру этого числа.

string SecondNum(int num)
{   
    if (num < 1000)
        return $"{num} -> {num / 100 * 10 + num % 10}";
    return "The number is not three-digit!";       
}

Console.WriteLine(SecondNum(int.Parse(Console.ReadLine())));


void NumRendom()
{   
    int num = new Random().Next(100, 1000);
    Console.WriteLine($"{num} -> {num / 100}{num % 10}");    
}

NumRendom();


