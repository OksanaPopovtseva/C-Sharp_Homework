// 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементом массива.

//Программа
string ArrayLen = GetValue("Введите длину массива");
string ArrayMinValue = GetValue("Введите минимальное значение");
string ArrayMaxValue = GetValue("Введите максимальное значение");

bool IsLenghtInt = IsNumberInt(ArrayLen);
bool IsMinDouble = IsNumberDouble(ArrayMinValue);
bool IsMaxDouble = IsNumberDouble(ArrayMaxValue);

if (IsLenghtInt && IsMinDouble && IsMaxDouble)
{
    int N = int.Parse(ArrayLen);
    double Min = double.Parse(ArrayMinValue);
    double Max = double.Parse(ArrayMaxValue);

    bool IsArrLenghtValid = IsLenghtValid(N);
    if (IsArrLenghtValid)
    {
        if (Min < Max)
        {
            double[] MyArray = CreateRandomArray(N, Min, Max);
            Console.WriteLine();
            PrintArray(MyArray);

            double Difference = GetMaxMinDifference(MyArray);
            Console.WriteLine();
            Console.WriteLine($"Разница между максимальным и минимальным значениями = {Difference}");
        }
        else
        {
            Console.WriteLine("Минимальное значение должно быть меньше максимального");
        }
    }
    else
    {
        Console.WriteLine("Длина массива должна быть больше 0");
    }
}
else
{
    Console.WriteLine("Недопустимые данные");
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

//Метод для проверки числа int
bool IsNumberInt(string valueB)
{
    int Exp2;
    bool IsIntNum = Int32.TryParse(valueB, out Exp2);
    if (IsIntNum)
        return true;
    return false;
}

//Метод для проверки длины массива
bool IsLenghtValid(int num)
{
    if (num > 0)
        return true;
    return false;
}

//Метод для создания рандомного массива
double[] CreateRandomArray(int N, double min, double max)
{
    double[] array = new double[N];
    Random rnd = new Random();
    for (int i = 0; i < N; i++)
    {
        array[i] = Math.Round(min + rnd.NextDouble() * (max - min), 3);

    }
    return array;
}

//Метод для вывода массива
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + " | ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

//Метод для поиска максимума и минимума в массиве
double GetMaxMinDifference(double[] array1)
{
    double Maximum = array1[0];
    double Minimum = array1[0];
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] > Maximum)
        {
            Maximum = array1[i];
        }
        else if (array1[i] < Minimum)
        {
            Minimum = array1[i];
        }
    }
    double result = Maximum - Minimum;
    return result;
}
