var totalPart1 = 0;
var totalPart2 = 0;

int Mod(int a, int b) => ((a % b) + b) % b;

int CalculateScore(int elfMove, int myMove) => (Mod(myMove - elfMove + 1, 3) * 3) + (myMove + 1);

foreach (var line in File.ReadLines("input.txt"))
{
    if (line.Split(' ') is [var elfMove, var myMove])
    {
        var elfMoveValue = (elfMove[0] - 'A');
        var myMoveValue = (myMove[0] - 'X');

        totalPart1 += CalculateScore(elfMoveValue, myMoveValue);

        myMoveValue = Mod(elfMoveValue + myMoveValue - 1, 3);

        totalPart2 += CalculateScore(elfMoveValue, myMoveValue);
    }
}

Console.WriteLine($"Total score is part 1: {totalPart1}.");
Console.WriteLine($"Total score is part 2: {totalPart2}.");
Console.ReadKey();
