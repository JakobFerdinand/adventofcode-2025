Console.WriteLine("Hello, Advent of Code!");

var lines = File.ReadAllLines("input/day1.sample");

int dail = 50;
int password = 0;

foreach (var line in lines)
{
	Console.WriteLine($"Current dail position: {dail}");
	switch (line)
	{
		case string s when s[0] is 'L':
			var x = int.Parse(s[1..]);
			dail -= x % 100;
			if (dail < 0)
			{
				dail += 100;
			}
			break;
		case string s when s[0] is 'R':
			var y = int.Parse(s[1..]);
			dail += y % 100;
			if (dail >= 100)
			{
				dail -= 100;
			}
			break;
	}
	if (dail is 0)
	{
		password++;
	}
}

Console.WriteLine($"Password: {password}");
