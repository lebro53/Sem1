Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int sqrTwo = numberTwo * numberTwo;
if (sqrTwo == numberOne)
{
	Console.WriteLine("Да, первое число является квадратом второго");
}
else
{
	Console.WriteLine("Нет, первое число не является квадратом второго");
}