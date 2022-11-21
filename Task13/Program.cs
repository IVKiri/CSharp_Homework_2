// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = new Random().Next(-99999, 100001);
Console.WriteLine(number);

int lastDigit = 0;
if (number < 100 && number > -100)
{
    Console.WriteLine("третьей цифры нет");
}
else if (number > 99)
{
    while (number > 99)
    {
        lastDigit = number % 10;
        number = number / 10;
    }
    Console.WriteLine(lastDigit);
}
else if (number < -99)
{
    while (number < -99)
    {
        lastDigit = number % 10;
        number = number / 10;
    }
    Console.WriteLine(lastDigit * -1);
}

