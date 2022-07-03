/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите номер дня недели");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if(numberStr = 7)
{
    Console.WriteLine("Выходной воскресенье");
}
else if(numberStr = 6)
{
    Console.WriteLine("Выходной суббота");
}
else(numberStr = 1..5)
{
    Console.WriteLine("Рабочий день");
}

 