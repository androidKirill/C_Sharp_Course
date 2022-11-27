// 3. Напишите программу, которая выводит третью цифру
//    заданного числа или сообщает, что третьей цифры нет.

// ----------------------------------- 1 вариант


void ThirdNum(int num)
{
    Console.Write($"{num} -> ");
    if (num < 99)
    {
        Console.WriteLine("there is no third digit");
        return;
    }

    while (num > 999) num /= 10;
    Console.WriteLine(num % 10);
}

ThirdNum(int.Parse(Console.ReadLine()));


// ----------------------------------- 2 вариант


void ThirdNum_1(int num)
{
    Console.Write($"{num} -> ");
    int tr_num = -1;
    string txt;
    
    while (num > 99)
    {
        tr_num = num % 10;        
        num = num / 10; 
    }
    txt = $"{tr_num}";
    if (tr_num == -1)
    {
        txt = "there is no third digit";        
    }
    Console.WriteLine(txt);    
}

ThirdNum_1(641);
ThirdNum_1(32879);
ThirdNum_1(32079);
ThirdNum_1(78);