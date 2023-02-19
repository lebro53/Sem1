// Methods-----------------------------------------
int Promt(string massege)
{
	Console.Write(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}
double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
	int square = ((xa - xb) * (xa - xb)) + ((ya - yb) * (ya - yb)) + ((zb - za) * (zb - za));
	double result = Math.Sqrt(square);
	return result;
}

// Program body ------------------------
int pointAX = Promt("Введите координату X точки А: ");
int pointAY = Promt("Введите координату Y точки А: ");
int pointAZ = Promt("Введите координату Z точки A: ");
int pointBX = Promt("Введите координату X точки B: ");
int pointBY = Promt("Введите координату Y точки B: ");
int pointBZ = Promt("Введите координату Z точки B: ");

double root = Distance(pointAX, pointAY, pointAZ, pointBX, pointBY, pointBZ);
Console.WriteLine($"Расстояние между точками А и В = {Math.Round(root, 2, MidpointRounding.ToZero)}");