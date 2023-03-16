// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Method--------------------------------------------------
int Promt(string massege)
{
	Console.WriteLine(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}

int SquareElem(int n, int m)
{
	if (m == 0) return 1;
	else return n * SquareElem(n, m - 1);
}

// Program body--------------------------------------------
int number1 = Promt("Введите число: ");
int number2 = Promt("Введите число: ");
int sumElem = SquareElem(number1, number2);
Console.WriteLine(sumElem);