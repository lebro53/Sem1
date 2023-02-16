// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Promt(string massege)
{
	Console.WriteLine(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}

int GetThirdRank(int num)
{
	while (num > 999)
	{
		num = num / 10;
	}
	return num % 10;
}

bool ValidateNumber(int num)
{
	if (num < 100)
	{
		Console.WriteLine("Третьей цифры нет!");
		return false;
	}
	return true;
}

int number = Promt("Введите число: ");
if (ValidateNumber(number))
{
	Console.WriteLine("Третья цифра числа = " + GetThirdRank(number));
}

// if (number > 100)
// {
// 	while (number > 999)
// 	{
// 		number = number / 10;
// 	}
// 	Console.WriteLine($"Третья цифра заданного числа = {number % 10}");
// }
// else if (number <= 0) Console.WriteLine("Число должно быть больше 0!");
// else Console.WriteLine("Третьей цифры нет!");