// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите число");

int x = new Random().Next (100, 1000);
int x1 = x / 10;
int x2 = x1 % 10;
    
Console.WriteLine(x);
Console.WriteLine(x1);
Console.WriteLine(x2);
    
    


