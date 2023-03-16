// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Method--------------------------------------------------
int Promt(string massege)
{
	Console.WriteLine(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}

void NaturalNumberToN(int num)
{
	if (num == 0) return;

	NaturalNumberToN(num - 1);
	Console.Write($"{num} ");
}

// Program body--------------------------------------------
int number = Promt("Введите натуральное число N: ");
NaturalNumberToN(number);