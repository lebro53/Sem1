// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Methods-----------------------------------------
int Promt(string massege)
{
	Console.Write(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}
int Factorial(int num)
{
	int i = 0;
	int factorial = 1;
	checked
	{
		for (i = 1; i <= num; i++)
		{
			factorial = factorial * i;
		}
		return factorial;
	}
}

// Program body------------------------------------

int number = Promt("Введите целое положительное число: ");
int factorial = Factorial(number);
Console.WriteLine($"Факториал числа {number} = {factorial}");
