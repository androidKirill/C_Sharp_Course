// 3. Напишите программу, которая принимает на вход число (N) 
//    и выдаёт таблицу квадратов чисел от 1 до N.


void Squares(int num)
{
    int i = 1;
    Console.Write($"{num} -> ");

    while (num >= i)
    {
        Console.Write($"{Math.Pow(i, 2)}, ");
        i++;
    }
    Console.WriteLine();
}

Squares(5);
Squares(11);


// 2 вариант

void Squares_1(int n)
{
    double[] nums = new double[n];
    int index = 0;

    Console.Write($"{n} -> ");

    while (index < n)
    {
        nums[index] = Math.Pow((index + 1), 2);
        Console.Write($"{nums[index]}, ");
        index += 1;
    }    
    Console.WriteLine();
}

Squares_1(6);
Squares_1(2);
Squares_1(11);


// 3 вариант

double[] Squares_2(int n)
{
    double[] nums = new double[n];
    int index = 0;

    while (index < n)
    {
        nums[index] = Math.Pow((index + 1), 2);
        index += 1;
    }

    return nums;
}

void PrintList(int num)
{
    double[] arr = Squares_2(num); 
    int index = 0;
    
    Console.Write($"{num} -> ");

    while (index < arr.Length)
    {
        Console.Write($"{arr[index]}, ");
        index += 1;
    }
}

PrintList(6);
