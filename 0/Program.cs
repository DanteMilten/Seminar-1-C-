// Напишите программу, которая на вход принимает число и выдает его квадрат
// (Число умноженное на само себя).

Console.Clear();
Console.Write("ВВедите число: ");
int number = int.Parse(Console.ReadLine());
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} = {sqr}");
