﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if(a > b) 
{
    Console.WriteLine($" число {a} большее");
} 
else 
{
    Console.WriteLine($" число {b} большее");
}
