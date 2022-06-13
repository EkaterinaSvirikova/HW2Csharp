//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

using System;
using static System.Console;

Clear();

WriteLine($"Введите трехзначное число: ");
int number = Convert.ToInt32(ReadLine());

WriteLine($"Второй цифрой числа {number} является {number / 10 % 10} ");
