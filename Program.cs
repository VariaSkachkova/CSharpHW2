Console.WriteLine ("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine("Решение через математику");
Console.WriteLine("Введите целое число от 0 до 1 000 000: ");
int number = Convert.ToInt32(Console.ReadLine());
Task13(number);
void Task13(int arg)
{
    if (arg < 100)
    {
        Console.WriteLine("В этом числе нет третьей цифры");
    }
    else if (arg < 1000)
    {
        int digit3 = arg % 100 % 10;
        Console.WriteLine($"Третья цифра числа: {digit3}");
    }
    else if (arg < 10000)
    {
        int digit3 = arg % 1000 % 100 / 10;
        Console.WriteLine($"Третья цифра числа: {digit3}");
    }
    else if (arg < 100000)
    {
        int digit3 = arg % 1000 / 100;
        Console.WriteLine($"Третья цифра числа: {digit3}");
    }
    else if (arg < 1000000)
    {
        int digit3 = arg % 10000 / 1000;
        Console.WriteLine($"Третья цифра числа: {digit3}");
    }
}

Console.WriteLine ("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine("Решение через string");
Console.WriteLine("Введите целое число: ");
string n = Console.ReadLine();
int length = n.Length;
Task13Alt(n);
void Task13Alt(string arg)
{
    if (length < 3)
    {
        Console.WriteLine("В этом числе нет третьей цифры");
    }
    if (length >= 3)
    {
        Console.WriteLine($"Третья цифра числа: {arg[2]}");
    }
    
}

Console.WriteLine ("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным."); 

Console.WriteLine("Введите число от 1 до 7: ");
int num = Convert.ToInt32 (Console.ReadLine ());
Task15(num);
void Task15(int arg)
{
if (arg == 1 || arg == 2 || arg == 3 || arg == 4 || arg == 5) 
{ Console.WriteLine("Увы, сегодня суровый будень.");}
else if (arg == 6 || arg == 7) {Console.WriteLine("Ура, сегодня выходной!");}
else {Console.WriteLine("Учимся считать до 7");}
}