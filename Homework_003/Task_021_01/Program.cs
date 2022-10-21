// 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// Способ 1. Без массивов

// Метод для ввода и считывания координат
double GetCoordinate(string message)
{
    Console.WriteLine(message);
    double a = double.Parse(Console.ReadLine());
    return a;
}

// Метод для рассчета расстояния
double Distance(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double Dis = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
    Dis = Math.Round(Dis, 2);
    return Dis;
}

// Программа
double xA = GetCoordinate("Введите координату x для точки A");
double xB = GetCoordinate("Введите координату x для точки B");
double yA = GetCoordinate("Введите координату y для точки A");
double yB = GetCoordinate("Введите координату y для точки B");
double zA = GetCoordinate("Введите координату z для точки A");
double zB = GetCoordinate("Введите координату z для точки B");

Console.WriteLine("Расстояние между точками A и B = " + Distance(xA, xB, yA, yB, zA, zB));
