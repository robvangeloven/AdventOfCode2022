
var elves = new List<Elf>();

var currentElf = new Elf();

foreach (var line in File.ReadLines("input.txt"))
{
    if (string.IsNullOrWhiteSpace(line))
    {
        elves.Add(currentElf);
        currentElf = new Elf();
    }
    else
    {
        currentElf.Calories.Add(int.Parse(line));
    }
}

Console.WriteLine($"The {nameof(Elf)} with the most {nameof(Elf.Calories)} is carrying {elves.Max(elf => elf.Calories.Sum())} {nameof(Elf.Calories)}.");

var topThreeElvesCalories = elves
    .OrderByDescending(elf => elf.Calories.Sum())
    .Take(3)
    .Sum(elf => elf.Calories.Sum());


Console.WriteLine($"The top three elves are carrying {topThreeElvesCalories} {nameof(Elf.Calories)}.");

Console.ReadKey();

internal record Elf
{
    public IList<int> Calories { get; } = new List<int>();
}