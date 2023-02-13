// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// -------------------------

Console.Write("Введите первое число: ");
double numberOne = Convert.ToDouble(Console.ReadLine()); //Заменил int на double
Console.Write("Введите второе число: ");
double numberTwo = Convert.ToDouble(Console.ReadLine());
if (numberOne > numberTwo)
{
	Console.Write($"Число {numberOne} больше числа {numberTwo}");
}
else
{
	Console.Write($"Число {numberTwo} больше числа {numberOne}");
}