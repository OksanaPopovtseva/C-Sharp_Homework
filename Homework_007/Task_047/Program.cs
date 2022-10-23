// 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// Программа
Console.Clear();
string rowsValue = GetValue("Введите количество строк массива:");
string columnsValue = GetValue("Введите количество столбцов массива:");
bool isRowsValid = IsNumberInt(rowsValue);
bool isColumnsValid = IsNumberInt(columnsValue);

if (isRowsValid && isColumnsValid)
{
    int n = int.Parse(rowsValue);
    int m = int.Parse(columnsValue);
    bool isNValid = IsLenghtValid(n);
    bool isMValid = IsLenghtValid(m);

    if (isNValid && isMValid)
    {
        double[,] myMatrix = GetRandomMatrix(n,m,-100,100);
        PrintMatrix(myMatrix);
    }
    else
    {
        Console.WriteLine("Ошибка. Введите число больше 0");
    }
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

// Метод для создания рандомного двумерного массива
double[,] GetRandomMatrix(int rows, int columns, double min, double max)
{
    double[,] array = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = Math.Round(min + rnd.NextDouble() * (max - min), 2);
        }
    }
    return array;
}

// Метод для печати двумерного массива
void PrintMatrix(double[,] bMatrix)
{
    for (int i = 0; i < bMatrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < bMatrix.GetLength(1); j++)
        {
            Console.Write($"{string.Format("{0,6} ", bMatrix[i, j])} | ");
        }
        Console.WriteLine();
    }
}