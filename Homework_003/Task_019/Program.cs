// 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// Метод, определяющий является ли число палиндромом
void Palindrom(int number)
{
    int n1 = number / 10000;
    int n2 = number % 10;
    int n3 = number / 1000 % 10;
    int n4 = number / 10 % 10;
    if (n1 == n2 && n3 == n4)
    {
        Console.WriteLine("Число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом.");
    }
}

// Программа
Console.WriteLine("Введите число:");
string value = Console.ReadLine();
int Num;
bool isNum = Int32.TryParse(value, out Num);
if (isNum)
{
    int valueToInt = int.Parse(value);
    int num = Math.Abs(valueToInt);
    int numDigit = (int)Math.Log10(num) + 1;
    if (numDigit == 5)
    {
        Palindrom(num);
    }
    else
    {
        Console.WriteLine("Ошибка. Введите пятизначное число");
    }
}
else
{
    Console.WriteLine("Ошибка. Введите число");
}
