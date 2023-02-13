//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// -----------------

Console.Write("Введите первое число: ");
double numberOne = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите первое число: ");
double numberTwo = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите первое число: ");
double numberThree = Convert.ToDouble(Console.ReadLine());
double max = numberOne;
if (max < numberTwo) max = numberTwo;
if (max < numberThree) max = numberThree;
Console.WriteLine($"Максимальное число {max}");

