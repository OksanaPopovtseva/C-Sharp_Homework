// 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

//Метод для проверки числа int
bool IsNumberInt(string value)
{
    int Exp;
    bool IsIntNum = Int32.TryParse(value, out Exp);
    if (IsIntNum)
        return true;
    return false;
}

//Метод для подсчета суммы цифр в числе
int SumDigits(int A)
{
    int sumDig = 0;
    while (A > 0)
    {
        sumDig = sumDig + A % 10;
        A = A / 10;
    }
    return sumDig;
}

// Программа
Console.WriteLine("Введите число");
string aNumber = Console.ReadLine();
bool IsNumber = IsNumberInt(aNumber);
if (IsNumber)
{
    int N = Math.Abs(int.Parse(aNumber));
    Console.WriteLine($"Сумма цифр в числе {aNumber} будет равна {SumDigits(N)}");
}
else
{
    Console.WriteLine("Неверные данные");
}
