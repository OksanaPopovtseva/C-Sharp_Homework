// 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. 
// Решение 2. Математический метод

Console.WriteLine("Введите число:");
string userNumber = Console.ReadLine();
int num = int.Parse(userNumber);

if(num<0) num=num*(-1);

int numLength = (int)Math.Log10(num) + 1;

//Метод, определяющий третью цифру в числе
int thirdDigit(int dig)
{
    int result1 = numLength - 3;
    double result2 = Math.Pow(10, result1);
    int a = (int)result2;
    int result3 = num / a;
    int result = result3 % 10;
    return result;
}

// Основное тело программы
if (numLength >= 3)
{
    int thirdDig = thirdDigit(num);
    Console.WriteLine("Третья цифра числа: " + thirdDig);
}
else
{
    Console.WriteLine("В числе нет третьей цифры");
}
