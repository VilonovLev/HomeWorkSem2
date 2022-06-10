﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("------------------\nВведите трехзначное число: ");
int inputTask10 = Convert.ToInt32(Console.ReadLine());
string resultTask10 = "Вы ввели не трёхзначное число!";

if (inputTask10 < 0)
{
    inputTask10 *= -1;
}
if (inputTask10 < 999 && inputTask10 > 100) 
{
    resultTask10 = Convert.ToString(inputTask10 % 100 / 10);
}
Console.WriteLine(resultTask10);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.Write("------------------\nВведите число: ");
int inputTask13 = Convert.ToInt32(Console.ReadLine());
string resultTask13 = "Третьей цифры нет!";

if (inputTask13 < 0)
{
inputTask13 *= -1;
}
if (inputTask13 > 100) 
{
    while ( inputTask13 > 999)
    {
        inputTask13 = inputTask13 / 10;
    }
    inputTask13 = inputTask13 % 10;
    resultTask13 = Convert.ToString(inputTask13);
}
Console.WriteLine(resultTask13);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("------------------\nВведите номер дня недели: ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
string output;

if ( dayOfWeek > 7 || dayOfWeek < 1)
{
    output = "Вы ввели не день недели!";
}
else if (dayOfWeek != 6 && dayOfWeek != 7)
{
    output = "Нет";
}
else
{
    output = "Да";
}
Console.WriteLine(output);

// Доп. задача 16: Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.

Console.Write("------------------\nВведите два числа: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
int secondNum = Convert.ToInt32(Console.ReadLine());
string outputTask16 = "Нет"; 

if (firstNum * firstNum == secondNum || secondNum * secondNum == firstNum)
{
    outputTask16 = "Да";
}
Console.WriteLine(outputTask16);