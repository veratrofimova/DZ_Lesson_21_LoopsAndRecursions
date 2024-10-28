using DZ_Lesson_21_LoopsAndRecursions;
using System.Diagnostics;

Console.WriteLine("Добро пожаловать в программу: Циклы и рекурсии");
Console.WriteLine("Реализованы методы нахождения n-го члена последовательности Фибоначчи по формуле F(n) = F(n-1) + F(n-2)");
Console.WriteLine("Введите значение n");

try
{
    long n = long.Parse(Console.ReadLine());
    Console.WriteLine();

    Stopwatch stopwatch = Stopwatch.StartNew();

    stopwatch.Start();
    Fibonacci.Recursive(1, 1, 0, n);
    stopwatch.Stop();
    Console.WriteLine($"Нахождение через рекурсию заняло: {stopwatch.ElapsedMilliseconds} миллисекунд\r\n");
    stopwatch.Reset();

    stopwatch.Start();
    Fibonacci.Loop(1, 1, 0, n);
    stopwatch.Stop();
    Console.WriteLine($"Нахождение через цикл заняло: {stopwatch.ElapsedMilliseconds} миллисекунд");    
}
catch (FormatException)
{
    Console.WriteLine("Введите число");
}
catch (Exception)
{
    throw;
}