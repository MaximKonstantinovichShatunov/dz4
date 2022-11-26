﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число  ");
int Namber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма всех цифр в числе = {summaNambersInNamber(Namber)}");
int summaNambersInNamber(int N)
{
    int sum = 0;
    while (N > 0)
    {
        sum = sum + N % 10;
        N = N / 10;
    }
    return sum;
}



