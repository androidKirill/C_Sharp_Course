// 4. Напишите программу вычисления модуля числа.

string s_N = Console.ReadLine();
int N = int.Parse(s_N);

if (N < 0)
{
    N = -N;
}

Console.Write(N);