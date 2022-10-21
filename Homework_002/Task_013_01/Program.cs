// 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. 
// Решение 1. Испрользование string

Console.WriteLine("Введите число:");
string userNumber = Console.ReadLine();
int num = int.Parse(userNumber);
int numberLength = userNumber.Length;

if(num<0) numberLength = userNumber.Length-1;

if (numberLength >= 3 && num>0)
{
    Console.WriteLine("Третья цифра числа: " + userNumber[2]);
}
else if (numberLength >= 3 && num<0)
{
    Console.WriteLine("Третья цифра числа: " + userNumber[3]);
}
else
{
    Console.WriteLine("В числе нет третьей цифры");
}
