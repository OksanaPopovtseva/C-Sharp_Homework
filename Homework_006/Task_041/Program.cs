// 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

//Программа
Console.Clear();
string[] myNumbers = GetMessage("Введите числа через запятую");

if (Array.TrueForAll(myNumbers, IsNumbersValid))
{
    int[] MyNums = GetNumbersInt(myNumbers);
    PrintArray(MyNums);
    int countIndex = CountPositive(MyNums);
    Console.WriteLine();
    Console.WriteLine("Количество чисел больше нуля = " + countIndex);
}
else
{
    Console.WriteLine("Ошибка");
}


// Метод для считывания строки
string[] GetMessage(string message)
{
    Console.WriteLine("Введите числа через запятую:");
    string userNumbers = Console.ReadLine();
    string[] userNums = userNumbers.Split(new char[] { ',', '.', ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);
    return userNums;
}


//Метод проверки данных на соотвествие int
bool IsNumbersValid(string values)
{
    int s;
    return int.TryParse(values.Substring(values.Length - 1), out s);
}


// Метод для перевода строки в массив чисел int
int[] GetNumbersInt(string[] val)
{
    int[] aNums = new int[val.Length];
    for (int i = 0; i < val.Length; i++)
    {
        aNums[i] = int.Parse(val[i]);
    }
    return aNums;
}


//Метод для вывода массива
void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + " | ");
    }
    Console.Write(arr[arr.Length - 1] + " ]");
}

//Метод для подсчета чисел больше нуля
int CountPositive(int[] zahlen)
{
    int count = 0;
    for (int i = 0; i < zahlen.Length; i++)
    {
        if (zahlen[i] > 0) count++;
    }
    return count;
}
