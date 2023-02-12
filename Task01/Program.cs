Console.Write("Введите первое число: ");
double numberOne = Convert.ToDouble(Console.ReadLine()); // Заменил int на double для расширения возможностей
Console.Write("Введите первое число: ");
double numberTwo = Convert.ToDouble(Console.ReadLine());
double sqrTwo = numberTwo * numberTwo;
if (sqrTwo == numberOne)
{
	Console.WriteLine("Да, первое число является квадратом второго");
}
else
{
	Console.WriteLine("Нет, первое число не является квадратом второго");
}