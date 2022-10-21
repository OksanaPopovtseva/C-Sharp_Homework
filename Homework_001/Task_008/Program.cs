// 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
string number1 = Console.ReadLine();
int a = int.Parse(number1);
int b = 1;
Console.Write(" | ");

while (b <= a)
{
    if (b % 2 == 0)
    {
        Console.Write(b);
        Console.Write(" | ");
    }
    b = b + 1;
}