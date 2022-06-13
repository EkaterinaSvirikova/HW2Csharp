//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

using System;
using static System.Console;

Clear();

WriteLine($"Введите цифру, соответствующую дню недели: ");
int dayNumber = Convert.ToInt32(ReadLine());

if(dayNumber == 1) WriteLine("Это Понедельник, рабочий день, не является выходным");
else if(dayNumber == 2) WriteLine("Это Вторник, рабочий день, не является выходным");
else if(dayNumber == 3) WriteLine("Это Среда, рабочий день, не является выходным");
else if(dayNumber == 4) WriteLine("Это Четверг, рабочий день, не является выходным");
else if(dayNumber == 5) WriteLine("Это Пятница, рабочий день, не является выходным");
else if(dayNumber == 6) WriteLine("Это Суббота, Ура! Это выходной!");
else if(dayNumber == 7) WriteLine("Это Воскресенье, Ура! Это выходной!");
else WriteLine("В неделе нет такого дня");

WriteLine();
