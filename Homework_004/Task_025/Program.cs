// 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Применять Math.Pow нельзя!

//Метод для проверки числа double
bool IsNumberDouble(string valueA)
{
    double Exp1;
    bool IsDoubleNum = double.TryParse(valueA, out Exp1);
    if (IsDoubleNum)
        return true;
    return false;
}

//Метод для проверки числа int
bool IsNumberInt(string valueB)
{
    int Exp2;
    bool IsIntNum = Int32.TryParse(valueB, out Exp2);
    if (IsIntNum)
        return true;
    return false;
}

//Метод для проверки степени
bool IsDegreeValid(int num)
{
    if (num >= 0)
        return true;
    return false;
}

//Метод для возведения в степень
double Exponentation(double num1, int num2)
{
    double value = num1;
    if (num2 == 0)
    {
        value = 1;
    }
    else
    {
        for (int i = 1; i < num2; i++)
        {
            value = value * num1;
        }
    }
    return value;
}

//Программа
Console.WriteLine("Введите число:");
string numberA = Console.ReadLine();
Console.WriteLine("Введите степень:");
string numberB = Console.ReadLine();

bool IsDoubleValid = IsNumberDouble(numberA);
bool IsIntValid = IsNumberInt(numberB);

if (IsDoubleValid && IsIntValid)
{
    double A = double.Parse(numberA);
    int B = int.Parse(numberB);
    bool IsValid = IsDegreeValid(B);
    if (IsValid)
    {
        double Expo = Exponentation(A, B);
        Console.WriteLine($"{A} в степени {B} равно {Expo}");
    }
}
else
{
    Console.WriteLine("Неверные данные");
}

