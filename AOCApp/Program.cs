// See https://aka.ms/new-console-template for more information

namespace AOCApp;

public class Program
{
    public static void Main()
    {
        Days.Day01();
        // Console.WriteLine();
        // Console.WriteLine();
        // var sum = 0;
        // foreach (var line in ReadFromFile("/home/lift/projects/AdventOfCode2023/AOCApp/Input/Day012.txt"))
        // {
        //     Console.Write(line.ToString() + ", ");
        //     sum += line;
        // }
        //
        // Console.WriteLine(sum);

        
    }
    
    private static List<int> ReadFromFile(string _path)
    {
        var reader = new StreamReader(_path);
        List<int> _results = [];
        while (reader.ReadLine() is { } line)
        {
            _results.Add(Int32.Parse(line));
        }

        return _results;
    }
}