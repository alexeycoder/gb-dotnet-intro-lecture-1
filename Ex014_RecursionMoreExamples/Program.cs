// Собрать строку с числами от a до b, a <= b

Console.WriteLine(NumbersFor(5, 28));
Console.WriteLine(NumbersRec(5, 28));
Console.WriteLine(NumbersRecV2(5, 28));

static string NumbersFor(int a, int b)
{
	string result = string.Empty;
	for (int i = a; i <= b; ++i)
	{
		result += $"{i} ";
	}
	return result;
}

static string NumbersRec(int a, int b)
{
	if (a <= b)
		return $"{a} " + NumbersRec(a + 1, b);

	return string.Empty;
}

static string NumbersRecV2(int a, int b)
{
	if (a < b)
		return $"{a} " + NumbersRec(a + 1, b);

	return a.ToString();
}

// Собрать строку с числами от a до b, a >= b

Console.WriteLine(NumbersForDescending(55, 32));
Console.WriteLine(NumbersRecDescending(55, 32));

static string NumbersForDescending(int a, int b)
{
	string result = string.Empty;
	for (int i = a; i >= b; --i)
	{
		result += $"{i} ";
	}
	return result;
}

static string NumbersRecDescending(int a, int b)
{
	if (a > b)
		return $"{a} " + NumbersRecDescending(a - 1, b);

	return a.ToString();
}

// Сумма чисел от 1 до n

Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));
Console.WriteLine(SumArithmeticProgression(10));

static int SumFor(int n)
{
	int result = 0;
	for (int i = 1; i <= n; ++i)
	{
		result += i;
	}

	return result;
}

static int SumRec(int n)
{
	if (n == 1)
		return 1;

	return n + SumRec(n - 1);
}

static int SumArithmeticProgression(int n)
{
	return n * (1 + n) / 2;
}

// Факториал числа

Console.WriteLine(FactorialFor(10));
Console.WriteLine(FactorialRec(10));

static int FactorialFor(int n)
{
	int result = 1;
	for (int i = 1; i <= n; ++i)
	{
		result *= i;
	}

	return result;
}

static int FactorialRec(int n)
{
	if (n <= 1)
		return 1;

	return n * FactorialRec(n - 1);
}

// Вычислить a в натуральной степени n

Console.WriteLine(PowerFor(2, 5));
Console.WriteLine(PowerRec(2, 5));

static double PowerFor(double a, int n)
{
	double result = 1;
	for (int i = 1; i <= n; ++i)
	{
		result *= a;
	}

	return result;
}

static double PowerRec(double a, int n)
{
	if (n == 0)
		return 1;

	return PowerRec(a, n - 1) * a;
}
