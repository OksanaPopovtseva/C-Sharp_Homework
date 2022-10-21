// 23: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// Метод для считывания числа N
int GetValue (string message)
{
    int N = Convert.ToInt32(message);
    return N;
}

// Метод, выводящий кубы чисел от 1 до N
void CubeNumbers (int Number)
{
    if(Number>0)
    {
        for(int i=1; i<Number; i++)
        {
            Console.Write(Math.Pow(i,3)+", ");
        }
        Console.Write(Math.Pow(Number,3));
    }
    else if(Number<0)
    {
        for(int i=Number;i<-1;i++)
        {
            Console.Write(Math.Pow(i,3)+", ");
        }
        Console.Write(Math.Pow(-1,3));
    }
    else
    {
        Console.WriteLine("Ошибка. Введите целое число, отличное от нуля");
    }
}

// Программа
Console.WriteLine("Введите число:");
string value = Console.ReadLine();
int Num;
bool isNum = Int32.TryParse(value, out Num);

if (isNum)
{
    int n = GetValue(value);
    CubeNumbers(n);
}
else
{
    Console.WriteLine("Ошибка. Введите число");
}
