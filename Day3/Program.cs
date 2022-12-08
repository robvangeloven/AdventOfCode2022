var part1 = File.ReadLines("input.txt")
    .SelectMany(line =>
    {
        var compartmentSize = line.Length / 2;

        var compartmentOne = line.Substring(0, compartmentSize);
        var compartmentTwo = line.Substring(compartmentSize, compartmentSize);

        var commonItems = compartmentOne
        .Intersect(compartmentTwo)
        .Select(commonItem => char.IsUpper(commonItem) ? commonItem - 'A' + 27 : commonItem - 'a' + 1);

        return commonItems;
    })
    .Sum();

var part2 = File.ReadLines("input.txt")
    .Chunk(3)
    .SelectMany(elfBags =>
    {
        var badgeValues = elfBags[0]
        .Intersect(elfBags[1])
        .Intersect(elfBags[2])
        .Select(commonItem => char.IsUpper(commonItem) ? commonItem - 'A' + 27 : commonItem - 'a' + 1);

        return badgeValues;
    })
    .Sum();

Console.WriteLine($"Sum of priorities is: {part1}");
Console.WriteLine($"Sum of badges is: {part2}");
Console.ReadKey();