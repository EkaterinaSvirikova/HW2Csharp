//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 6
//78 -> третьей цифры нет
//32679 -> 6

using System;
using static System.Console;

Clear();

WriteLine($"Введите число: ");
int number = Convert.ToInt32(ReadLine());

if(number / 100 > 0)
{
    WriteLine($"Третьей справа цифрой числа {number} является {number / 100 % 10}");
}
else
{
   WriteLine($"У числа {number} нет третьей справа цифры");
}
WriteLine();

// Еще одно решение с использованием тернарного оператора

//string answer = number / 100 > 0 ? $"Третьей справа цифрой числа {number} является {(number / 100) % 10}" 
//: $"У числа {number} нет третьей справа цифры";
//WriteLine(answer);
//WriteLine();

