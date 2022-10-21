// 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// Выводим значение x из уравнения:
// k1 * x + b1 = k2 * x + b2
// x * (k1-k2)= b2 - b1
// x = (b2 - b1) / (k1 - k2)


//Программа
Console.Clear();
string num1 = GetValue("Введите первое число:");
string num2 = GetValue("Введите второе число:");
string num3 = GetValue("Введите третье число:");
string num4 = GetValue("Введите четвёртое число:");

bool IsNum1Double = IsNumberDouble(num1);
bool IsNum2Double = IsNumberDouble(num2);
bool IsNum3Double = IsNumberDouble(num3);
bool IsNum4Double = IsNumberDouble(num4);

if(IsNum1Double && IsNum2Double && IsNum3Double && IsNum4Double)
{
    double b1 = GetDouble(num1);
    double b2 = GetDouble(num2);
    double k1 = GetDouble(num3);
    double k2 = GetDouble(num4);

    FindPoint(b1,b2,k1,k2);
}
else
{
    Console.WriteLine("Неверные данные");
}


// Метод для считывания строки
string GetValue(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    return value;
}

//Метод для проверки числа double
bool IsNumberDouble(string valueA)
{
    double Exp1;
    bool IsDoubleNum = double.TryParse(valueA, out Exp1);
    if (IsDoubleNum)
        return true;
    return false;
}

//Метод для перевода числа в double
double GetDouble(string val)
{
    double n = double.Parse(val);
    return n;
}


//Метод для вычисления координат
void FindPoint (double B1, double B2, double K1, double K2)
{
    if(K1-K2 == 0)
    {
        Console.WriteLine("Ошибка");
    }
    else
    {
    double x = Math.Round((B2 - B1) / (K1 - K2),2);
    double y = Math.Round(K1 * x + B1,2);
    Console.WriteLine($"Координаты точки, в которой прямые пересекутся = ({x}, {y})");
    }
}
