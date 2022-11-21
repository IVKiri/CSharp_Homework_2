// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = new Random().Next(10, 100001);
Console.WriteLine(number);
int last_digit = 0;
if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else {
    while (number > 99) {
        last_digit = number%10;
        number = number / 10;
    }
}
Console.WriteLine(last_digit);
