// int FactorialRec(int n)
// {
// if (n == 1) return 1;
// else return n * FactorialRec(n - 1);
// }
// Console.WriteLine(FactorialRec(10)); // 3628800

// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


// Method--------------------------------------------------
int Promt(string massege)
{
	Console.WriteLine(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}

int SumElemNumber(int n)
{
	if (n <= 0) return 0;
	else return n % 10 + SumElemNumber(n / 10);
}

// Program body--------------------------------------------
int number = Promt("Введите число: ");
int sumElem = SumElemNumber(number);
Console.WriteLine(sumElem);