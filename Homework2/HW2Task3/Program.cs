﻿//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
    Console.WriteLine("Да");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine("Нет");
  }
  else 
    Console.WriteLine("Нет");
}
CheckingTheDayOfTheWeek(dayNumber);