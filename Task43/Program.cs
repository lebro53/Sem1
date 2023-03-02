// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// y = 5*x + 2; y = 9*x +4; 5*x+2=9x+4; -2=4x

// Method--------------------------------------------------
int Promt(string massege)
{
	Console.WriteLine(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}
double PointX(double numK1, double numK2, double numB1, double numB2)
{
	double x = Math.Round((numB2 - numB1) / (numK1 - numK2), 1, MidpointRounding.ToZero);
	return x;
}
double PointY1(double numX, double numK1, double numB1)
{
	double Y1 = numK1 * numX + numB1;
	return Y1;
}
double PointY2(double numX, double numK2, double numB2)
{
	double Y2 = numK2 * numX + numB2;
	return Y2;
}

// Program body--------------------------------------------
double k1 = Promt("Введите значение k1: ");
double k2 = Promt("Введите значение k2: ");
double b1 = Promt("Введите значение b1: ");
double b2 = Promt("Введите значение b2: ");
if (k1 == k2 && b1 == b2) Console.WriteLine("Данные прямые являются одним и тем же.");
else if (k1 == k2) Console.WriteLine("Данные прямые являются параллельными.");
else
{
	double x = PointX(k1, k2, b1, b2);
	double y1 = PointY1(x, k1, b1);
	double y2 = PointY2(x, k2, b2);
	Console.WriteLine($"Данные прямые пересекаются в точках ({y1}, {y2})");   //5924
}

