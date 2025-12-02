Console.WriteLine("Hello, Advent of Code!");

var lines = File.ReadAllLines("input/day1.input");

int dail = 50;
int password = 0;

foreach (var line in lines)
{
	Console.WriteLine($"Current dail position: {dail}");
	Console.WriteLine($"Instruction: {line}");
	Console.WriteLine($"Password so far: {password}");
	var count = int.Parse(line[1..]);
	var hits = 0;
	switch (line)
	{
		case string s when s[0] is 'L':
			if (dail == 0)
			{
				hits = count / 100;
			}
			else if (count >= dail)
			{
				hits = 1 + (count - dail) / 100;
			}
			dail = (dail - count) % 100;
			if (dail < 0)
			{
				dail += 100;
			}
			break;
		case string s when s[0] is 'R':
			hits = (dail + count) / 100;
			dail = (dail + count) % 100;
			break;
	}
	password += hits;
}

Console.WriteLine($"Password: {password}");
