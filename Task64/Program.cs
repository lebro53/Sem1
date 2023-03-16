// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Method--------------------------------------------------
int Promt(string massege)
{
	Console.WriteLine(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}

void SquareElem(int num)
{
	if (num == 0) return;
	Console.Write($"{num}, ");
	SquareElem(num - 1);

}

// Program body--------------------------------------------
int number = Promt("Введите число: ");
Console.Write($"N = {number} -> ");
SquareElem(number);
