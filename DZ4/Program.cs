﻿//  Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine());
int max=a;
if(a>b & a>c){
    max = a;
} else if(b>a & b>c){
    max = b;
} else if(c>a & c>b){
    max = c;
}
Console.WriteLine($"Масксимальное число {max}");
