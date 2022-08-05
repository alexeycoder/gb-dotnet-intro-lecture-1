Console.CursorVisible = false;
Console.Clear();

// int xa = 40;
// int ya = 1;
// int xb = 1;
// int yb = 30;
// int xc = 80;
// int yc = 30;

int xa = Console.BufferWidth / 2 - 1;
int ya = 1;

int xb = 1;
int yb = Console.BufferHeight - 2;

int xc = Console.BufferWidth - 2;
int yc = Console.BufferHeight - 2;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa;
int y = yb;

int count = 0;

Thread.Sleep(5000);

while (count < 5000)
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
	Console.WriteLine("■");
	Thread.Sleep(3);
	++count;
}

Console.SetCursorPosition(0, yc + 1);

static ConsoleColor GetColorByCoord(double coord, double maxCoord)
{
	const double maxColorValue = 15;
	int scaledValue = (int)Math.Round(coord * (maxColorValue / maxCoord), MidpointRounding.AwayFromZero);
	return (ConsoleColor)scaledValue;
}