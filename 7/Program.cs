// Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает последнюю цифру этого числа.
//	456 -> 6
//	782 -> 2
//	918 -> 8

Console.Clear();
Console.WriteLine("Первый метод");
Console.Write("ВВедите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100 || num > 999){
    Console.WriteLine("Введено нерпавльное число");
    return;
}
int otvet = num % 10;
Console.WriteLine($"3 цифра: {otvet}");
Console.WriteLine("---------------------");
Console.WriteLine("Второй метод");
string number = Console.ReadLine();
string otvet2 = Convert.ToString(number[2]);
Console.WriteLine($"3 цифра: {otvet2}");
