// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Methods-----------------------------------------
int Promt(string massege)
{
	Console.Write(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}
int Square(int numA, int numB)
{
	int sqr = 1;
	for (int i = 1; i <= numB; i++)
	{
		sqr = sqr * numA;
	}
	return sqr;
}

// Program body------------------------------------
int numberA = Promt("Введите число А: ");
int numberB = Promt("Введите натуральное число B: ");
if (numberB > 0) Console.WriteLine($"Число {numberA} в степени {numberB} = {Square(numberA, numberB)}");
else Console.WriteLine("Ошибка! Введено не натуральное число. Повторите ввод.");