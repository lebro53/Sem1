// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// Method--------------------------------------------------
int Promt(string massege)
{
	Console.WriteLine(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}
bool ChekingNaturalNumber(int num1, int num2)
{
	if (num1 <= 0 || num2 <= 0) return false;
	else return true;
}
void NaturalNumberToN(int num1, int num2)
{
	if (num1 > num2)
	{
		Console.Write($"{num1} ");
		NaturalNumberToN(num1 - 1, num2);
	}
	else if (num2 > num1)
	{
		NaturalNumberToN(num1, num2 - 1);
		Console.Write($"{num2} ");
	}
	else Console.Write($"{num1} ");
}

// Program body--------------------------------------------
int numberOne = Promt("Введите натуральное число N: ");
int numberTwo = Promt("Введите натуральное число M: ");
if (ChekingNaturalNumber(numberOne, numberTwo) == false) Console.WriteLine("Введите натуральное число!");
else NaturalNumberToN(numberOne, numberTwo);