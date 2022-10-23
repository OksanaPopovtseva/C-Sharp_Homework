// 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

//Программа
int n = new Random().Next(1, 10);
int m = new Random().Next(1, 10);
int[,] myMartix = CreateMatrix(n, m, 1, 100);
PrintMatrix(myMartix);

string rowNumber = GetValue("Введите номер строки");
string columnNumber = GetValue("Введите номер столбца");
bool isRowInt = IsNumberInt(rowNumber);
bool isColumnInt = IsNumberInt(columnNumber);

if (isRowInt && isColumnInt)
{
    int aRow = int.Parse(rowNumber);
    int aColmn = int.Parse(columnNumber);
    bool isRowValid = IsNumberValid(aRow);
    bool isColmnValid = IsNumberValid(aColmn);

    if (isRowValid && isColmnValid)
    {
        bool isPosExcist = IsPositionExcist(myMartix, aRow, aColmn);
        if (isPosExcist)
        {
            Console.WriteLine("Значение в массиве:");
            Console.WriteLine(myMartix[aRow, aColmn]);
        }
        else
        {
            Console.WriteLine("Такой позиции в массиве не существует");
        }
    }
    else
    {
        Console.WriteLine("Ошибка. Введите число больше или равное 0");
    }
}
else
{
    Console.WriteLine("Неверные данные. Введите целое число");
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

//Метод для проверки числа
bool IsNumberValid(int num)
{
    if (num >= 0)
        return true;
    return false;
}


// Метод для создания двумерного массива, заполненного рандомно
int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] aMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            aMatrix[i, j] = new Random().Next(min, max);
        }
    }
    return aMatrix;
}

// Метод для печати двумерного массива
void PrintMatrix(int[,] bMatrix)

{
    for (int i = 0; i < bMatrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < bMatrix.GetLength(1); j++)
        {
            Console.Write($"{string.Format("{0,2} ", bMatrix[i, j])} | ");
        }
        Console.WriteLine();
    }
}

// Метод для проверки начилия введёной позиции в массиве
bool IsPositionExcist(int[,] array, int a, int b)
{
    if (a > array.GetLength(0) || b > array.GetLength(1))
        return false;
    return true;
}

