Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine(stringNumber[1]);

///////////

Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
    Console.WriteLine(anyNumberText[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}

/////
void CheckingTheDayOfTheWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("да");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("это вообще не день недели");
    }
    else Console.WriteLine("нет");
}

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

CheckingTheDayOfTheWeek(dayNumber);

/////////// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());
int qrt1 = qrt(num1);
int qrt2 = qrt(num2);

if (qrt1 == num2 || qrt2 == num1)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}

int qrt(int a)
{
    return a * a;
}
