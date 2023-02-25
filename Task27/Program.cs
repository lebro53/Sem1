// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Methods-----------------------------------------
int Promt(string massege)
{
	Console.Write(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}
int SumDigitsNumber(int num)
{
	int sum = 0;
	while (num != 0)
	{
		sum = sum + num % 10;
		num /= 10;
	}
	return sum;
}

// Program body------------------------------------
int number = Promt("Введите число: ");
if (number > 0) Console.WriteLine($"Сумма цифр в числе {number} = {SumDigitsNumber(number)}");
else Console.WriteLine("Ошибка! Введите положительное число.");
