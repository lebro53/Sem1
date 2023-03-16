// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Method--------------------------------------------------
int Promt(string massege)
{
	Console.WriteLine(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}
bool CheckMGreatN(int num1, int num2)
{
	if (num1 >= num2 || num2 <= 0) return false;
	else return true;
}
int SumElemMToN(int num1, int num2)
{
	if (num1 % 2 == 0)
	{
		if (num2 <= num1 / 2 - 1) return 0;
		else return num1 + SumElemMToN(num1 + 1, num2 - 1);
	}
	else
	{
		if (num2 <= num1 / 2) return 0;
		else return num1 + SumElemMToN(num1 + 1, num2 - 1);
	}
}

// Program body--------------------------------------------
int number1 = Promt("Введите первое число : ");
int number2 = Promt("Введите второе число : ");
int sumElem = SumElemMToN(number1, number2);
if (CheckMGreatN(number1, number2) == true) Console.WriteLine($"M - {number1}; N - {number2} -> {sumElem}");
else Console.WriteLine("Ошибка, попробуйте другие значения");