// Advent of Code 2024 Day Three

using System.Text.RegularExpressions;

namespace AdventOfCode;

public class DayThree
{
    
    private const string InputFile = "X:\\Rider Projects\\AdventOfCode\\input3.txt";
    private readonly string _input = File.ReadAllText(InputFile);
    private readonly string regexPattern = @"mul\((?'x'\d+),(?'y'\d+)\)";
    
    public DayThree()
    {
        MatchCollection matches = Regex.Matches(_input, regexPattern);
        List<int> processed = new List<int>();

        foreach (Match match in matches)
        {
            // Extract the values from named groups
            int x = int.Parse(match.Groups["x"].Value);
            int y = int.Parse(match.Groups["y"].Value);
            int z = x * y;

            processed.Add(z);
        }

        Console.Write("Output: " + processed.Sum());
    }
}
