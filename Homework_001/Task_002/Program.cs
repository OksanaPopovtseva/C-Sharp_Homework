// 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число:");
string number1 = Console.ReadLine();
int a = int.Parse(number1);
Console.WriteLine("Введите второе число:");
string number2 = Console.ReadLine();
int b = int.Parse(number2);
int max = a;
int min = 0;

if(max>b)
{
    max=a;
    min=b;
}
else
{
    max=b;
    min=a;
}
Console.Write(max);
Console.Write(" больше, чем ");
Console.Write(min);