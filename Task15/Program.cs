// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели от 1 до 7: ");
int daynum = Convert.ToInt32(Console.ReadLine());
if (daynum >= 1 && daynum <= 5)
{
    Console.WriteLine("день не является выходным");
}
else if (daynum == 6 || daynum == 7)
{
    Console.WriteLine("Это выходной день");
}
else
{
    Console.WriteLine("Неверное число. Введите номер от 1 до 7");
}

