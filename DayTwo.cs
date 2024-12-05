// Advent of Code 2024 Day Two

namespace AdventOfCode;

public class DayTwo
{
    private const string InputFile = "X:\\Rider Projects\\AdventOfCode\\input2.txt";
    private readonly string[] _inputLines = File.ReadAllLines(InputFile);
    private int safeReports;
    private int safeLevel;
    
    public DayTwo()
    {
        List<int[]> data = new List<int[]>();
        safeReports = _inputLines.Length;
        
        foreach (string line in _inputLines)
        {
            int[] numbers = Array.ConvertAll(line.Trim().Split(' '), int.Parse);
            data.Add(numbers);
        }

        foreach (int[] numbers in data)
        {
            int j = 1;
            int d = 0;

            for (int i = 0; i < numbers.Length && j < numbers.Length; i++)
            {
                int temp = numbers[i] - numbers[j];
                
                // Shitcode for 4th condition
                bool a = numbers[i] < numbers[i + 1];
                bool b = numbers[i] > numbers[i + 1];
                int c;

                if (a)
                {
                    c = 1;
                }
                else if (b)
                {
                    c = -1;
                }
                else
                {
                    c = 0;
                }

                if (d != 0 && c != 0 && c != d)
                {
                    safeReports--;
                    break;
                } 
                
                // Other conditions
                if (temp > 3 || temp == 0 || Math.Abs(temp) > 3)
                {
                    safeReports--;
                    break;
                }
                
                d = c;
                j++;
            }
        }
        
        Console.WriteLine("Safe reports: "  + safeReports);
    }
}

// No I did not feel like doing part two.
