﻿// Дополнительные задачи.
//Задача 3. Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.

int n = 349;

Digit(n);

void Digit(int n)
{
    if (n/100 == 4 | n%100/10 == 4 | n%10 == 4 | n/100 == 7 | n%100/10 == 7 | n%10 == 7)
    {
        Console.Write("Есть 4 или 7");
    }
    else
    {
        Console.WriteLine("Нет 4 или 7");
    }
}