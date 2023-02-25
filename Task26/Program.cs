// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Methods-----------------------------------------
int Promt(string massege)
{
	Console.Write(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}
int Quantity(int num)
{
	int i = 0;
	if (num == 0) return 1;
	else
	{
		for (i = 0; num != 0; i++)
		{
			num = num / 10;
		}
		return i;
	}
}

// Program body------------------------------------

int number = Promt("Введите число: ");
int quantity = Quantity(number);
Console.WriteLine($"Количество цифр в числе {number} = {quantity}");

