﻿ //Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
 //4 -> да
//-3 -> нет
//7 -> нет


Console.Write("введите число, a");
int a = Console.Read();
 
if (a % 2==1)
{
Console.WriteLine("число нечетное");         
}
else
{
Console.WriteLine("Число четное");
}