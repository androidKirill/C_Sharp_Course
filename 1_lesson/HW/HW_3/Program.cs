// 3. Напишите программу, которая на вход принимает число и выдаёт,
//    является ли число чётным (делится ли оно на два без остатка).

int n_1 = int.Parse(Console.ReadLine());

if (n_1 % 2 == 0)
{
    Console.Write($"The number {n_1} is even");
}
else
{
    Console.Write($"The number {n_1} is odd");
}
