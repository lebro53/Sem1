// Methods-----------------------------------------
int Promt(string massege)
{
	Console.Write(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}
int Quarter(int pointX, int pointY)
{
	if (pointX > 0 && pointY > 0) return 1;
	if (pointX < 0 && pointY < 0) return 3;
	if (pointX < 0 && pointY > 0) return 2;
	if (pointX > 0 && pointY < 0) return 4;
	else return 0;
}
bool ConditionCheck(int pointX, int pointY)
{
	if (pointX != 0 && pointY != 0)
	{
		return true;
	}
	Console.WriteLine("Координаты числа A не должны быть равны 0");
	return false;
}

// Another code----------------------------------------------

int xa = Promt("Введи координату х для точки А: ");
int ya = Promt("Введи координату у для точки А: ");

if (ConditionCheck(xa, ya)) Console.WriteLine($"Данные координаты соответствуют {Quarter(xa, ya)} четверти");
