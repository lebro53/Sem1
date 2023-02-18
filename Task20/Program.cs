// Methods-----------------------------------------
int Promt(string massege)
{
	Console.Write(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}
double Distance(int xa, int ya, int xb, int yb)
{
	int square = ((xa - xb) * (xa - xb)) + ((ya - yb) * (ya - yb));
	double result = Math.Sqrt(square);
	return result;
}


// Program body ------------------------
int pointAX = Promt("Введите координату X точки А: ");
int pointAY = Promt("Введите координату Y точки А: ");
int pointBX = Promt("Введите координату X точки B: ");
int pointBY = Promt("Введите координату Y точки B: ");
double root = Distance(pointAX, pointAY, pointBX, pointBY);
Console.WriteLine($"Расстояние между точками А и В = {Math.Round(root, 2, MidpointRounding.ToZero)}");