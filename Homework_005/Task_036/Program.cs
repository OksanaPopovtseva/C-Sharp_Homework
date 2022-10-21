// 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// Программа
int N = GetNumber("Введите длину массива");
if (N > 0)
{
    int min = GetNumber("Введите минимум для элементов");
    int max = GetNumber("Введите максимум для элементов");
    if (min < max)
    {
        int[] myArray = CreateRandomArray(N, min, max);
        PrintArray(myArray);
        Console.WriteLine();
        Console.WriteLine("Сумма элементов на нечётных позициях = " + GetCountUneven(myArray));
    }
    else
    {
        Console.WriteLine("Ошибка. Минимум должен быть меньше максимума");
    }
}
else
{
    Console.WriteLine("Ошибка. Длина массива должна быть больше 0");
}



// Метод считывания числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

//Метод для создания рандомного массива
int[] CreateRandomArray(int N, int min, int max)
{
    int[] array = new int[N];
    Random r = new Random();
    for (int i = 0; i < N; i++)
    {
        array[i] = r.Next(min, max + 1);
    }
    return array;
}

//Метод для вывода массива
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

// Метод для подсчёта элементов на нечетных позициях
int GetCountUneven(int[] array1)
{
    int sum = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (i % 2 > 0)
            sum += array1[i];
    }
    return sum;
}
