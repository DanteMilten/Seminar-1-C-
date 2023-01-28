// Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдает, какое число большее, а какое меньшее.
//a = 5; b = 7 ->  max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("ВВедите второе число: ");
int number2 = int.Parse(Console.ReadLine());
int max;
if (number1>number2){
    Console.WriteLine($"max = {number1} min = {number2}");
} else {
        Console.WriteLine($"max = {number2} min = {number1}");

}