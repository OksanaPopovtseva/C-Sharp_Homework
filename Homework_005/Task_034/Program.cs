// 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

//Программа
int N = GetNumber("Введите длину массива");
if(N>0)
{
int[] myArray = CreateRandomArray(N);
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine($"Количество чётных элементов в массиве равно {GetCount(myArray)}");
}
else
{
    Console.WriteLine("Ошибка. Длина массива должна быть больше нуля");
}

// Метод считывания числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

//Метод для создания рандомного массива
int[] CreateRandomArray(int N)
{
    int[] array = new int[N];
    Random r = new Random();
    for (int i = 0; i < N; i++)
    {
        array[i] = r.Next(100, 1000);
    }
    return array;
}

// Метод для подсчёта чётных чисел в масиве
int GetCount(int[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] % 2 == 0)
            count++;
    }
    return count;
}

//Метод для вывода массива
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length-1] + "]");
}
