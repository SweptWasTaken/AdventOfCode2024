// Advent of Code 2024 Day One

namespace AdventOfCode;

public class DayOne
{
    static string inputFile = "X:\\Rider Projects\\AdventOfCode\\input.txt";
    
    List<int> listOne = new List<int>();
    List<int> listTwo = new List<int>();
    List<int> output = new List<int>();
    
    public void ListSorter(List<int> arr)
    {
        int n = arr.Count;
        
        for (int i = 0; i < n - 1; i++)
        {
            bool swap = false;
            
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
    
                    swap = true;
                }
            }
            
            if (!swap)
            {
                break;
            }
        }
    }
    
    public void ListCounter(List<int> arrx, List<int> arry, List<int> outputList)
    {
        for (int i = 0; i < arrx.Count; i++)
        {
            int temp = Math.Abs(arry[i] - arrx[i]);
            outputList.Add(temp);
        }
    }
    
    // Main
    public DayOne()
    {
        string[] inputLines = File.ReadAllLines(inputFile);
        
        for (int i = 0; i < inputLines.Length; i++)
        {
            string[] parts = inputLines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            listOne.Add(int.Parse(parts[0]));
            listTwo.Add(int.Parse(parts[1]));
        }
        
        ListSorter(listOne);
        ListSorter(listTwo);
    
        ListCounter(listOne, listTwo, output);
        Console.WriteLine(output.Sum());
    }    
}
