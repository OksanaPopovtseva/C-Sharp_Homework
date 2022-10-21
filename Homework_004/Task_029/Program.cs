// 29: Напишите программу, которая задаёт массив из N элементов и 
// выводит их на экран.
// (на входе N - длина массива, min и max - ограничения для значений  
// элементов массива, которые лежат в [min, max])


// Метод на принятие данных
string GetMessage(string message)
{
    Console.WriteLine(message);
    string mes = Console.ReadLine();
    return mes;
}

//Метод для проверки числа int
bool IsNumberInt(string value)
{
    int Exp;
    bool IsIntNum = Int32.TryParse(value, out Exp);
    if (IsIntNum)
        return true;
    return false;
}


// Метод перевода строки в число
int GetNum(string value)
{
    int num = int.Parse(value);
    return num;
}


//Метод для заполнения массива
void FillArray(int[] Arr, int min, int max)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = new Random().Next(min, max + 1);
    }
}

// Метод для упорядочивания массива от min к max
void ArrayOrder(int[] Array1)
{
    for (int i = 0; i < Array1.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < Array1.Length; j++)
        {
            if (Array1[j] < Array1[maxPosition]) maxPosition = j;
        }

        int temporary = Array1[i];
        Array1[i] = Array1[maxPosition];
        Array1[maxPosition] = temporary;
    }
}

// Метод для печати массива
void PrintArray(int[] ArrB)
{
    Console.Write("[ ");
    for (int j = 0; j < ArrB.Length - 1; j++)
    {
        Console.Write(ArrB[j] + ", ");
    }
    Console.Write($"{ArrB[ArrB.Length - 1]} ]");
}

// Программа
string arrayLength = GetMessage("Введите длину массива");
string arrayMin = GetMessage("Введите минимальное значение");
string arrayMax = GetMessage("Введите максимальное значение");
bool IsLengthInt = IsNumberInt(arrayLength);
bool IsMinInt = IsNumberInt(arrayMin);
bool IsMaxInt = IsNumberInt(arrayMax);

if (IsLengthInt && IsMinInt && IsMaxInt)
{
    int N = GetNum(arrayLength);
    int Min = GetNum(arrayMin);
    int Max = GetNum(arrayMax);
    if (N > 0)
    {
        if (Min < Max)
        {
            int[] Array = new int[N];
            FillArray(Array, Min, Max);
            ArrayOrder(Array);
            PrintArray(Array);
        }
        else
        {
            Console.WriteLine("Ошибка в данных."
            + "Минимальное значение должно быть меньше максимального");
        }
    }
    else
    {
        Console.WriteLine("Ошибка в данных. Длина массива должна быть больше 0");
    }
}
else
{
    Console.WriteLine("Неверные данные. Введите целое число");
}
