Console.Clear();
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");

int xa = 40;
int ya = 1;
int xb = 1;
int yb = 30;
int xc = 80;
int yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

Console.CursorVisible = false;

int x = xa;
int y = yb;

int count = 0;

Thread.Sleep(5000);

while (count < 3000)
{
	int what = new Random().Next(0, 3);
	if (what == 0)
	{
		x = (x + xa) / 2;
		y = (y + ya) / 2;
	}

	if (what == 1)
	{
		x = (x + xb) / 2;
		y = (y + yb) / 2;
	}

	if (what == 2)
	{
		x = (x + xc) / 2;
		y = (y + yc) / 2;
	}

	Console.ForegroundColor = GetColorByCoord(x + y, xc + yc);
	Console.SetCursorPosition(x, y);
	Console.WriteLine("*");
	Thread.Sleep(5);
	++count;
}

Console.SetCursorPosition(0, yc + 1);

static ConsoleColor GetColorByCoord(double coord, double maxCoord)
{
	const double maxColorValue = 15;
	int scaledValue = (int)Math.Round(coord * (maxColorValue / maxCoord), MidpointRounding.AwayFromZero);
	return (ConsoleColor)scaledValue;
}