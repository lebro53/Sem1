// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет



// Console.WriteLine("Введите цифру обозначающую день недели: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 1 && number < 8)
// {
// 	if (number >= 1 && number < 6) Console.WriteLine("Нет");
// 	else Console.WriteLine("Да");
// }
// else Console.WriteLine("Число должно быть от 1 до 7!");

int Promt(string massege)
{
	Console.WriteLine(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}

bool ValidateWeekDay(int num)
{
	if (num > 0 && num <= 7)
	{
		return true;
	}
	Console.WriteLine("Число должно быть от 1 до 7!");
	return false;
}

bool WeekDay(int num)
{
	if (num == 6 || num == 7)
	{
		return true;
	}
	return false;
}

int number = Promt("Введите число: ");
if (ValidateWeekDay(number))
{
	if (WeekDay(number))
	{
		Console.WriteLine("Это выходной день");
	}
	else Console.WriteLine("Это НЕ выходной день!");
}