﻿// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Веедите трехзначное число:");
int numb = Convert.ToInt32 (Console.ReadLine());
// int res = (numb / 10) % 10;
// Console.WriteLine($"Вторая цифра числа {numb} -> {res}");

Console.WriteLine($"Вторая цифра числа {numb} -> {(numb / 10) % 10}");