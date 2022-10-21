// 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное целое число:");
string userNumber = Console.ReadLine();
int number = int.Parse(userNumber);

//метод, показывающий вторую цифру из трёхзначного числа
int secondDigit(int num)
{
    int result1 = num / 10;
    int resutl2 = result1 % 10;
    return resutl2;
}

// основное тело программы
if (number > 99 && number < 1000)
{
    int secDigit = secondDigit(number);
    Console.WriteLine("Вторая цифра числа: " + secDigit);
}
else
{
    Console.WriteLine("Недопустимое значение. Введите трёхзначное целое число");
}
