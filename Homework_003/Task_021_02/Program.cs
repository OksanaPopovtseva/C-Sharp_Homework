// 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// Способ 2. С использованием массивов.

// Метод для заполнения массива
void FillArray(double[] array, string message)
{
    for(int i=0;i<array.Length;i++)
    {
        Console.WriteLine(message);
        array[i]=double.Parse(Console.ReadLine());
    }
}

// Метод для вывода массива
void PrintArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} | ");
    }
}

// Метод для рассчета расстояния
double Distance(double[] array1, double[]array2)
{
    double Dis = Math.Sqrt(Math.Pow(array1[0] - array2[0], 2) + Math.Pow(array1[1] - array2[1], 2) + Math.Pow(array1[2] - array2[2], 2));
    Dis = Math.Round(Dis, 2);
    return Dis;
}

// Программа
Console.Clear();
double[] A = new double [3];
FillArray(A,"Введите координату точки A");
double[] B = new double [3];
FillArray(B,"Введите координату точки B");
Console.WriteLine();
Console.WriteLine("Координаты точки A");
PrintArray(A);
Console.WriteLine();
Console.WriteLine("Координаты точки B");
PrintArray(B);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Расстояние между точками = " + Distance(A,B));
Console.WriteLine();
