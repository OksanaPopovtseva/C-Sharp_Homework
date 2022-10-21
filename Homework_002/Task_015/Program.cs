// 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7:");
string userNumber = Console.ReadLine();
int num = int.Parse(userNumber);

// Метод, определяющий выходной день или нет
void dayName(int dayNum)
{
    if (dayNum >= 1 && dayNum < 6)
    {
        Console.WriteLine("Рабочий день");
    }
    else
    {
        Console.WriteLine("Выходной");
    }
}

// Основное тело программы
if(num>=1 && num<8)
{
    dayName(num);
}
else
{
    Console.WriteLine("Недопустимое значение. Введите число от 1 до 7");
}
