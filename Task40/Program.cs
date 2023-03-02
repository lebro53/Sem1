// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

// Method--------------------------------------------------
int Promt(string massege)
{
	Console.WriteLine(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}
bool ExistenceTriangel(int num1, int num2, int num3)
{
	if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2) return false;
	else return true;
}


// Program body--------------------------------------------
int numberOne = Promt("Введите размер первой стороны треугольника: ");
int numberTwo = Promt("Введите размер второй стороны треугольника: ");
int numberThree = Promt("Введите размер третьей стороны треугольника: ");
if (ExistenceTriangel(numberOne, numberTwo, numberThree)) Console.WriteLine("Такой треугольник не существует");
else Console.WriteLine("Такой треугольник существует");