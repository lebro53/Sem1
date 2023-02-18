// Methods-----------------------------------------
string Promt(string massege)
{
	Console.Write(massege);
	string value = Console.ReadLine();
	return value;
}
string Quarter(string num)
{
	if (num == "1") return "X > 0, Y > 0";
	if (num == "2") return "X < 0, Y > 0";
	if (num == "3") return "X < 0, Y < 0";
	if (num == "4") return "X > 0, Y < 0";
	else return "0";
}

// Another code ---------------------------------------
string number = Promt("Введите число: ");
if (Quarter(number) == "0") Console.WriteLine("Error. Введите число от 1 до 4!");
else Console.WriteLine($"Введенный номер четверти {number} соответствует значению координат {Quarter(number)}");